using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Logica;


namespace Capa_Diseño
{
    public partial class Frm_Visualizador : Form
    {
        public static string xTITULO_01 = "FARMACIA LA FE";

        public Frm_Visualizador()
        {
            InitializeComponent();
        }

        private void Frm_Visualizador_Load(object sender, EventArgs e)
        {
            // Visualizando el Reporte Correspondiente
            // Cuando se Carga el Formulario
            try
            {
                // Para el Menu
                Program.xAcceso = 1; Program.Bool_Entrar = true;

                switch (Program.xReporte)
                {
                    case 1: // UNIDAD DE MEDIDA
                        Listado_Unidad_Medida();
                        break;
                    case 2: // CLIENTES
                        Listado_Clientes();
                        break;
                    case 3: // PROVEEDORES
                        Listado_Proveedores();
                        break;
                    case 4: // PRODUCTOS
                        Listado_Productos();
                        break;
                    case 5: // USUARIOS
                        Listado_Usuarios();
                        break;
                    case 6: // ENTRADAS DE PRODUCTOS
                        Entradas_Productos();
                        break;
                    case 7: // FACTURAR PRODUCTOS
                        Facturar_Productos();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Program.xError + ex.Message.ToString(), Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Bool_Entrar = false; Program.xAcceso = 0;
            }
        }

        // Metodos de Llenado de los Reportes
        private void Listado_Unidad_Medida()
        {
            // Se define la Fuente de Datos
            DataSet yDatos = new DataSet(); DataTable xDatos = new DataTable();

            // Se define la Estructura de la tabla 
            xDatos.Columns.Add("xID", typeof(string));
            xDatos.Columns.Add("xDESC", typeof(string));
            xDatos.Columns.Add("xEST", typeof(string));
            xDatos.Columns.Add("xUSER", typeof(string));
            xDatos.Columns.Add("xEDIT", typeof(string));


            List<TBL_UNIDAD_MEDIDA> Mi_REG = new List<TBL_UNIDAD_MEDIDA>();

            // Se recuperan los Datos de la Fuente
            Program.xMsg = string.Empty;
            try
            {
                Mi_REG = Program.xMETODOS.Listar_Unidad_Medida(out Program.xMsg, string.Empty);
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }         
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llamada del Servicio - " + ex.Message; return;
            }

            try
            {
                if (Mi_REG != null)
                {
                    foreach (TBL_UNIDAD_MEDIDA xREG in Mi_REG)
                    {
                        xDatos.Rows.Add(xREG.ID, xREG.DESCRIPCION, xREG.ESTADO, xREG.USER, xREG.EDIT);
                    }
                }
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llenado a la Estructura del Reporte - " + ex.Message; return;
            }

            try
            {
                // Se define el Reporte
                yDatos.Tables.Add(xDatos);
                yDatos.Tables[0].TableName = "TBL_UNIDAD_MEDIDA";

                //rpt_UNIDAD_MEDIDAS xRpt_01 = new rpt_UNIDAD_MEDIDAS();
                //xRpt_01.SetDataSource(yDatos);
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_01"].Text = "'" + xTITULO_01 + "'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_02"].Text = "'AREA DE VENTAS'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_03"].Text = "'LISTADO DE UNIDAD DE MEDIDAS'";
                //xRpt_01.DataDefinition.FormulaFields["xUSER"].Text = "'" + Program.Login_Quien + "'";
                //this.rpt_Informes.ReportSource = xRpt_01;
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Invocación del Reporte - " + ex.Message; return;
            }
        }

