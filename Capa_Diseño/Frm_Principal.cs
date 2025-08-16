using System;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Diseño
{
    public partial class Frm_Principal : Form
    {
        private Form _preferido; // Hijo con prioridad (en este caso Frm_Menu)

        public Frm_Principal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            // Cada vez que cambia el hijo activo, volvemos a traer el preferido
            this.MdiChildActivate += (_, __) => ReafirmarPrioridad();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            //Visualizando el formulario Menu (PRIORIDAD)
            Frm_Menu oForm = new Frm_Menu();
            oForm.MdiParent = this;
            oForm.Show();
            EstablecerHijoPreferido(oForm);

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

        // ====== Lógica de prioridad ======
        private void EstablecerHijoPreferido(Form hijo)
        {
            _preferido = hijo;
            hijo.FormClosed += (_, __) => { if (_preferido == hijo) _preferido = null; };
            ReafirmarPrioridad();
        }

        private void ReafirmarPrioridad()
        {
            if (_preferido == null || _preferido.IsDisposed) return;
            if (_preferido.WindowState == FormWindowState.Minimized) return;

            _preferido.BringToFront();
            _preferido.Activate();
        }

        // ==== Resto de tus menús y eventos igual ====

        private void Mnu_Salir_Click(object sender, EventArgs e)
        {
            Program.xMensaje = MessageBox.Show("¿DESEA SALIR DEL SISTEMA?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.Yes)
                this.Close();
        }

        private void Mnu_Reg_Clientes_Click(object sender, EventArgs e)
        {
            Frm_Clientes oForm = new Frm_Clientes();
            oForm.MdiParent = this;
            oForm.Show();
            ReafirmarPrioridad();
        }

        private void Mnu_Reg_Proveedore_Click(object sender, EventArgs e)
        {
            Frm_Proveedores oForm = new Frm_Proveedores();
            oForm.MdiParent = this;
            oForm.Show();
            ReafirmarPrioridad();
        }

        private void Mnu_Reg_Medicamentos_Click(object sender, EventArgs e)
        {
            Frm_Productos oForm = new Frm_Productos();
            oForm.MdiParent = this;
            oForm.Show();
            ReafirmarPrioridad();
        }

        private void Mnu_Trans_Entrada_Click(object sender, EventArgs e)
        {
            Frm_Entrada oForm = new Frm_Entrada();
            oForm.MdiParent = this;
            oForm.Show();
            ReafirmarPrioridad();
        }

        private void Mnu_Trans_Facturar_Click(object sender, EventArgs e)
        {
            Frm_Factura oForm = new Frm_Factura();
            oForm.MdiParent = this;
            oForm.Show();
            ReafirmarPrioridad();
        }

        private void Mnu_Admin_Usuarios_Click(object sender, EventArgs e)
        {
            Frm_Usuarios oForm = new Frm_Usuarios();
            oForm.MdiParent = this;
            oForm.Show();
            ReafirmarPrioridad();
        }

        private void Btn_Unidad_Medida_Click(object sender, EventArgs e)
        {
            if (Program.xAcceso != 0)
            {
                MessageBox.Show("Debe de Cerrar el Formulario que está abierto!!!", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Program.Val_Ban = 0;
            Frm_Unidad_Medida oForm = new Frm_Unidad_Medida();
            oForm.MdiParent = this;
            oForm.Show();
            ReafirmarPrioridad();
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.xMensaje = MessageBox.Show("¿Desea Salir de la Aplicación?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (Program.xMensaje != DialogResult.Yes);
        }
    }
}
