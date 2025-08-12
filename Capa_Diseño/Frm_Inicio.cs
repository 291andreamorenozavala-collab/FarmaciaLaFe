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
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {
            //TIEMPO QUE TRANSCURRIRÁ PARA CERRAR EL FORMULARIO DE INICIO(2 SEGUNDO APROXIMADAMENTE)
            Timer1.Interval = 3000;
            Timer1.Enabled = true;
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //CIERRA EL FORMULARIO DE INICIO AL TRANSCURRIR LOS DOS SEGUNDOS
            this.Close();
        }

        private void Cmd_Cerrar_Click(object sender, EventArgs e)
        {
            //Fin de la Aplicacion
            this.Close();
        }
    }
}