        private void Listado_Clientes()
        {
            // Se define la Fuente de Datos
            DataSet yDatos = new DataSet(); DataTable xDatos = new DataTable();

            // Se define la Estructura de la tabla 
            xDatos.Columns.Add("xID", typeof(string));
            xDatos.Columns.Add("xDESC", typeof(string));
            xDatos.Columns.Add("xNEGOCIO", typeof(string));
            xDatos.Columns.Add("xTEL", typeof(string));
            xDatos.Columns.Add("xTIPO", typeof(string));
            xDatos.Columns.Add("xEST", typeof(string));
            xDatos.Columns.Add("xUSER", typeof(string));
            xDatos.Columns.Add("xEDIT", typeof(string));


            List<TBL_CLIENTES> Mi_REG = new List<TBL_CLIENTES>();

            // Se recuperan los Datos de la Fuente
            Program.xMsg = string.Empty;
            try
            {
                Mi_REG = Program.xMETODOS.Listar_Clientes(out Program.xMsg, string.Empty);
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llamada del Servicio - " + ex.Message; return;
            }

            try
            {
                if (Mi_REG != null)
                {
                    foreach (TBL_CLIENTES xREG in Mi_REG)
                    {
                        xDatos.Rows.Add(xREG.ID, xREG.DESCRIPCION, xREG.NEGOCIO, xREG.TELEFONOS, xREG.TIPO, xREG.ESTADO, xREG.USER, xREG.EDIT);
                    }
                }
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llenado a la Estructura del Reporte - " + ex.Message; return;
            }

            try
            {
                // Se define el Reporte
                //yDatos.Tables.Add(xDatos);
                //yDatos.Tables[0].TableName = "TBL_CLIENTES";

                //rpt_CLIENTES xRpt_01 = new rpt_CLIENTES();
                //xRpt_01.SetDataSource(yDatos);
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_01"].Text = "'" + xTITULO_01 + "'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_02"].Text = "'AREA DE VENTAS'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_03"].Text = "'LISTADO DE CLIENTES'";
                //xRpt_01.DataDefinition.FormulaFields["xUSER"].Text = "'" + Program.Login_Quien + "'";
                //this.rpt_Informes.ReportSource = xRpt_01;
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Invocación del Reporte - " + ex.Message; return;
            }
        }

        private void Listado_Proveedores()
        {
            // Se define la Fuente de Datos
            DataSet yDatos = new DataSet(); DataTable xDatos = new DataTable();

            // Se define la Estructura de la tabla 
            xDatos.Columns.Add("xID", typeof(string));
            xDatos.Columns.Add("xDESC", typeof(string));
            xDatos.Columns.Add("xTEL", typeof(string));
            xDatos.Columns.Add("xEST", typeof(string));
            xDatos.Columns.Add("xUSER", typeof(string));
            xDatos.Columns.Add("xEDIT", typeof(string));


            List<TBL_PROVEEDORES> Mi_REG = new List<TBL_PROVEEDORES>();

            // Se recuperan los Datos de la Fuente
            Program.xMsg = string.Empty;
            try
            {
                Mi_REG = Program.xMETODOS.Listar_Proveedores(out Program.xMsg, string.Empty);
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llamada del Servicio - " + ex.Message; return;
            }

            try
            {
                if (Mi_REG != null)
                {
                    foreach (TBL_PROVEEDORES xREG in Mi_REG)
                    {
                        xDatos.Rows.Add(xREG.ID, xREG.DESCRIPCION, xREG.TELEFONOS, xREG.ESTADO, xREG.USER, xREG.EDIT);
                    }
                }
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llenado a la Estructura del Reporte - " + ex.Message; return;
            }

            try
            {
                // Se define el Reporte
                yDatos.Tables.Add(xDatos);
                yDatos.Tables[0].TableName = "TBL_PROVEEDORES";

                //rpt_PROVEEDORES xRpt_01 = new rpt_PROVEEDORES();
                //xRpt_01.SetDataSource(yDatos);
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_01"].Text = "'" + xTITULO_01 + "'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_02"].Text = "'AREA DE VENTAS'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_03"].Text = "'LISTADO DE PROVEEDORES'";
                //xRpt_01.DataDefinition.FormulaFields["xUSER"].Text = "'" + Program.Login_Quien + "'";
                //this.rpt_Informes.ReportSource = xRpt_01;
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Invocación del Reporte - " + ex.Message; return;
            }
        }

