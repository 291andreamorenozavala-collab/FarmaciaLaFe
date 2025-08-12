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
    public partial class Frm_Password : Form
    {
        public Frm_Password()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            //Fin de la Aplicacion
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                Program.xMsg = string.Empty; this.Pb_Tiempo.Visible = true;
                List<Capa_Entidad.TBL_AUTENTICACION> Mis_Reg = Program.Autenticar_Usuario(this.Txt_Login.Text, this.Txt_Password.Text);

                if (Program.Str_Resp_Msg.Length > 0)
                { MessageBox.Show(Program.Str_Resp_Msg, Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                if (Mis_Reg.Count > 0)
                {
                    Program.Login_Quien = this.Txt_Login.Text.Trim();

                    Program.Nombre_Quien = Mis_Reg[0].NOMBRE.ToString();
                    Program.Id_User = double.Parse(Mis_Reg[0].ID.ToString());
                    Program.Rol_Quien = Mis_Reg[0].TIPO.ToString();


                    //Abriendo el formulario principal
                    this.DialogResult = DialogResult.OK; this.Close();

                }
                else
                {
                    MessageBox.Show("Usuario No Existe!!!", Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Txt_Login.Text = Environment.UserName.ToString().ToUpper();
                    this.Txt_Password.Text = string.Empty; this.Txt_Password.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un Error: " + ex.Message.ToString(), Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Txt_Login.Text = string.Empty; this.Txt_Password.Text = string.Empty; this.Txt_Password.Select();
            }
        }

        private void Frm_Password_Load(object sender, EventArgs e)
        {
            try
            {
                this.Pb_Tiempo.Visible = true;

                this.Txt_Login.Text = Environment.UserName.ToString().ToUpper();
                this.Txt_Password.Text = string.Empty;
                this.Txt_Login.Select();

                this.Txt_Login.ReadOnly = false;
                this.Txt_Password.ReadOnly = false;

                this.Text = Program.SISTEMA;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Program.xError + ex.Message.ToString(), Program.SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Bool_Entrar = false;
            }
        }

        private void Txt_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Pasando de un Campo a Otro
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.Txt_Login.ReadOnly == true)
                {
                    e.Handled = true;
                    return;
                }
                this.Txt_Password.Select();
            }
            else { e.Handled = false; }
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Pasando de un Campo a Otro Ejemplo
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.Txt_Password.ReadOnly == true)
                {
                    e.Handled = true;
                    return;
                }
                this.Btn_Ok.Select();
            }
            else { e.Handled = false; }
        }
        //test 2
        private void Frm_Password_VisibleChanged(object sender, EventArgs e)
        {
            if (Program.Bool_Entrar == false)
                this.Close();
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //// Comentario de prueba
        private void Txt_Login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
