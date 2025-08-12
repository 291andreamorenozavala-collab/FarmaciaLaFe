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

namespace Capa_Diseño
{
    public partial class Frm_Productos : Form
    {
        private static List<TBL_PRODUCTOS> Mi_REG = new List<TBL_PRODUCTOS>();

        public Frm_Productos()
        {
            InitializeComponent();
        }

        // Llenar Listado
        private void Llenar_Lista(ref ListView xContenedor, List<TBL_PRODUCTOS> nDatos)
        {
            // Limpiando el Listview
            xContenedor.Clear();
            xContenedor.Refresh();

            // Las Columnas del ListView
            xContenedor.Columns.Add("CODIGO", 100);
            xContenedor.Columns.Add("DESCRIPCION", 400, HorizontalAlignment.Left);
            xContenedor.Columns.Add("ACTIVO", 80, HorizontalAlignment.Center);
            xContenedor.Columns.Add("USUARIO", 100, HorizontalAlignment.Left);
            xContenedor.Columns.Add("FECHA", 100, HorizontalAlignment.Center);

            if (nDatos != null)
            {
                // Llenando el Listview
                foreach (TBL_PRODUCTOS xREG in nDatos)
                {
                    ListViewItem xFila = new ListViewItem(xREG.ID, 0);
                    xFila.SubItems.Add(xREG.DESCRIPCION);
                    xFila.SubItems.Add(xREG.ESTADO);
                    xFila.SubItems.Add(xREG.USER);
                    xFila.SubItems.Add(xREG.EDIT);

                    xContenedor.Items.Add(xFila);
                }

                // Seleccionando el Primer Registro
                if (xContenedor.Items.Count > 0)
                {
                    xContenedor.Select();
                    xContenedor.Items[0].Selected = true;
                }
            }
        }


        private void Frm_Productos_Load(object sender, EventArgs e)
        {            
            // Cuando se Carga el Formulario
            try
            {
                if (Program.Val_Ban == 0)
                {
                    this.Location = new Point(321, 25);
                }
                else
                {
                    this.Location = new Point(200, 150);
                }

                // Para el Menu
                Program.xAcceso = 1; Program.Bool_Entrar = true;

                this.Txt_Codigo.ReadOnly = true;
                this.Txt_Descripcion.ReadOnly = true;
                this.Chk_Estado.Enabled = false;

                //Recuperando Registros
                Program.xMsg = string.Empty;
                Mi_REG = Program.xMETODOS.Listar_Productos(out Program.xMsg, string.Empty);
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false;
                    return;
                }

                Llenar_Lista(ref this.Lv_Datos, Mi_REG);

                if (this.Lv_Datos.Items.Count > 0)
                {
                    this.Lbl_Contador.Text = "Total Reg.: " + Mi_REG.Count;
                    this.Txt_Filtro.ReadOnly = false; this.Txt_Filtro.Text = string.Empty;
                    this.Lv_Datos.Enabled = true; this.Lv_Datos.Select();
                    this.Lv_Datos.Items[0].Selected = true;

                    // Botones
                    this.Cmd_Nuevo.Enabled = true;
                    this.Cmd_Guardar.Enabled = false;
                    this.Cmd_Cancelar.Enabled = false;
                    this.Cmd_Editar.Enabled = true;

                }
                else
                {
                    // Datos de los Empleados
                    this.Txt_Codigo.Text = string.Empty;
                    this.Txt_Descripcion.Text = string.Empty;
                    this.Chk_Estado.Checked = false;

                    this.Lbl_Contador.Text = "Total Reg.: 0";

                    this.Txt_Filtro.ReadOnly = true; this.Txt_Filtro.Text = string.Empty;
                    this.Lv_Datos.Enabled = false;

                    this.Cmd_Nuevo.Enabled = true; this.Cmd_Nuevo.Select();
                    this.Cmd_Guardar.Enabled = false;
                    this.Cmd_Cancelar.Enabled = false;
                    this.Cmd_Editar.Enabled = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Program.xError + ex.Message.ToString(), Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Bool_Entrar = false; Program.xAcceso = 0;
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            //Cerrando el Formulario de Productos
            Program.xMensaje = MessageBox.Show("¿DESEA CERRAR EL FORMULARIO?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.Yes)
                this.Close();
        }

        private bool Validaciones()
        {
            // Declaración de Variables
            bool yResult = true; this.ep_Error.Clear();

            // 1.- Campo de la Descripción
            if (string.IsNullOrEmpty(this.Txt_Descripcion.Text.Trim()) == true)
            {
                this.ep_Error.SetError(this.Txt_Descripcion, "Debe de Digitar el Nombre del Medicamento...");
                yResult = false;
            }

            return yResult;
        }

        private void Frm_Productos_VisibleChanged(object sender, EventArgs e)
        {
            if (Program.Bool_Entrar == false)
            { Program.xAcceso = 0; this.Close(); }
        }

        private void Frm_Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.Val_Ban != 2)
            { Program.xAcceso = 0; }
        }

