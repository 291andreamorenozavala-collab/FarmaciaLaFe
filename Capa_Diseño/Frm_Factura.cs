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
    public partial class Frm_Factura : Form
    {
        // Para la Ventana de CLIENTES
        public static string xID_CLIENTE = string.Empty, xCOD_CLIENTE = string.Empty, xNOMB_CLIENTE = string.Empty, xTIPO_CLIENTE = string.Empty;

        // Para la Ventana de PRODUCTOS
        public static string xID_PRODUCTOS = string.Empty, xCOD_PRODUCTOS = string.Empty, xDESC_PRODUCTOS = string.Empty, xID_UM = string.Empty, xDESC_UM = string.Empty;

        private void Cmd_Anular_Click(object sender, EventArgs e)
        {
            try
            {
                //Guardando y/o Actualizando Registros
                Program.xMensaje = MessageBox.Show("Desea realizar está Acción?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Program.xMensaje == DialogResult.No)
                { return; }

                if (this.Chk_Anulado.Checked == true)
                { MessageBox.Show("Este Registro ya fue ANULADO...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                Program.xMsg = string.Empty;
                Program.xMsg = Program.xMETODOS.Anular_Facturar_Productos(double.Parse(this.Txt_IdFactura.Text).ToString());
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }

                MessageBox.Show("Registro Anulado Satisfactoriamente... ", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Frm_Factura_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un Error: " + ex.Message.ToString(), Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.xAcceso = 0;
            }
        }

        private void Cmd_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                Fr_Busqueda.Visible = true;
                Fr_Busqueda.Top = 24; Fr_Busqueda.Left = 134;

                this.Txt_Filtro.Text = string.Empty; this.Dtp_Desde.Value = DateTime.Now; this.Dtp_Hasta.Value = DateTime.Now;

                Program.xMsg = string.Empty;
                List<TBL_FACTURAR_PRODUCTOS> Mi_REG_ENC = Program.xMETODOS.Listar_ENC_Facturar_Productos(out Program.xMsg, this.Txt_Filtro.Text, string.Format("{0:yyyy-MM-dd}", this.Dtp_Desde.Value), string.Format("{0:yyyy-MM-dd}", this.Dtp_Hasta.Value));
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false;
                    return;
                }

                Llenar_Lista_Encabezado(ref this.Lv_Busqueda, Mi_REG_ENC);

                this.Lbl_Leyenda.Text = "Total Reg.: " + this.Lv_Busqueda.Items.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un Error: " + ex.Message.ToString(), Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.xAcceso = 0;
            }
        }

        private void Btn_Proveedor_Click(object sender, EventArgs e)
        {
            // Abriendo la Ventana de Empleados
            xID_CLIENTE = string.Empty; xCOD_CLIENTE = string.Empty; xNOMB_CLIENTE = string.Empty; xTIPO_CLIENTE = string.Empty;

            Program.Val_Ban = 1;
            Frm_Clientes xForm = new Frm_Clientes();
            xForm.ShowDialog();

            Program.Val_Ban = 0;

            if (xID_CLIENTE.Trim().Length == 0)
            {
                this.Txt_CodCliente.Text = string.Empty;
                this.Txt_Cliente.Text = string.Empty;
                this.Txt_Tipo_Cliente.Text = string.Empty;

                return;
            }

            // Asignando Datos
            this.Txt_CodCliente.Text = xCOD_CLIENTE; this.Txt_Cliente.Text = xNOMB_CLIENTE; this.Txt_Tipo_Cliente.Text = xTIPO_CLIENTE;

        }

        private void Btn_Medicamento_Click(object sender, EventArgs e)
        {
            // Abriendo la Ventana de Empleados
            xID_PRODUCTOS = string.Empty; xCOD_PRODUCTOS = string.Empty; xDESC_PRODUCTOS = string.Empty;

            if (xID_UM.Length == 0) {
                MessageBox.Show("Primero, debe de Seleccionar la Unidad de Medida del Medicamento...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }


            Program.Val_Ban = 1;
            Frm_Productos xForm = new Frm_Productos();
            xForm.ShowDialog();

            Program.Val_Ban = 0;

            if (xID_PRODUCTOS.Trim().Length == 0)
            {
                this.Txt_CodProducto.Text = string.Empty;
                this.Txt_Descripcion.Text = string.Empty;
                this.Txt_Exixtencia.Text = string.Empty;
                this.Txt_PVU.Text = string.Empty;
                this.Txt_Total.Text = string.Empty;

                return;
            }

            if (xID_UM.Trim().Length == 0)
            {
                return;
            }

            // Asignando Datos
            this.Txt_CodProducto.Text = xCOD_PRODUCTOS; this.Txt_Descripcion.Text = xDESC_PRODUCTOS;

            // Metodo que Devuelve las Existencias, Costos y Totales
            Existencias_y_Costos_Productos(xID_PRODUCTOS, xID_UM);

        }

        private void Frm_Factura_VisibleChanged(object sender, EventArgs e)
        {
            if (Program.Bool_Entrar == false)
            { Program.xAcceso = 0; this.Close(); }
        }

        private void Frm_Factura_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.Val_Ban != 2)
            { Program.xAcceso = 0; }
        }

        private void Cmd_Buscar_Click(object sender, EventArgs e)
        {
            // Buscando un Registro
            try
            {
                Program.xMsg = string.Empty;
                List<TBL_FACTURAR_PRODUCTOS> Mi_REG_ENC = Program.xMETODOS.Listar_ENC_Facturar_Productos(out Program.xMsg, this.Txt_Filtro.Text, string.Format("{0:yyyy-MM-dd}", this.Dtp_Desde.Value), string.Format("{0:yyyy-MM-dd}", this.Dtp_Hasta.Value));
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false;
                    return;
                }

                Llenar_Lista_Encabezado(ref this.Lv_Busqueda, Mi_REG_ENC);

                if (this.Lv_Busqueda.Items.Count > 0)
                {
                    this.Lbl_Leyenda.Text = "Total Reg.: " + Mi_REG_ENC.Count;
                    this.Lv_Busqueda.Select(); this.Lv_Busqueda.Items[0].Selected = true;
                }
                else
                {
                    this.Lbl_Leyenda.Text = "Total Reg.: 0";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Program.xError + ex.Message.ToString(), Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Txt_Filtro.Text = string.Empty;
                this.Txt_Filtro.Select(); Program.xAcceso = 0;
            }
        }

        private void Lv_Busqueda_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.Lv_Busqueda.Items.Count > 0)
            {
                if (e.IsSelected == true)
                {
                    // Enviando datos
                    this.Txt_IdFactura.Text = this.Lv_Busqueda.SelectedItems[0].SubItems[1].Text;
                    this.Dtp_Fecha.Value = DateTime.Parse(this.Lv_Busqueda.SelectedItems[0].SubItems[0].Text);
                    xID_CLIENTE = double.Parse(this.Lv_Busqueda.SelectedItems[0].SubItems[2].Text).ToString();
                    this.Txt_CodCliente.Text = this.Lv_Busqueda.SelectedItems[0].SubItems[2].Text;
                    this.Txt_Cliente.Text = this.Lv_Busqueda.SelectedItems[0].SubItems[3].Text;
                    this.Txt_Tipo_Cliente.Text = this.Lv_Busqueda.SelectedItems[0].SubItems[4].Text;
                    this.Txt_SubTotal_01.Text = this.Lv_Busqueda.SelectedItems[0].SubItems[5].Text;
                    this.Txt_Porc_Descuento.Text = this.Lv_Busqueda.SelectedItems[0].SubItems[6].Text;
                    this.Txt_Val_Descuento.Text = this.Lv_Busqueda.SelectedItems[0].SubItems[7].Text;
                    this.Txt_SubTotal_02.Text = this.Lv_Busqueda.SelectedItems[0].SubItems[8].Text;
                    this.Txt_Val_IVA.Text = this.Lv_Busqueda.SelectedItems[0].SubItems[9].Text;
                    this.Txt_Neto.Text = this.Lv_Busqueda.SelectedItems[0].SubItems[10].Text;
                    this.Chk_Anulado.Checked = (this.Lv_Busqueda.SelectedItems[0].SubItems[11].Text == "SI") ? true : false;

                    this.Cmd_Nuevo.Enabled = true;
                    this.Cmd_Guardar.Enabled = false;
                    this.Cmd_Cancelar.Enabled = false;
                    this.Cmd_Anular.Enabled = true;
                    this.Cmd_Imprimir.Enabled = true;
                    this.Cmd_Consultar.Enabled = true;

                    //Recuperando Registros
                    Program.xMsg = string.Empty;
                    Mi_REG_DET = Program.xMETODOS.Listar_DET_Facturar_Productos(out Program.xMsg, double.Parse(this.Txt_IdFactura.Text).ToString());
                    if (Program.xMsg.Length > 0)
                    {
                        MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.Bool_Entrar = false;
                        return;
                    }

                    Llenar_Lista_Detalle(ref this.Lv_Entradas, Mi_REG_DET);
                }
            }
        }

        private void Lv_Busqueda_DoubleClick(object sender, EventArgs e)
        {
            // Para cerrar la ventana...
            if (this.Lv_Busqueda.Items.Count > 0)
            {
                Fr_Busqueda.Visible = false;

                this.Txt_Filtro.Text = string.Empty; this.Dtp_Desde.Value = DateTime.Now; this.Dtp_Hasta.Value = DateTime.Now;
            }
        }

        private void Btn_Unidad_Medida_Click(object sender, EventArgs e)
        {
            // Abriendo la Ventana de Empleados
            xID_UM = string.Empty; xDESC_UM = string.Empty;

            Program.Val_Ban = 1;
            Frm_Unidad_Medida xForm = new Frm_Unidad_Medida();
            xForm.ShowDialog();

            Program.Val_Ban = 0;

            if (xID_UM.Trim().Length == 0)
            {
                this.Txt_Unimed.Text = string.Empty;

                return;
            }

            // Asignando Datos
            this.Txt_Unimed.Text = xDESC_UM;
        }

        private void Cmd_Cerrar_Click(object sender, EventArgs e)
        {
            Fr_Busqueda.Visible = false;

            this.Txt_Filtro.Text = string.Empty; this.Dtp_Desde.Value = DateTime.Now; this.Dtp_Hasta.Value = DateTime.Now;
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
                    List<TBL_FACTURAR_PRODUCTOS> Mi_REG_ENC = Program.xMETODOS.Listar_ENC_Facturar_Productos(out Program.xMsg, this.Txt_Filtro.Text, string.Format("{0:yyyy-MM-dd}", this.Dtp_Desde.Value), string.Format("{0:yyyy-MM-dd}", this.Dtp_Hasta.Value));
                    if (Program.xMsg.Length > 0)
                    {
                        MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.Bool_Entrar = false;
                        return;
                    }

                    Llenar_Lista_Encabezado(ref this.Lv_Busqueda, Mi_REG_ENC);

                    if (this.Lv_Busqueda.Items.Count > 0)
                    {
                        this.Lbl_Leyenda.Text = "Total Reg.: " + Mi_REG_ENC.Count;
                        this.Lv_Busqueda.Select(); this.Lv_Busqueda.Items[0].Selected = true;
                    }
                    else
                    {
                        this.Lbl_Leyenda.Text = "Total Reg.: 0";

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

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida los caracteres de entradas
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.Txt_Cantidad.ReadOnly == true)
                {
                    e.Handled = true;
                    return;
                }
                this.Txt_Precio.Select();
            }
            else { e.Handled = Program.SoloDigitos(e, this.Txt_Cantidad); this.ep_Error.Clear(); }
        }

        private void Txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida los caracteres de entradas
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.Txt_Precio.ReadOnly == true)
                {
                    e.Handled = true;
                    return;
                }
                this.Btn_AgregarDetalle.Select();
            }
            else { e.Handled = Program.SoloDigitos(e, this.Txt_Precio); this.ep_Error.Clear(); }
        }

        private void Btn_AgregarDetalle_Click(object sender, EventArgs e)
        {
            // Validando Campos
            if (!Validar_Detalle())
                return;

            for (int I = 0; I <= (this.Lv_Entradas.Items.Count - 1); I++)
            {
                if ((this.Lv_Entradas.Items[I].SubItems[0].Text == this.Txt_CodProducto.Text) && (this.Lv_Entradas.Items[I].SubItems[3].Text == xID_UM))
                {
                    MessageBox.Show("Este Registro ya Existe en el Detalle...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Txt_CodProducto.Text = string.Empty;
                    this.Txt_Descripcion.Text = string.Empty;
                    this.Txt_Exixtencia.Text = string.Empty;
                    this.Txt_PVU.Text = string.Empty;
                    this.Txt_Total.Text = string.Empty;

                    this.Txt_Unimed.Text = string.Empty;

                    return;
                }
            }

            ListViewItem xFila = new ListViewItem(this.Txt_CodProducto.Text, 0);
            xFila.SubItems.Add("0");
            xFila.SubItems.Add(this.Txt_Descripcion.Text);
            xFila.SubItems.Add(xID_UM);
            xFila.SubItems.Add(this.Txt_Unimed.Text);
            xFila.SubItems.Add(this.Txt_Cantidad.Text);
            xFila.SubItems.Add(this.Txt_Precio.Text);
            xFila.SubItems.Add(string.Format("{0:##0.00}", double.Parse(this.Txt_Cantidad.Text) * double.Parse(this.Txt_Precio.Text)));

            this.Lv_Entradas.Items.Add(xFila);

            MessageBox.Show("Registro Agregado en el Detalle de manera Satisfactoria... ", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            double xSubTotal_01 = 0.00, xPorc_Descuento = 0.00;

            if (this.Txt_Porc_Descuento.Text.Trim().Length > 0) {
                xPorc_Descuento = double.Parse(this.Txt_Porc_Descuento.Text);        
            }

            for (int I = 0; I <= (this.Lv_Entradas.Items.Count - 1); I++)
            {
                xSubTotal_01 = xSubTotal_01 + double.Parse(this.Lv_Entradas.Items[I].SubItems[7].Text);
            }

            this.Txt_SubTotal_01.Text = string.Format("{0:##0.00}", xSubTotal_01);
            this.Txt_Val_Descuento.Text = string.Format("{0:##0.00}", (xSubTotal_01 * (xPorc_Descuento / 100)));
            this.Txt_SubTotal_02.Text = string.Format("{0:##0.00}", (xSubTotal_01 * (1 - (xPorc_Descuento / 100))));
            this.Txt_Val_IVA.Text = string.Format("{0:##0.00}", ((xSubTotal_01 * (1 - (xPorc_Descuento / 100))) * 0.15));
            this.Txt_Neto.Text = string.Format("{0:##0.00}", ((xSubTotal_01 * (1 - (xPorc_Descuento / 100))) * 1.15));

            this.Txt_Unimed.Text = string.Empty;

            this.Txt_CodProducto.Text = string.Empty;
            this.Txt_Descripcion.Text = string.Empty;
            this.Txt_Exixtencia.Text = string.Empty;
            this.Txt_PVU.Text = string.Empty;
            this.Txt_Total.Text = string.Empty;

            this.Txt_Cantidad.Text = string.Empty; this.Txt_Precio.Text = string.Empty; this.Txt_Cantidad.Select();

            xID_PRODUCTOS = string.Empty; xCOD_PRODUCTOS = string.Empty; xDESC_PRODUCTOS = string.Empty;
            xID_UM = string.Empty; xDESC_UM = string.Empty;
        }

        private void Btn_Quitar_Click(object sender, EventArgs e)
        {
            if (this.Lv_Entradas.Items.Count == 0)
            { MessageBox.Show("No hay Registro Almacenado en el Detalle...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (Program.Bool_SELECCION == true)
            { MessageBox.Show("No ha Seleccionado aun un Registro a Quitar del Detalle...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            this.Lv_Entradas.Items.RemoveAt(this.Lv_Entradas.SelectedItems[0].Index);
            Program.Bool_SELECCION = false;

            MessageBox.Show("Registro Quitado del Detalle de manera Satisfactoria... ", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            double xSubTotal_01 = 0.00, xPorc_Descuento = 0.00;

            if (this.Txt_Porc_Descuento.Text.Trim().Length > 0)
            {
                xPorc_Descuento = double.Parse(this.Txt_Porc_Descuento.Text);
            }

            for (int I = 0; I <= (this.Lv_Entradas.Items.Count - 1); I++)
            {
                xSubTotal_01 = xSubTotal_01 + double.Parse(this.Lv_Entradas.Items[I].SubItems[7].Text);
            }

            this.Txt_SubTotal_01.Text = string.Format("{0:##0.00}", xSubTotal_01);
            this.Txt_Val_Descuento.Text = string.Format("{0:##0.00}", (xSubTotal_01 * (xPorc_Descuento / 100)));
            this.Txt_SubTotal_02.Text = string.Format("{0:##0.00}", (xSubTotal_01 * (1 - (xPorc_Descuento / 100))));
            this.Txt_Val_IVA.Text = string.Format("{0:##0.00}", ((xSubTotal_01 * (1 - (xPorc_Descuento / 100))) * 0.15));
            this.Txt_Neto.Text = string.Format("{0:##0.00}", ((xSubTotal_01 * (1 - (xPorc_Descuento / 100))) * 1.15));
        }

        private static List<TBL_DETALLE_FACTURAR_PRODUCTOS> Mi_REG_DET = new List<TBL_DETALLE_FACTURAR_PRODUCTOS>();

        private void Cmd_Cancelar_Click(object sender, EventArgs e)
        {
            // Cancelando la Transaccion y ubicándose en la ventana que le corresponde
            MessageBox.Show("Transacción Cancelada con Exito", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frm_Factura_Load(sender, e);
        }

        private void Cmd_Nuevo_Click(object sender, EventArgs e)
        {
            this.Dtp_Fecha.Enabled = true;
            this.Txt_Porc_Descuento.ReadOnly = false;

            this.Txt_IdFactura.Text = string.Empty;
            this.Dtp_Fecha.Value = DateTime.Now;
            this.Chk_Anulado.Checked = false;
            this.Txt_SubTotal_01.Text = string.Empty;
            this.Txt_Porc_Descuento.Text = string.Empty;
            this.Txt_Val_Descuento.Text = string.Empty;
            this.Txt_SubTotal_02.Text = string.Empty;
            this.Txt_Val_IVA.Text = string.Empty;
            this.Txt_Neto.Text = string.Empty;

            this.Btn_Proveedor.Enabled = true;
            this.Txt_CodCliente.Text = string.Empty;
            this.Txt_Cliente.Text = string.Empty;
            this.Txt_Tipo_Cliente.Text = string.Empty;

            this.Btn_Unidad_Medida.Enabled = true;

            this.Btn_Medicamento.Enabled = true;

            this.Txt_CodProducto.Text = string.Empty;
            this.Txt_Descripcion.Text = string.Empty;
            this.Txt_Exixtencia.Text = string.Empty;
            this.Txt_PVU.Text = string.Empty;
            this.Txt_Total.Text = string.Empty;

            this.Txt_Cantidad.Text = string.Empty;
            this.Txt_Cantidad.ReadOnly = false;
            this.Txt_Precio.Text = string.Empty;
            this.Txt_Precio.ReadOnly = false;

            this.Btn_AgregarDetalle.Enabled = true;
            this.Btn_Quitar.Enabled = true;

            this.Cmd_Nuevo.Enabled = false;
            this.Cmd_Guardar.Enabled = true;
            this.Cmd_Cancelar.Enabled = true;
            this.Cmd_Anular.Enabled = false;
            this.Cmd_Imprimir.Enabled = false;
            this.Cmd_Consultar.Enabled = true;

            //Recuperando Registros
            Program.xMsg = string.Empty; this.Lv_Entradas.Enabled = false; Program.Bool_SELECCION = false;
            Mi_REG_DET = Program.xMETODOS.Listar_DET_Facturar_Productos(out Program.xMsg, "0");
            if (Program.xMsg.Length > 0)
            {
                MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Bool_Entrar = false;
                return;
            }

            Llenar_Lista_Detalle(ref this.Lv_Entradas, Mi_REG_DET);

            this.Lv_Entradas.Enabled = true;

            xID_CLIENTE = string.Empty; xCOD_CLIENTE = string.Empty; xNOMB_CLIENTE = string.Empty; xTIPO_CLIENTE = string.Empty;
            xID_PRODUCTOS = string.Empty; xCOD_PRODUCTOS = string.Empty; xDESC_PRODUCTOS = string.Empty;
            xID_UM = string.Empty; xDESC_UM = string.Empty;
        }

        private void Cmd_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Guardando y/o Actualizando Registros
                Program.xMensaje = MessageBox.Show("Desea realizar está Acción?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Program.xMensaje == DialogResult.No)
                { return; }

                if (xID_CLIENTE.Length == 0)
                {
                    MessageBox.Show("No ha Seleccionado al Proveedor para comprar los Medicamentos...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }

                if (this.Lv_Entradas.Items.Count == 0)
                { MessageBox.Show("No hay Registro Almacenado en el Detalle...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information); return; }



                // Asignando Datos a la Clase
                List<cFACTURAR_PRODUCTOS> Mis_Datos = new List<cFACTURAR_PRODUCTOS>();
                cFACTURAR_PRODUCTOS xDatos = new cFACTURAR_PRODUCTOS();
                xDatos.ID = (this.Txt_IdFactura.Text.Trim().Length == 0) ? "0" : double.Parse(this.Txt_IdFactura.Text).ToString().Trim();
                xDatos.FECHA = string.Format("{0:yyyy-MM-dd}", this.Dtp_Fecha.Value); xDatos.ID_CLIENTE = xID_CLIENTE;
                xDatos.PORC_DESCUENTO = (this.Txt_Porc_Descuento.Text.Trim().Length == 0) ? "0" : double.Parse(this.Txt_Porc_Descuento.Text).ToString().Trim();
                xDatos.USER = Program.Id_User.ToString().Trim();
                Mis_Datos.Add(xDatos);

                // Convirtiendo a DataTable...
                DataTable Dt_ENC = Program.ToDataSet(Mis_Datos).Tables[0];
                if (Dt_ENC.Rows.Count == 0)
                {
                    MessageBox.Show("Error en la Conversion a la Estructura de Datos en Enviar...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }

                List<cDETALLE_FACTURAR_PRODUCTOS> Mis_Datos_DET = new List<cDETALLE_FACTURAR_PRODUCTOS>();
                cDETALLE_FACTURAR_PRODUCTOS xDatos_DET = new cDETALLE_FACTURAR_PRODUCTOS();

                for (int I = 0; I <= (this.Lv_Entradas.Items.Count - 1); I++)
                {
                    xDatos_DET = new cDETALLE_FACTURAR_PRODUCTOS();
                    xDatos_DET.ID = "0"; xDatos_DET.ID_PRODUCTO = this.Lv_Entradas.Items[I].SubItems[0].Text;
                    xDatos_DET.ID_UM = this.Lv_Entradas.Items[I].SubItems[3].Text;
                    xDatos_DET.CANTIDAD = this.Lv_Entradas.Items[I].SubItems[5].Text;
                    xDatos_DET.PRECIO = this.Lv_Entradas.Items[I].SubItems[6].Text;

                    Mis_Datos_DET.Add(xDatos_DET);
                }

                DataTable Dt_DET = Program.ToDataSet(Mis_Datos_DET).Tables[0];
                if (Dt_DET.Rows.Count == 0)
                {
                    MessageBox.Show("Error en la Conversion a la Estructura de Datos en Enviar...", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }

                Program.xMsg = string.Empty;
                Program.xMsg = Program.xMETODOS.Insertar_Facturar_Productos(Dt_ENC, Dt_DET);
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false; return;
                }

                MessageBox.Show("Registro Grabado Satisfactoriamente... ", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Frm_Factura_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un Error: " + ex.Message.ToString(), Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.xAcceso = 0;
            }
        }

        private void Cmd_Imprimir_Click(object sender, EventArgs e)
        {
            // Verificando Si desea Imprimir
            Program.xMensaje = MessageBox.Show("¿Desea Imprimir los Registros?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.No)
            { return; }

            Program.xReporte = 7; Program.xID_FACTURA = double.Parse(this.Txt_IdFactura.Text);

            Frm_Visualizador xForm = new Frm_Visualizador();
            xForm.ShowDialog();
        }

        private void Txt_Porc_Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida los caracteres de entradas
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.Txt_Porc_Descuento.ReadOnly == true)
                {
                    e.Handled = true;
                    return;
                }

                double xSubTotal_01 = 0.00, xPorc_Descuento = 0.00;

                if (this.Txt_Porc_Descuento.Text.Trim().Length > 0)
                {
                    xPorc_Descuento = double.Parse(this.Txt_Porc_Descuento.Text);
                }

                for (int I = 0; I <= (this.Lv_Entradas.Items.Count - 1); I++)
                {
                    xSubTotal_01 = xSubTotal_01 + double.Parse(this.Lv_Entradas.Items[I].SubItems[7].Text);
                }

                this.Txt_SubTotal_01.Text = string.Format("{0:##0.00}", xSubTotal_01);
                this.Txt_Val_Descuento.Text = string.Format("{0:##0.00}", (xSubTotal_01 * (xPorc_Descuento / 100)));
                this.Txt_SubTotal_02.Text = string.Format("{0:##0.00}", (xSubTotal_01 * (1 - (xPorc_Descuento / 100))));
                this.Txt_Val_IVA.Text = string.Format("{0:##0.00}", ((xSubTotal_01 * (1 - (xPorc_Descuento / 100))) * 0.15));
                this.Txt_Neto.Text = string.Format("{0:##0.00}", ((xSubTotal_01 * (1 - (xPorc_Descuento / 100))) * 1.15));

                this.Cmd_Guardar.Select();
            }
            else { e.Handled = Program.SoloDigitos(e, this.Txt_Precio); this.ep_Error.Clear(); }
        }

        // Llenar Listado
        private void Llenar_Lista_Detalle(ref ListView xContenedor, List<TBL_DETALLE_FACTURAR_PRODUCTOS> nDatos)
        {
            // Limpiando el Listview
            xContenedor.Clear();
            xContenedor.Refresh();

            // Las Columnas del ListView
            xContenedor.Columns.Add("CODIGO", 100);
            xContenedor.Columns.Add("ID", 0, HorizontalAlignment.Left);
            xContenedor.Columns.Add("DESCRIPCION", 400, HorizontalAlignment.Left);
            xContenedor.Columns.Add("ID_UM", 0, HorizontalAlignment.Center);
            xContenedor.Columns.Add("DESC_UM", 100, HorizontalAlignment.Left);
            xContenedor.Columns.Add("CANTIDAD", 100, HorizontalAlignment.Center);
            xContenedor.Columns.Add("PRECIO", 100, HorizontalAlignment.Right);
            xContenedor.Columns.Add("TOTAL", 100, HorizontalAlignment.Right);

            if (nDatos != null)
            {
                // Llenando el Listview
                foreach (TBL_DETALLE_FACTURAR_PRODUCTOS xREG in nDatos)
                {
                    ListViewItem xFila = new ListViewItem(xREG.ID_PRODUCTO, 0);
                    xFila.SubItems.Add(xREG.ID);
                    xFila.SubItems.Add(xREG.DESC_PRODUCTO);
                    xFila.SubItems.Add(xREG.ID_UM);
                    xFila.SubItems.Add(xREG.DESC_UM);
                    xFila.SubItems.Add(xREG.CANTIDAD);
                    xFila.SubItems.Add(xREG.PRECIO);
                    xFila.SubItems.Add(xREG.TOTAL);

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

        private void Llenar_Lista_Encabezado(ref ListView xContenedor, List<TBL_FACTURAR_PRODUCTOS> nDatos)
        {
            // Limpiando el Listview
            xContenedor.Clear();
            xContenedor.Refresh();

            // Las Columnas del ListView
            xContenedor.Columns.Add("FECHA", 100);
            xContenedor.Columns.Add("ID", 0, HorizontalAlignment.Left);
            xContenedor.Columns.Add("CODIGO", 100, HorizontalAlignment.Center);
            xContenedor.Columns.Add("CLIENTE", 400, HorizontalAlignment.Left);
            xContenedor.Columns.Add("TIPO", 100, HorizontalAlignment.Left);
            xContenedor.Columns.Add("SUBTOTAL", 120, HorizontalAlignment.Right);
            xContenedor.Columns.Add("PORC_DESCUENTO", 120, HorizontalAlignment.Center);
            xContenedor.Columns.Add("DESCUENTO", 120, HorizontalAlignment.Right);
            xContenedor.Columns.Add("SUBTOTAL", 120, HorizontalAlignment.Right);
            xContenedor.Columns.Add("IVA", 120, HorizontalAlignment.Right);
            xContenedor.Columns.Add("NETO", 120, HorizontalAlignment.Right);
            xContenedor.Columns.Add("ANULADO", 100, HorizontalAlignment.Center);

            if (nDatos != null)
            {
                // Llenando el Listview
                foreach (TBL_FACTURAR_PRODUCTOS xREG in nDatos)
                {
                    ListViewItem xFila = new ListViewItem(xREG.FECHA, 0);
                    xFila.SubItems.Add(xREG.ID);
                    xFila.SubItems.Add(xREG.ID_CLIENTE);
                    xFila.SubItems.Add(xREG.NOMBRE_CLIENTE);
                    xFila.SubItems.Add(xREG.TIPO_CLIENTE);
                    xFila.SubItems.Add(xREG.SUBTOTAL_01);
                    xFila.SubItems.Add(xREG.PORC_DESCUENTO);
                    xFila.SubItems.Add(xREG.VAL_DESCUENTO);
                    xFila.SubItems.Add(xREG.SUBTOTAL_02);
                    xFila.SubItems.Add(xREG.IVA);
                    xFila.SubItems.Add(xREG.NETO);
                    xFila.SubItems.Add(xREG.ANULADO);

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

        private bool Validar_Detalle()
        {
            // Declaración de Variables
            bool yResult = true; this.ep_Error.Clear();

            // 1.- Campo de la Descripción
            if (xID_UM.Length == 0)
            {
                this.ep_Error.SetError(this.Txt_Unimed, "No ha Seleccionado la Unidad de Medida...");
                yResult = false;
            }
            else if (xID_PRODUCTOS.Length == 0)
            {
                this.ep_Error.SetError(this.Txt_Total, "No ha Seleccionado el Medicamento...");
                yResult = false;
            } else if (string.IsNullOrEmpty(this.Txt_Cantidad.Text.Trim()) == true)
            {
                this.ep_Error.SetError(this.Txt_Cantidad, "Debe de Digitar la Cantidad...");
                yResult = false;
            }
            else if ((double.Parse(this.Txt_Cantidad.Text) <= 0))
            {
                this.ep_Error.SetError(this.Txt_Cantidad, "La Cantidad debe ser Mayor que Cero...");
                yResult = false;
            }
            else if ((double.Parse(this.Txt_Cantidad.Text) > double.Parse(this.Txt_Exixtencia.Text)))
            {
                this.ep_Error.SetError(this.Txt_Cantidad, "La Cantidad a Facturar debe ser Menor o Igual a la Existencias...");
                yResult = false;
            }
            else if (string.IsNullOrEmpty(this.Txt_Precio.Text.Trim()) == true)
            {
                this.ep_Error.SetError(this.Txt_Precio, "Debe de Digitar el Precio...");
                yResult = false;
            }
            else if ((double.Parse(this.Txt_Precio.Text) <= 0))
            {
                this.ep_Error.SetError(this.Txt_Precio, "El Precio debe ser Mayor que Cero...");
                yResult = false;
            }
            

            return yResult;
        }

        public Frm_Factura()
        {
            InitializeComponent();
        }

        private void Frm_Factura_Load(object sender, EventArgs e)
        {
            // Cuando se Carga el Formulario
            try
            {
                this.Location = new Point(321, 25);

                // Para el Menu
                Program.xAcceso = 1; Program.Bool_Entrar = true;

                this.Txt_IdFactura.ReadOnly = true;
                this.Dtp_Fecha.Enabled = false;
                this.Chk_Anulado.Enabled = false;
                this.Txt_SubTotal_01.ReadOnly = true;
                this.Txt_Porc_Descuento.ReadOnly = true;
                this.Txt_Val_Descuento.ReadOnly = true;
                this.Txt_SubTotal_02.ReadOnly = true;
                this.Txt_Val_IVA.ReadOnly = true;
                this.Txt_Neto.ReadOnly = true;

                this.Txt_IdFactura.Text = string.Empty;
                this.Dtp_Fecha.Value = DateTime.Now;
                this.Chk_Anulado.Checked = false;
                this.Txt_SubTotal_01.Text = string.Empty;
                this.Txt_Porc_Descuento.Text = string.Empty;
                this.Txt_Val_Descuento.Text = string.Empty;
                this.Txt_SubTotal_02.Text = string.Empty;
                this.Txt_Val_IVA.Text = string.Empty;
                this.Txt_Neto.Text = string.Empty;

                this.Btn_Proveedor.Enabled = false;
                this.Txt_CodCliente.ReadOnly = true;
                this.Txt_Cliente.ReadOnly = true;
                this.Txt_Tipo_Cliente.ReadOnly = true;

                this.Txt_CodCliente.Text = string.Empty;
                this.Txt_Cliente.Text = string.Empty;
                this.Txt_Tipo_Cliente.Text = string.Empty;

                this.Btn_Unidad_Medida.Enabled = false;
                this.Txt_Unimed.ReadOnly = true;
                this.Txt_Unimed.Text = string.Empty;

                this.Btn_Medicamento.Enabled = false;
                this.Txt_CodProducto.ReadOnly = true;
                this.Txt_Descripcion.ReadOnly = true;
                this.Txt_Exixtencia.ReadOnly = true;
                this.Txt_PVU.ReadOnly = true;
                this.Txt_Total.ReadOnly = true;

                this.Txt_CodProducto.Text = string.Empty;
                this.Txt_Descripcion.Text = string.Empty;
                this.Txt_Exixtencia.Text = string.Empty;
                this.Txt_PVU.Text = string.Empty;
                this.Txt_Total.Text = string.Empty;

                this.Txt_Cantidad.Text = string.Empty;
                this.Txt_Cantidad.ReadOnly = true;
                this.Txt_Precio.Text = string.Empty;
                this.Txt_Precio.ReadOnly = true;

                this.Btn_AgregarDetalle.Enabled = false;
                this.Btn_Quitar.Enabled = false;

                this.Lv_Entradas.Enabled = false;

                this.Cmd_Nuevo.Enabled = true;
                this.Cmd_Guardar.Enabled = false;
                this.Cmd_Cancelar.Enabled = false;
                this.Cmd_Anular.Enabled = false;
                this.Cmd_Imprimir.Enabled = false;
                this.Cmd_Consultar.Enabled = true;

                
                this.Fr_Busqueda.Visible = false;

                //Recuperando Registros
                Program.xMsg = string.Empty;
                Mi_REG_DET = Program.xMETODOS.Listar_DET_Facturar_Productos(out Program.xMsg, "0");
                if (Program.xMsg.Length > 0)
                {
                    MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Bool_Entrar = false;
                    return;
                }

                Llenar_Lista_Detalle(ref this.Lv_Entradas, Mi_REG_DET);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Program.xError + ex.Message.ToString(), Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Bool_Entrar = false; Program.xAcceso = 0;
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            //Cerrando el Formulario de Clientes
            Program.xMensaje = MessageBox.Show("¿DESEA CERRAR EL FORMULARIO?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.Yes)
                this.Close();
        }

        private void Existencias_y_Costos_Productos(string xID_PROD, string xID_UM)
        {
            Program.xMsg = string.Empty;
            List<TBL_EXISTENCIAS_y_COSTOS> Mi_REG = Program.xMETODOS.Listar_Existencias_y_Costos_Productos(out Program.xMsg, xID_PROD, xID_UM);
            if (Program.xMsg.Length > 0)
            {
                MessageBox.Show(Program.xMsg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Bool_Entrar = false;
                return;
            }

            if (Mi_REG.Count > 0)
            {
                this.Txt_Exixtencia.Text = Mi_REG[0].CANT.ToString();
                this.Txt_PVU.Text = Mi_REG[0].COSTO.ToString();
                this.Txt_Total.Text = Mi_REG[0].TOTAL.ToString();
            }
        }

    }
}