        private void Listado_Productos()
        {
            // Se define la Fuente de Datos
            DataSet yDatos = new DataSet(); DataTable xDatos = new DataTable();

            // Se define la Estructura de la tabla 
            xDatos.Columns.Add("xID", typeof(string));
            xDatos.Columns.Add("xDESC", typeof(string));
            xDatos.Columns.Add("xEST", typeof(string));
            xDatos.Columns.Add("xUSER", typeof(string));
            xDatos.Columns.Add("xEDIT", typeof(string));


            List<TBL_PRODUCTOS> Mi_REG = new List<TBL_PRODUCTOS>();

            // Se recuperan los Datos de la Fuente
            Program.xMsg = string.Empty;
            try
            {
                Mi_REG = Program.xMETODOS.Listar_Productos(out Program.xMsg, string.Empty);
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llamada del Servicio - " + ex.Message; return;
            }

            try
            {
                if (Mi_REG != null)
                {
                    foreach (TBL_PRODUCTOS xREG in Mi_REG)
                    {
                        xDatos.Rows.Add(xREG.ID, xREG.DESCRIPCION, xREG.ESTADO, xREG.USER, xREG.EDIT);
                    }
                }
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llenado a la Estructura del Reporte - " + ex.Message; return;
            }

            try
            {
                //// Se define el Reporte
                //yDatos.Tables.Add(xDatos);
                //yDatos.Tables[0].TableName = "TBL_PRODUCTOS";

                //rpt_PRODUCTOS xRpt_01 = new rpt_PRODUCTOS();
                //xRpt_01.SetDataSource(yDatos);
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_01"].Text = "'" + xTITULO_01 + "'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_02"].Text = "'AREA DE VENTAS'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_03"].Text = "'LISTADO DE MEDICAMENTOS'";
                //xRpt_01.DataDefinition.FormulaFields["xUSER"].Text = "'" + Program.Login_Quien + "'";
                //this.rpt_Informes.ReportSource = xRpt_01;
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Invocación del Reporte - " + ex.Message; return;
            }
        }

        private void Listado_Usuarios()
        {
            // Se define la Fuente de Datos
            DataSet yDatos = new DataSet(); DataTable xDatos = new DataTable();

            // Se define la Estructura de la tabla 
            xDatos.Columns.Add("xID", typeof(string));
            xDatos.Columns.Add("xNOMBRE", typeof(string));
            xDatos.Columns.Add("xUID", typeof(string));
            xDatos.Columns.Add("xROL", typeof(string));
            xDatos.Columns.Add("xEST", typeof(string));


            List<TBL_USUARIOS> Mi_REG = new List<TBL_USUARIOS>();

            // Se recuperan los Datos de la Fuente
            Program.xMsg = string.Empty;
            try
            {
                Mi_REG = Program.xMETODOS.Listar_Usuarios(out Program.xMsg, string.Empty);
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llamada del Servicio - " + ex.Message; return;
            }

            try
            {
                if (Mi_REG != null)
                {
                    foreach (TBL_USUARIOS xREG in Mi_REG)
                    {
                        xDatos.Rows.Add(xREG.ID, xREG.NOMBRE, xREG.UID, xREG.DESC_ROL, xREG.ESTADO);
                    }
                }
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llenado a la Estructura del Reporte - " + ex.Message; return;
            }

            try
            {
                //// Se define el Reporte
                //yDatos.Tables.Add(xDatos);
                //yDatos.Tables[0].TableName = "TBL_USUARIOS";

                //rpt_USUARIOS xRpt_01 = new rpt_USUARIOS();
                //xRpt_01.SetDataSource(yDatos);
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_01"].Text = "'" + xTITULO_01 + "'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_02"].Text = "'AREA DE VENTAS'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_03"].Text = "'LISTADO DE USUARIOS'";
                //xRpt_01.DataDefinition.FormulaFields["xUSER"].Text = "'" + Program.Login_Quien + "'";
                //this.rpt_Informes.ReportSource = xRpt_01;
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Invocación del Reporte - " + ex.Message; return;
            }
        }