        private void Cmd_Nuevo_Click(object sender, EventArgs e)
        {
            //Verifica si proviene de la ventana de Entradas y Salidas
            if (Program.Val_Ban == 1)
            {
                MessageBox.Show("No Puede Realizar está Acción en su modalidad de Búsqueda...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.Val_Ban = 0;


            //Desbloqueando Campos
            this.Txt_Descripcion.ReadOnly = false;

            this.Txt_Codigo.Text = string.Empty;
            this.Txt_Descripcion.Text = string.Empty;
            this.Chk_Estado.Checked = true;

            this.Txt_Descripcion.Select();

            this.Lv_Datos.Enabled = false;
            this.Txt_Filtro.ReadOnly = true;
            this.Txt_Filtro.Text = string.Empty;

            Program.Si_Agrego = true;

            // Botones
            this.Cmd_Nuevo.Enabled = false;
            this.Cmd_Guardar.Enabled = true;
            this.Cmd_Cancelar.Enabled = true;
            this.Cmd_Editar.Enabled = false;
        }

        private void Cmd_Editar_Click(object sender, EventArgs e)
        {
            //Verifica si proviene de la ventana de Entradas y Salidas
            if (Program.Val_Ban == 1)
            {
                MessageBox.Show("No Puede Realizar está Acción en su modalidad de Búsqueda...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.Val_Ban = 0;


            //Desbloqueando Campos
            this.Txt_Descripcion.ReadOnly = false;
            this.Chk_Estado.Enabled = true;

            this.Txt_Descripcion.Select();

            this.Lv_Datos.Enabled = false;
            this.Txt_Filtro.ReadOnly = true;
            this.Txt_Filtro.Text = string.Empty;

            Program.Si_Agrego = false;

            // Botones
            this.Cmd_Nuevo.Enabled = false;
            this.Cmd_Guardar.Enabled = true;
            this.Cmd_Cancelar.Enabled = true;
            this.Cmd_Editar.Enabled = false;
        }

        private void Cmd_Cancelar_Click(object sender, EventArgs e)
        {
            // Cancelando la Transaccion y ubicándose en la ventana que le corresponde
            MessageBox.Show("Transacción Cancelada con Exito", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frm_Productos_Load(sender, e);
        }

        private void Cmd_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Guardando y/o Actualizando Registros
                Program.xMensaje = MessageBox.Show("Desea realizar está Acción?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Program.xMensaje == DialogResult.No)
                { return; }

                // Validando Campos
                if (!Validaciones())
                    return;

                // Asignando Datos a la Clase
                List<cPRODUCTOS> Mis_Datos = new List<cPRODUCTOS>();
                cPRODUCTOS xDatos = new cPRODUCTOS();
                xDatos.ID = (this.Txt_Codigo.Text.Trim().Length == 0) ? "0" : double.Parse(this.Txt_Codigo.Text).ToString().Trim();
                xDatos.DESCRIPCION = this.Txt_Descripcion.Text.Trim();
                xDatos.ESTADO = (this.Chk_Estado.Checked == true) ? "1" : "0";
                xDatos.USER = Program.Id_User.ToString().Trim();
                Mis_Datos.Add(xDatos);

                // Convirtiendo a DataTable...
                DataTable Dt_DATOS = Program.ToDataSet(Mis_Datos).Tables[0];
                if (Dt_DATOS.Rows.Count == 0)
                {
                    MessageBox.Show("Error en la Conversion a la Estructura de Datos en Enviar...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }

                Program.xMsg = string.Empty;
                Program.xMsg = Program.xMETODOS.Insertar_Actualizar_Productos(Dt_DATOS);
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }

                if (Program.Si_Agrego == true)
                {
                    MessageBox.Show("Registro Agregado Satisfactoriamente... ", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Program.Si_Agrego == false)
                {
                    MessageBox.Show("Registro Modificado Satisfactoriamente...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Frm_Productos_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un Error: " + ex.Message.ToString(), Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.xAcceso = 0;
            }
        }

        private void Txt_Filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Buscando un Registro
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (this.Txt_Filtro.ReadOnly == true)
                    {
                        e.Handled = true; return;
                    }

                    Program.xMsg = string.Empty;
                    Mi_REG = Program.xMETODOS.Listar_Productos(out Program.xMsg, this.Txt_Filtro.Text);
                    if (Program.xMsg.Length > 0)
                    {
                        MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Llenar_Lista(ref this.Lv_Datos, Mi_REG);

                    if (this.Lv_Datos.Items.Count > 0)
                    {
                        this.Lbl_Contador.Text = "Total Reg.: " + Mi_REG.Count;
                        this.Lv_Datos.Select(); this.Lv_Datos.Items[0].Selected = true;
                    }
                    else
                    {
                        this.Txt_Codigo.Text = string.Empty;
                        this.Txt_Descripcion.Text = string.Empty;
                        this.Chk_Estado.Checked = false;

                        this.Lbl_Contador.Text = "Total Reg.: 0";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Program.xError + ex.Message.ToString(), Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Txt_Filtro.Text = string.Empty;
                this.Txt_Filtro.Select(); Program.xAcceso = 0;
            }
        }

        private void Txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida los caracteres de entradas
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.Txt_Descripcion.ReadOnly == true)
                {
                    e.Handled = true;
                    return;
                }
                this.Cmd_Guardar.Select();
            }
            else { e.Handled = false; this.ep_Error.Clear(); }
        }

        private void Lv_Datos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.Lv_Datos.Items.Count > 0)
            {
                if (e.IsSelected == true)
                {
                    // Enviando datos
                    this.Txt_Codigo.Text = this.Lv_Datos.SelectedItems[0].SubItems[0].Text;
                    this.Txt_Descripcion.Text = this.Lv_Datos.SelectedItems[0].SubItems[1].Text;
                    this.Chk_Estado.Checked = (this.Lv_Datos.SelectedItems[0].SubItems[2].Text == "SI") ? true : false;

                    // Para Devolverselo 
                    if (Program.Val_Ban == 1)
                    {
                        Frm_Entrada.xID_PRODUCTOS = double.Parse(this.Txt_Codigo.Text).ToString();
                        Frm_Entrada.xCOD_PRODUCTOS = this.Txt_Codigo.Text;
                        Frm_Entrada.xDESC_PRODUCTOS = this.Txt_Descripcion.Text;

                        Frm_Factura.xID_PRODUCTOS = double.Parse(this.Txt_Codigo.Text).ToString();
                        Frm_Factura.xCOD_PRODUCTOS = this.Txt_Codigo.Text;
                        Frm_Factura.xDESC_PRODUCTOS = this.Txt_Descripcion.Text;

                    }
                }
            }
        }

        private void Lv_Datos_DoubleClick(object sender, EventArgs e)
        {
            // Para cerrar la ventana...
            if (this.Lv_Datos.Items.Count > 0)
            {
                if (Program.Val_Ban == 1)
                {
                    // Devuelvo los Valores Seleccionados y despues se Cierra la Ventana...
                    this.Close();
                }
            }
        }
    }
}
