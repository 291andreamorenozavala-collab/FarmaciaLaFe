using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Logica;

namespace Capa_Diseño
{
    static class Program
    {
        // Variables Globales
        public static string xNomb_Opcion = string.Empty;
        public static string Nombre_Quien = string.Empty;
        public static string Login_Quien = string.Empty;
        public static double Id_User = 0;
        public static string Rol_Quien = string.Empty;
        public static int xRol_Quien = 0;
        public static string xIP_MAQ = string.Empty;
        public static string Str_Resp_Msg = string.Empty;
        public static bool Bool_Entrar = true;
        public static bool Si_Agrego = false;
        public static string Dtp_Fecha = string.Empty;
        public static int Val_Ban = 0, Val_Ban_1 = 0;
        public static bool Bool_SELECCION = false;
        public static int xResultado = 0;
        public static int xReporte = 0;
        public static double xParram_Rpt = 0;
        public static string SISTEMA = "FARMACIA LA FE - SISTEMA DE FACTURACIÓN", xError = "Ocurrió un Error: ", xMsg = string.Empty;
        public static int xParram = 0, xVerif_Sesion = 0;
        public static int xAcceso = 0;
        public static DialogResult xMensaje = 0;
        public static int xEntra_Aplica = 0, nPosFila = 0;
        public static string xJSON = string.Empty;
        public static int xID_EMPRESA = 0;
        public static int xID_ODBC = 0;
        public static string xNOMB_EMPRESA = string.Empty;
        public static string xNOMB_ODBC = string.Empty;
        public static int Dbl_Cod_Periodo = 0, Dbl_xCod_Periodo = 0, Mes_Per = 0, Anyo_Per = 0, Estado_Per = 0;
        public static string Str_Observacion_Per = string.Empty, xFEC_INI_PER = string.Empty, xFEC_FIN_PER = string.Empty;
        public static int Dbl_Cod_Vacaciones = 0, Dbl_xCod_Vacaciones = 0, Int_Mes_Vac = 0, Dbl_Anyo_Vac = 0, Estado_Vac = 0;
        public static string Str_Observacion_Vac = string.Empty;
        public static double SAL_MIN = 0, LIMITE_INSS = 0, PER_MES = 0, PER_ANYO = 0, DIAS_MES = 0, xID_ENTRADA = 0, xID_FACTURA = 0;

        // DLL DE CAPA LOGICA...
        public static Capa_Logica.Metodos_SOA xMETODOS = new Capa_Logica.Metodos_SOA();


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                xVerif_Sesion = 0;

                Frm_Inicio frmSpl = new Frm_Inicio();
                frmSpl.StartPosition = FormStartPosition.CenterScreen;
                frmSpl.ShowDialog();

                Frm_Password xLogin = new Frm_Password();
                xLogin.ShowDialog();

                if (xLogin.DialogResult == DialogResult.OK)
                    Application.Run(new Frm_Principal());
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show(xError + ex.Message, SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodos de Invocacion
        public static List<Capa_Entidad.TBL_AUTENTICACION> Autenticar_Usuario(string xUID, string xPWD)
        {            
            xMsg = string.Empty; List<Capa_Entidad.TBL_AUTENTICACION> oLista = new List<Capa_Entidad.TBL_AUTENTICACION>();
            try
            {
                oLista = xMETODOS.Autenticar_Usuarios_Json(out xMsg, xUID, xPWD);

                if (xMsg.Length > 0)
                { MessageBox.Show(xMsg, SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(xError + ex.Message.ToString(), SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return oLista;
        }

        // Obteniendo un DATASET a partir de una Lista Generica
        public static DataSet ToDataSet<T>(this List<T> oLista_Gen)
        {
            Type elementType = typeof(T); DataSet ds = new DataSet(); DataTable t = new DataTable(); ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;
                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            foreach (T item in oLista_Gen)
            {
                DataRow row = t.NewRow();
                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }
                t.Rows.Add(row);
            }
            return ds;
        }

        public static bool SoloDigitos(System.Windows.Forms.KeyPressEventArgs e, Object control)
        {
            bool lRetorno = false;
            if (e.KeyChar == (char)Keys.Enter) { SendKeys.Send("{TAB}"); }
            else if (e.KeyChar != (char)Keys.Back)
            {
                if ((Convert.ToChar(e.KeyChar) == ':') || (Convert.ToChar(e.KeyChar) == ';'))
                { lRetorno = true; }
                else if (char.IsControl(e.KeyChar) == true)
                { lRetorno = true; }
                else if (char.IsSymbol(e.KeyChar) == true)
                { lRetorno = true; }
                else if (char.IsWhiteSpace(e.KeyChar) == true)
                { lRetorno = true; }
                else if (char.IsSeparator(e.KeyChar) == true)
                { lRetorno = true; }
                else if (char.IsLetter(e.KeyChar) == true)
                { lRetorno = true; }
                else if ((e.KeyChar == '.') && (((TextBox)(control)).Text.IndexOf('.') > 0))
                { lRetorno = true; }
                else { lRetorno = false; }
            }
            return lRetorno;
        }

    }
}