        private void Entradas_Productos()
        {
            // Se define la Fuente de Datos
            DataSet yDatos = new DataSet(); DataTable xDatos_01 = new DataTable(), xDatos_02 = new DataTable();

            // Se define la Estructura de la tabla 
            xDatos_01.Columns.Add("xID", typeof(string));
            xDatos_01.Columns.Add("xFECHA", typeof(string));
            xDatos_01.Columns.Add("xID_PROVEEDOR", typeof(string));
            xDatos_01.Columns.Add("xDESC_PROVEEDOR", typeof(string));
            xDatos_01.Columns.Add("xTOTAL", typeof(string));
            xDatos_01.Columns.Add("xANUL", typeof(string));

            xDatos_02.Columns.Add("xID", typeof(string));
            xDatos_02.Columns.Add("xID_ENTRADA", typeof(string));
            xDatos_02.Columns.Add("xID_PRODUCTO", typeof(string));
            xDatos_02.Columns.Add("xDESC_PRODUCTO", typeof(string));
            xDatos_02.Columns.Add("xDESC_UM", typeof(string));
            xDatos_02.Columns.Add("xCANT", typeof(string));
            xDatos_02.Columns.Add("xPRECIO", typeof(string));
            xDatos_02.Columns.Add("xTOTAL", typeof(string));

            List<TBL_ENTRADAS_PRODUCTOS> Mi_ENC = new List<TBL_ENTRADAS_PRODUCTOS>();
            List<TBL_DETALLE_ENTRADAS_PRODUCTOS> Mi_DET = new List<TBL_DETALLE_ENTRADAS_PRODUCTOS>();

            // Se recuperan los Datos de la Fuente
            Program.xMsg = string.Empty;
            try
            {
                Mi_ENC = Program.xMETODOS.rpt_Listar_ENC_Entradas_Productos(out Program.xMsg, Program.xID_ENTRADA.ToString().Trim());
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }

                Mi_DET = Program.xMETODOS.rpt_Listar_DET_Entradas_Productos(out Program.xMsg, Program.xID_ENTRADA.ToString().Trim());
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llamada del Servicio - " + ex.Message; return;
            }

            try
            {
                string yID = string.Empty;
                                
                if (Mi_ENC != null)
                {
                    foreach (TBL_ENTRADAS_PRODUCTOS xREG in Mi_ENC)
                    {
                        yID = xREG.ID; xDatos_01.Rows.Add(xREG.ID, xREG.FECHA, xREG.ID_PROVEEDOR, xREG.NOMBRE_PROVEEDOR, xREG.TOTAL, xREG.ANULADO);
                    }
                }

                if (Mi_DET != null)
                {
                    foreach (TBL_DETALLE_ENTRADAS_PRODUCTOS xREG in Mi_DET)
                    {
                        xDatos_02.Rows.Add(xREG.ID, yID, xREG.ID_PRODUCTO, xREG.DESC_PRODUCTO, xREG.DESC_UM, xREG.CANTIDAD, xREG.PRECIO, xREG.TOTAL);
                    }
                }


            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llenado a la Estructura del Reporte - " + ex.Message; return;
            }

            try
            {
                //// Se define el Reporte
                //yDatos.Tables.Add(xDatos_01); yDatos.Tables.Add(xDatos_02);
                //yDatos.Tables[0].TableName = "TBL_ENC_ENTRADAS"; yDatos.Tables[1].TableName = "TBL_DET_ENTRADAS";

                //rpt_ENTRADAS_PRODUCTOS xRpt_01 = new rpt_ENTRADAS_PRODUCTOS();
                //xRpt_01.SetDataSource(yDatos);
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_01"].Text = "'" + xTITULO_01 + "'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_02"].Text = "'AREA DE VENTAS'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_03"].Text = "'ENTRADAS DE PRODUCTOS'";
                //xRpt_01.DataDefinition.FormulaFields["xUSER"].Text = "'" + Program.Login_Quien + "'";
                //this.rpt_Informes.ReportSource = xRpt_01;
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Invocación del Reporte - " + ex.Message; return;
            }
        }

