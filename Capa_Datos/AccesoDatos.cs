using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class AccesoDatos
    {
        // Campos de la Clase Extrae la Cadena de Conexion desde la Capa Diseño
//
        private static string xCONEXION = ConfigHelper.GetConnectionString("My_DB_DATOS_01");

        // Los Contenedores para recepcionar los Procedimientos con sus parametros
        private SqlConnection cn = new SqlConnection();
        private System.Collections.Hashtable mColComandos = new System.Collections.Hashtable();

        // Constructor con Parametro
        public AccesoDatos() { cn = new SqlConnection(xCONEXION); }

        // Definiendo el Comando en Ejecutar
        private SqlCommand Comando(out string Msg_Error, string Proc_Alm)
        {
            // Declarando la variable de tipo Command
            SqlCommand mComando = new SqlCommand();

            if (mColComandos.Contains(Proc_Alm) == true)
            {
                mComando = (SqlCommand)mColComandos[Proc_Alm];
                Msg_Error = string.Empty; return mComando;
            }
            else
            {
                Msg_Error = string.Empty;
                try
                {
                    if (cn.State == ConnectionState.Open)
                    { cn.Close(); }

                    cn.Open();
                }
                catch (Exception ex)
                {
                    Msg_Error = "Error de Conexión: " + ex.Message.ToString(); return null;
                }

                Msg_Error = string.Empty;
                try
                {
                    mComando = new SqlCommand(Proc_Alm, cn);
                    mComando.CommandType = CommandType.StoredProcedure;
                    mComando.CommandTimeout = 3600; // Tiempo de Ejecucion dado en segundo
                    SqlCommandBuilder.DeriveParameters(mComando);

                    cn.Close();

                    mColComandos.Add(Proc_Alm, mComando);

                    Msg_Error = string.Empty; return mComando;
                }
                catch (Exception ex)
                {
                    Msg_Error = "Error de Definición del Comando: " + ex.Message.ToString();
                    return null;
                }
            }
        }

        // Definiendo la Carga de Parámetros
        private void CargarParametros(out string Msg_Error, SqlCommand xComando, params object[] Arg)
        {
            Msg_Error = string.Empty;
            for (int I = 0; I <= Arg.GetUpperBound(0); I++)
            {
                try
                {
                    if (((SqlParameter)xComando.Parameters[I + 1]).Direction == ParameterDirection.Input)
                    {
                        xComando.Parameters[I + 1].Value = Arg[I];
                    }
                    else
                    {
                        ((SqlParameter)xComando.Parameters[I + 1]).Direction = ParameterDirection.Output;
                    }
                }
                catch (Exception ex)
                {
                    Msg_Error = "Error en los Argumentos del Comando: " + ex.Message.ToString();
                }
            }
        }

        // Definiendo el DataAdapter Con o Sin Parametro
        private SqlDataAdapter CrearDataAdapter(out string Msg_Error, string Proc_Alm = "", params object[] Args)
        {
            try
            {
                // Declarando la variable de tipo Command
                Msg_Error = string.Empty;

                SqlCommand mCom = Comando(out Msg_Error, Proc_Alm);
                if (Msg_Error.Length == 0)
                {
                    if (Args != null)
                    {
                        CargarParametros(out Msg_Error, mCom, Args);
                        if (Msg_Error.Length > 0)
                        {
                            return null;
                        }
                    }
                    // Recupera la Variable de Salida en caso de Error desde la Base de Datos
                    return new SqlDataAdapter(mCom);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Msg_Error = "Error en Crear un Comando y/o Cargar Parámetros: " + ex.Message.ToString();
                return null;
            }
        }

        // Definiendo el TraerDataSet Con o Sin Parámetros
        public DataSet TraerDataSet(out string Msg_Error, string Proc_Alm = "", params object[] Args)
        {
            // Declarando la Instancia del DataSet            
            DataSet MiDataSet = new DataSet();

            try
            {
                Msg_Error = string.Empty;
                if (Args != null)
                {
                    CrearDataAdapter(out Msg_Error, Proc_Alm, Args).Fill(MiDataSet);
                    if (Msg_Error.Length > 0)
                    {
                        return null;
                    }

                }
                else
                {
                    CrearDataAdapter(out Msg_Error, Proc_Alm).Fill(MiDataSet);
                    if (Msg_Error.Length > 0)
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Msg_Error = "Error en el Llenado del DataSet: " + ex.Message.ToString();
            }
            return MiDataSet;
        }

        // Definiendo la Orden de Ejecutar con o Sin Parámetro y del Valor del xMsg de la Base de Datos
        public string Ejecutar(out string Msg_Error, string Proc_Alm = "", string xCAMPO = "", params object[] Args)
        {
            string sResp = string.Empty; // Cuando ocurre un Error

            // Declarando la variable de tipo Command
            Msg_Error = string.Empty;

            SqlCommand mCom = Comando(out Msg_Error, Proc_Alm);
            if (Msg_Error.Length > 0)
            {
                return sResp;
            }

            // Probando la Conexion a SQL SERVER
            try
            {
                if (cn.State == ConnectionState.Open)
                { cn.Close(); }

                cn.Open(); // Conectando ....
            }
            catch (Exception ex)
            {
                Msg_Error = "Error de Conexión: " + ex.Message.ToString();
                return sResp;
            }

            // Si la Conexion fue correcta
            Msg_Error = string.Empty;

            try
            {
                mCom.Connection = cn; // Estableciendo la Conexion...

                // En caso de tener Argumentos...
                if (Args != null)
                {
                    mCom.CommandType = CommandType.StoredProcedure;
                    mCom.CommandTimeout = 3600;
                    CargarParametros(out Msg_Error, mCom, Args);
                    if (Msg_Error.Length > 0)
                    {
                        return sResp;
                    }
                }
                else
                { // No Tiene Argumentos y Devuelve un Valor Escalar...
                    mCom.CommandType = CommandType.Text;
                    mCom.CommandTimeout = 3600;
                    sResp = mCom.ExecuteScalar().ToString();
                    cn.Close(); return sResp;
                }
            }
            catch (Exception ex)
            {
                Msg_Error = "Error en Ejecutar la Función: " + ex.Message.ToString();
                cn.Close();
                return sResp;
            }

            // Si la Conexion está abierta y se Obtuvieron sus Parámetros...
            Msg_Error = string.Empty;

            try
            {
                // Se ejecuta el Procedimiento
                mCom.ExecuteNonQuery();

                // Se Obtiene el Resultado
                if (xCAMPO.Length == 0)
                {
                    sResp = string.Empty;
                }
                else
                {
                    sResp = mCom.Parameters[xCAMPO].Value.ToString().Trim();
                }
                if (mCom.Parameters["@xMSG"].Value.ToString().Trim().Length > 0)
                {
                    Msg_Error = mCom.Parameters["@xMSG"].Value.ToString().Trim();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Msg_Error = "Error en Ejecutar el Procedimiento: " + ex.Message.ToString();
                cn.Close();
            }

            return sResp;
        }

    }
}
