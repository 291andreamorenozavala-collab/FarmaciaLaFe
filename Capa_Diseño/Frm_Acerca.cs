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
    public partial class Frm_Acerca : Form
    {
        public Frm_Acerca()
        {
            InitializeComponent();
        }

        private void Frm_Acerca_Load(object sender, EventArgs e)
        {
            this.Location = new Point(321, 25);
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            //Cerrando el Formulario de Clientes
            Program.xMensaje = MessageBox.Show("¿DESEA CERRAR EL FORMULARIO?", Program.SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Program.xMensaje == DialogResult.Yes)
                this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