        private void Facturar_Productos()
        {
            // Se define la Fuente de Datos
            DataSet yDatos = new DataSet(); DataTable xDatos_01 = new DataTable(), xDatos_02 = new DataTable();

            // Se define la Estructura de la tabla 
            xDatos_01.Columns.Add("xID", typeof(string));
            xDatos_01.Columns.Add("xFECHA", typeof(string));
            xDatos_01.Columns.Add("xID_CLIENTE", typeof(string));
            xDatos_01.Columns.Add("xDESC_CLIENTE", typeof(string));
            xDatos_01.Columns.Add("xTIPO_CLIENTE", typeof(string));
            xDatos_01.Columns.Add("xSUB_TOTAL_01", typeof(string));
            xDatos_01.Columns.Add("xPORC_DESCUENTO", typeof(string));
            xDatos_01.Columns.Add("xVAL_DESCUENTO", typeof(string));
            xDatos_01.Columns.Add("xSUB_TOTAL_02", typeof(string));
            xDatos_01.Columns.Add("xIVA", typeof(string));
            xDatos_01.Columns.Add("xNETO", typeof(string));
            xDatos_01.Columns.Add("xANUL", typeof(string));

            xDatos_02.Columns.Add("xID", typeof(string));
            xDatos_02.Columns.Add("xID_FACTURA", typeof(string));
            xDatos_02.Columns.Add("xID_PRODUCTO", typeof(string));
            xDatos_02.Columns.Add("xDESC_PRODUCTO", typeof(string));
            xDatos_02.Columns.Add("xDESC_UM", typeof(string));
            xDatos_02.Columns.Add("xCANT", typeof(string));
            xDatos_02.Columns.Add("xPRECIO", typeof(string));
            xDatos_02.Columns.Add("xTOTAL", typeof(string));

            List<TBL_FACTURAR_PRODUCTOS> Mi_ENC = new List<TBL_FACTURAR_PRODUCTOS>();
            List<TBL_DETALLE_FACTURAR_PRODUCTOS> Mi_DET = new List<TBL_DETALLE_FACTURAR_PRODUCTOS>();

            // Se recuperan los Datos de la Fuente
            Program.xMsg = string.Empty;
            try
            {
                Mi_ENC = Program.xMETODOS.rpt_Listar_ENC_Facturar_Productos(out Program.xMsg, Program.xID_FACTURA.ToString().Trim());
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }

                Mi_DET = Program.xMETODOS.rpt_Listar_DET_Facturar_Productos(out Program.xMsg, Program.xID_FACTURA.ToString().Trim());
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llamada del Servicio - " + ex.Message; return;
            }

            try
            {
                string yID = string.Empty;

                if (Mi_ENC != null)
                {
                    foreach (TBL_FACTURAR_PRODUCTOS xREG in Mi_ENC)
                    {
                        yID = xREG.ID; xDatos_01.Rows.Add(xREG.ID, xREG.FECHA, xREG.ID_CLIENTE, xREG.NOMBRE_CLIENTE, xREG.TIPO_CLIENTE, 
                                                          xREG.SUBTOTAL_01, xREG.PORC_DESCUENTO, xREG.VAL_DESCUENTO, xREG.SUBTOTAL_02, 
                                                          xREG.IVA, xREG.NETO, xREG.ANULADO);
                    }
                }

                if (Mi_DET != null)
                {
                    foreach (TBL_DETALLE_FACTURAR_PRODUCTOS xREG in Mi_DET)
                    {
                        xDatos_02.Rows.Add(xREG.ID, yID, xREG.ID_PRODUCTO, xREG.DESC_PRODUCTO, xREG.DESC_UM, xREG.CANTIDAD, xREG.PRECIO, xREG.TOTAL);
                    }
                }


            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Llenado a la Estructura del Reporte - " + ex.Message; return;
            }

            try
            {
                // Se define el Reporte
                //yDatos.Tables.Add(xDatos_01); yDatos.Tables.Add(xDatos_02);
                //yDatos.Tables[0].TableName = "TBL_ENC_FACTURAS"; yDatos.Tables[1].TableName = "TBL_DET_FACTURAS";

                //rpt_FACTURAR_PRODUCTOS xRpt_01 = new rpt_FACTURAR_PRODUCTOS();
                //xRpt_01.SetDataSource(yDatos);
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_01"].Text = "'" + xTITULO_01 + "'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_02"].Text = "'AREA DE VENTAS'";
                //xRpt_01.DataDefinition.FormulaFields["xTitulo_03"].Text = "'FACTURA COMERCIAL DE VENTAS DE PRODUCTOS'";
                //xRpt_01.DataDefinition.FormulaFields["xUSER"].Text = "'" + Program.Login_Quien + "'";
                //this.rpt_Informes.ReportSource = xRpt_01;
            }
            catch (Exception ex)
            {
                Program.xMsg = Program.xError + " Invocación del Reporte - " + ex.Message; return;
            }
        }


        private void Frm_Visualizador_VisibleChanged(object sender, EventArgs e)
        {
            if (Program.Bool_Entrar == false)
            { Program.xAcceso = 0; this.Close(); }
        }

        private void Frm_Visualizador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.Val_Ban != 2)
            { Program.xAcceso = 0; }
        }

    }
}
