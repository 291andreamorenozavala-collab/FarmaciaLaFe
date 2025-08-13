using Microsoft.Data.SqlClient;
using System.Collections;
using System.Data;

namespace Capa_Datos
{
    public class AccesoDatos
    {
        private static readonly string xCONEXION = ConfigHelper.GetConnectionString("My_DB_DATOS_01");
        private readonly Hashtable mColComandos = new Hashtable();

        public AccesoDatos() { }

        private SqlCommand Comando(out string Msg_Error, string Proc_Alm)
        {
            Msg_Error = string.Empty;

            if (mColComandos.Contains(Proc_Alm))
            {
                return (SqlCommand)mColComandos[Proc_Alm];
            }

            try
            {
                using var cn = new SqlConnection(xCONEXION);
                cn.Open();

                var mComando = new SqlCommand(Proc_Alm, cn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 3600
                };

                SqlCommandBuilder.DeriveParameters(mComando);

                mColComandos.Add(Proc_Alm, mComando);

                return mComando;
            }
            catch (Exception ex)
            {
                Msg_Error = "Error al definir comando: " + ex.Message;
                return null;
            }
        }

        private void CargarParametros(out string Msg_Error, SqlCommand xComando, params object[] Arg)
        {
            Msg_Error = string.Empty;
            for (int i = 0; i <= Arg.GetUpperBound(0); i++)
            {
                try
                {
                    if (((SqlParameter)xComando.Parameters[i + 1]).Direction == ParameterDirection.Input)
                        xComando.Parameters[i + 1].Value = Arg[i];
                    else
                        ((SqlParameter)xComando.Parameters[i + 1]).Direction = ParameterDirection.Output;
                }
                catch (Exception ex)
                {
                    Msg_Error = "Error en parámetros: " + ex.Message;
                }
            }
        }

        private SqlDataAdapter CrearDataAdapter(out string Msg_Error, string Proc_Alm = "", params object[] Args)
        {
            Msg_Error = string.Empty;

            var mCom = Comando(out Msg_Error, Proc_Alm);
            if (mCom == null || Msg_Error.Length > 0) return null;

            // ⚠️ EL ARREGLO CLAVE:
            mCom.Connection = new Microsoft.Data.SqlClient.SqlConnection(xCONEXION);
            // No hace falta abrirla manualmente: el DataAdapter abre/cierra según necesite.

            if (Args != null && Args.Length > 0)
            {
                CargarParametros(out Msg_Error, mCom, Args);
                if (Msg_Error.Length > 0) return null;
            }

            return new Microsoft.Data.SqlClient.SqlDataAdapter(mCom);
        }

        public DataSet TraerDataSet(out string Msg_Error, string Proc_Alm = "", params object[] Args)
        {
            DataSet ds = new();
            Msg_Error = string.Empty;

            try
            {
                var adapter = CrearDataAdapter(out Msg_Error, Proc_Alm, Args);
                adapter?.Fill(ds);
            }
            catch (Exception ex)
            {
                Msg_Error = "Error al llenar DataSet: " + ex.Message;
            }

            return ds;
        }

        public string Ejecutar(out string Msg_Error, string Proc_Alm = "", string xCAMPO = "", params object[] Args)
        {
            Msg_Error = string.Empty;
            string sResp = string.Empty;

            var mCom = Comando(out Msg_Error, Proc_Alm);
            if (mCom == null || Msg_Error.Length > 0) return sResp;

            // ⚠️ EL ARREGLO CLAVE TAMBIÉN AQUÍ:
            using var cn = new Microsoft.Data.SqlClient.SqlConnection(xCONEXION);
            cn.Open();
            mCom.Connection = cn;

            try
            {
                if (Args != null && Args.Length > 0)
                {
                    mCom.CommandType = CommandType.StoredProcedure;
                    mCom.CommandTimeout = 3600;
                    CargarParametros(out Msg_Error, mCom, Args);
                    if (Msg_Error.Length > 0) return sResp;
                }
                else
                {
                    mCom.CommandType = CommandType.Text;
                    mCom.CommandTimeout = 3600;
                    return mCom.ExecuteScalar()?.ToString() ?? string.Empty;
                }

                mCom.ExecuteNonQuery();

                if (!string.IsNullOrEmpty(xCAMPO))
                    sResp = mCom.Parameters[xCAMPO].Value?.ToString()?.Trim() ?? string.Empty;

                if (mCom.Parameters.Contains("@xMSG") &&
                    mCom.Parameters["@xMSG"].Value?.ToString()?.Trim().Length > 0)
                {
                    Msg_Error = mCom.Parameters["@xMSG"].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                Msg_Error = "Error en ejecución: " + ex.Message;
            }

            return sResp;
        }
    }
}
