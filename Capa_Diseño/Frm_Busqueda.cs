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
    public partial class Frm_Busqueda : Form
    {
        public Frm_Busqueda()
        {
            InitializeComponent();
        }

        private void Frm_Busqueda_Load(object sender, EventArgs e)
        {
            //Posición del formulario en un Punto de la Pantalla
            this.Location = new Point(316, 0);
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            //Cerrando el Formulario de Busqueda
            Program.xMensaje = MessageBox.Show("¿DESEA CERRAR EL FORMULARIO?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.Yes)
                this.Close();
        }
    }
}
