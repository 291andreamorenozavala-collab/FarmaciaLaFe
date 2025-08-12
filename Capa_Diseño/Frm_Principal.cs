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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            //Visualizando el formulario Menu
            Frm_Menu oForm = new Frm_Menu();
            oForm.MdiParent = this;
            oForm.Show();

            //Visualizando el formulario Presentacion
            Frm_Presentacion oForm1 = new Frm_Presentacion();
            oForm1.MdiParent = this;
            oForm1.Show();

            //Visualizando el formulario Pie de página
            Frm_Piedepagina oForm2 = new Frm_Piedepagina();
            oForm2.MdiParent = this;
            oForm2.Show();

            //Entorno de la Aplicacion
            Program.xAcceso = 0;
            this.Text = Program.SISTEMA;
            this.Select();

            //La Barra de Estado
            this.Stb_Barra_Estado.Items[0].Text = "USUARIO: " + Program.Nombre_Quien.ToUpper() + "".PadLeft(10, ' ') + "ROL: " + Program.Rol_Quien.ToUpper();
            this.Stb_Barra_Estado.Items[1].Text = "FECHA: " + string.Format("{0:dd/MM/yy}", DateTime.Now).ToUpper();
            this.Stb_Barra_Estado.Items[2].Text = "HORA: " + string.Format("{0:hh:mm tt}", DateTime.Now).ToUpper();

        }
         private void Mnu_Salir_Click(object sender, EventArgs e)
        {
            //Fin de la Aplicacion
            Program.xMensaje = MessageBox.Show("¿DESEA SALIR DEL SISTEMA?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.Yes)
                this.Close();
        }

        private void Mnu_Reg_Clientes_Click(object sender, EventArgs e)
        {
            //Visualizando el Formulario cliente           
            Frm_Clientes oForm = new Frm_Clientes();
            oForm.MdiParent = this;
            oForm.Show();
             
        }

        private void Mnu_Reg_Proveedore_Click(object sender, EventArgs e)
        {
            //Visualizando el Formulario cliente           
            Frm_Proveedores oForm = new Frm_Proveedores();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void Mnu_Reg_Medicamentos_Click(object sender, EventArgs e)
        {
            //Visualizando el Formulario cliente           
            Frm_Productos oForm = new Frm_Productos();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void Mnu_Trans_Entrada_Click(object sender, EventArgs e)
        {
            //Visualizando el Formulario de Entradas          
            Frm_Entrada oForm = new Frm_Entrada();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void Mnu_Trans_Facturar_Click(object sender, EventArgs e)
        {
            //Visualizando el Formulario de Entradas          
            Frm_Factura oForm = new Frm_Factura();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void Mnu_Admin_Usuarios_Click(object sender, EventArgs e)
        {
            //Visualizando el Formulario de Usuarios          
            Frm_Usuarios oForm = new Frm_Usuarios();
            oForm.MdiParent = this;
            oForm.Show();
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
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Fin de la Aplicacion
            Program.xMensaje = MessageBox.Show("¿Desea Salir de la Aplicación?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.Yes)
            { e.Cancel = false; }
            else { e.Cancel = true; }
        }
    }
}
