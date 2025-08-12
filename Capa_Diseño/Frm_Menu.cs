using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            //Para ver si tiene despliega la opcion en caso de estar cerrado
            if (Program.xAcceso != 0)
            {
                MessageBox.Show("Debe de Cerrar el Formulario que está abierto!!!", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Llamada del Formulario
            Program.Val_Ban = 0;

            Frm_Clientes oForm = new Frm_Clientes();
            oForm.ShowDialog();
            
        }

        private void Btn_Unidad_Medida_Click(object sender, EventArgs e)
        {
            //Para ver si tiene despliega la opcion en caso de estar cerrado
            if (Program.xAcceso != 0)
            {
                MessageBox.Show("Debe de Cerrar el Formulario que está abierto!!!", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Llamada del Formulario
            Program.Val_Ban = 0;

            Frm_Unidad_Medida oForm = new Frm_Unidad_Medida();
            oForm.ShowDialog();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            //Fin de la Aplicacion
            Program.xMensaje = MessageBox.Show("¿DESE SALIR DEL SISTEMA?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.Yes)
                Application.Exit();

        }

        private void Btn_Medicamentos_Click(object sender, EventArgs e)
        {
            //Para ver si tiene despliega la opcion en caso de estar cerrado
            if (Program.xAcceso != 0)
            {
                MessageBox.Show("Debe de Cerrar el Formulario que está abierto!!!", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Llamada del Formulario
            Program.Val_Ban = 0;

            Frm_Productos oForm = new Frm_Productos();
            oForm.ShowDialog();
        }

        private void Btn_Proveedores_Click(object sender, EventArgs e)
        {
            //Para ver si tiene despliega la opcion en caso de estar cerrado
            if (Program.xAcceso != 0)
            {
                MessageBox.Show("Debe de Cerrar el Formulario que está abierto!!!", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Llamada del Formulario
            Program.Val_Ban = 0;

            Frm_Proveedores oForm = new Frm_Proveedores();
            oForm.ShowDialog();
        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            //Para ver si tiene despliega la opcion en caso de estar cerrado
            if (Program.xAcceso != 0)
            {
                MessageBox.Show("Debe de Cerrar el Formulario que está abierto!!!", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Program.Rol_Quien != "ADMINISTRADOR")
            {
                MessageBox.Show("Esta ventana es solo para la Cuenta de Administrador!!!", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // Llamada del Formulario
            Program.Val_Ban = 0;

            Frm_Usuarios oForm = new Frm_Usuarios();
            oForm.ShowDialog();
        }

        private void Btn_Rpt_Unidad_Medida_Click(object sender, EventArgs e)
        {            
            // Verificando Si desea Imprimir
            Program.xMensaje = MessageBox.Show("¿Desea Imprimir los Registros?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.No)
            { return; }

            Program.xReporte = 1; 

            Frm_Visualizador xForm = new Frm_Visualizador();
            xForm.ShowDialog(); 
        }

        private void Btn_Rpt_Clientes_Click(object sender, EventArgs e)
        {
            // Verificando Si desea Imprimir
            Program.xMensaje = MessageBox.Show("¿Desea Imprimir los Registros?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.No)
            { return; }

            Program.xReporte = 2;

            Frm_Visualizador xForm = new Frm_Visualizador();
            xForm.ShowDialog();
        }

        private void Btn_Rpt_Proveedores_Click(object sender, EventArgs e)
        {
            // Verificando Si desea Imprimir
            Program.xMensaje = MessageBox.Show("¿Desea Imprimir los Registros?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.No)
            { return; }

            Program.xReporte = 3;

            Frm_Visualizador xForm = new Frm_Visualizador();
            xForm.ShowDialog();
        }

        private void Btn_Rpt_Medicamentos_Click(object sender, EventArgs e)
        {
            // Verificando Si desea Imprimir
            Program.xMensaje = MessageBox.Show("¿Desea Imprimir los Registros?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.No)
            { return; }

            Program.xReporte = 4;

            Frm_Visualizador xForm = new Frm_Visualizador();
            xForm.ShowDialog();
        }

        private void Btn_Rpt_Usuarios_Click(object sender, EventArgs e)
        {
            // Verificando Si desea Imprimir
            Program.xMensaje = MessageBox.Show("¿Desea Imprimir los Registros?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.No)
            { return; }

            Program.xReporte = 5;

            Frm_Visualizador xForm = new Frm_Visualizador();
            xForm.ShowDialog();
        }

        private void Btn_Acerca_Click(object sender, EventArgs e)
        {
            //Para ver si tiene despliega la opcion en caso de estar cerrado
            if (Program.xAcceso != 0)
            {
                MessageBox.Show("Debe de Cerrar el Formulario que está abierto!!!", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Llamada del Formulario
            Program.Val_Ban = 0;

            Frm_Acerca oForm = new Frm_Acerca();
            oForm.ShowDialog();
        }

        private void Btn_Entradas_Click(object sender, EventArgs e)
        {
            //Para ver si tiene despliega la opcion en caso de estar cerrado
            if (Program.xAcceso != 0)
            {
                MessageBox.Show("Debe de Cerrar el Formulario que está abierto!!!", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            // Llamada del Formulario
            Program.Val_Ban = 0;

            Frm_Entrada oForm = new Frm_Entrada();
            oForm.ShowDialog();
        }

        private void Btn_Facturas_Click(object sender, EventArgs e)
        {
            //Para ver si tiene despliega la opcion en caso de estar cerrado
            if (Program.xAcceso != 0)
            {
                MessageBox.Show("Debe de Cerrar el Formulario que está abierto!!!", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Llamada del Formulario
            Program.Val_Ban = 0;

            Frm_Factura oForm = new Frm_Factura();
            oForm.ShowDialog();
        }
    }
}
