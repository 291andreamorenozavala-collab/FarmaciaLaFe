using System;

namespace Capa_Diseño
{
    partial class Frm_Password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Password));
            PictureBox3 = new PictureBox();
            PictureBox2 = new PictureBox();
            Label2 = new Label();
            Btn_Ok = new Button();
            Txt_Login = new TextBox();
            Label3 = new Label();
            Label7 = new Label();
            PictureBox1 = new PictureBox();
            Pb_Tiempo = new ProgressBar();
            Label1 = new Label();
            PictureBox4 = new PictureBox();
            Btn_Cerrar = new Button();
            Label4 = new Label();
            Label5 = new Label();
            panel1 = new Panel();
            Txt_Password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).BeginInit();
            SuspendLayout();
            // 
            // PictureBox3
            // 
            PictureBox3.Image = (Image)resources.GetObject("PictureBox3.Image");
            PictureBox3.Location = new Point(12, 340);
            PictureBox3.Margin = new Padding(4, 3, 4, 3);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(617, 5);
            PictureBox3.TabIndex = 135;
            PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.BackColor = SystemColors.ActiveCaption;
            PictureBox2.Image = (Image)resources.GetObject("PictureBox2.Image");
            PictureBox2.Location = new Point(10, 6);
            PictureBox2.Margin = new Padding(4, 3, 4, 3);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(34, 28);
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox2.TabIndex = 134;
            PictureBox2.TabStop = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(323, 73);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(182, 22);
            Label2.TabIndex = 132;
            Label2.Text = "INICIO DE SESIÓN";
            // 
            // Btn_Ok
            // 
            Btn_Ok.BackColor = Color.Transparent;
            Btn_Ok.FlatStyle = FlatStyle.Flat;
            Btn_Ok.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Ok.ForeColor = Color.Transparent;
            Btn_Ok.Image = (Image)resources.GetObject("Btn_Ok.Image");
            Btn_Ok.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Ok.Location = new Point(328, 249);
            Btn_Ok.Margin = new Padding(4, 3, 4, 3);
            Btn_Ok.Name = "Btn_Ok";
            Btn_Ok.Size = new Size(290, 28);
            Btn_Ok.TabIndex = 130;
            Btn_Ok.Text = "Entrar";
            Btn_Ok.UseVisualStyleBackColor = false;
            Btn_Ok.Click += Btn_Ok_Click;
            // 
            // Txt_Login
            // 
            Txt_Login.CharacterCasing = CharacterCasing.Upper;
            Txt_Login.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Login.ForeColor = SystemColors.HotTrack;
            Txt_Login.Location = new Point(323, 149);
            Txt_Login.Margin = new Padding(4, 3, 4, 3);
            Txt_Login.MaxLength = 50;
            Txt_Login.Name = "Txt_Login";
            Txt_Login.Size = new Size(294, 23);
            Txt_Login.TabIndex = 129;
            Txt_Login.WordWrap = false;
            Txt_Login.TextChanged += Txt_Login_TextChanged;
            Txt_Login.KeyPress += Txt_Login_KeyPress;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(323, 177);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(69, 18);
            Label3.TabIndex = 128;
            Label3.Text = "CLAVE:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(323, 119);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(90, 18);
            Label7.TabIndex = 127;
            Label7.Text = "USUARIO:";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(327, 102);
            PictureBox1.Margin = new Padding(4, 3, 4, 3);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(292, 5);
            PictureBox1.TabIndex = 133;
            PictureBox1.TabStop = false;
            // 
            // Pb_Tiempo
            // 
            Pb_Tiempo.BackColor = Color.Black;
            Pb_Tiempo.ForeColor = Color.Navy;
            Pb_Tiempo.Location = new Point(12, 300);
            Pb_Tiempo.Margin = new Padding(4, 3, 4, 3);
            Pb_Tiempo.MarqueeAnimationSpeed = 20;
            Pb_Tiempo.Name = "Pb_Tiempo";
            Pb_Tiempo.Size = new Size(617, 17);
            Pb_Tiempo.Style = ProgressBarStyle.Marquee;
            Pb_Tiempo.TabIndex = 126;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = SystemColors.ActiveCaption;
            Label1.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(47, 6);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(185, 23);
            Label1.TabIndex = 123;
            Label1.Text = "FARMACIA LA FÉ";
            // 
            // PictureBox4
            // 
            PictureBox4.BackColor = Color.Transparent;
            PictureBox4.Image = (Image)resources.GetObject("PictureBox4.Image");
            PictureBox4.Location = new Point(16, 74);
            PictureBox4.Margin = new Padding(4, 3, 4, 3);
            PictureBox4.Name = "PictureBox4";
            PictureBox4.Size = new Size(300, 200);
            PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox4.TabIndex = 125;
            PictureBox4.TabStop = false;
            // 
            // Btn_Cerrar
            // 
            Btn_Cerrar.BackColor = SystemColors.ActiveCaption;
            Btn_Cerrar.FlatAppearance.BorderSize = 0;
            Btn_Cerrar.FlatStyle = FlatStyle.Flat;
            Btn_Cerrar.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Cerrar.ForeColor = Color.Transparent;
            Btn_Cerrar.Image = (Image)resources.GetObject("Btn_Cerrar.Image");
            Btn_Cerrar.Location = new Point(588, 6);
            Btn_Cerrar.Margin = new Padding(4, 3, 4, 3);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(43, 27);
            Btn_Cerrar.TabIndex = 124;
            Btn_Cerrar.UseVisualStyleBackColor = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(538, 353);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(80, 15);
            Label4.TabIndex = 122;
            Label4.Text = "Version 1.0";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(13, 353);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(218, 15);
            Label5.TabIndex = 121;
            Label5.Text = "Copyright © Farmacia la Fé 2019";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 40);
            panel1.TabIndex = 136;
            // 
            // Txt_Password
            // 
            Txt_Password.CharacterCasing = CharacterCasing.Upper;
            Txt_Password.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Password.ForeColor = SystemColors.HotTrack;
            Txt_Password.Location = new Point(323, 216);
            Txt_Password.Margin = new Padding(4, 3, 4, 3);
            Txt_Password.MaxLength = 50;
            Txt_Password.Name = "Txt_Password";
            Txt_Password.Size = new Size(294, 23);
            Txt_Password.TabIndex = 137;
            Txt_Password.WordWrap = false;
            Txt_Password.TextChanged += Txt_Password_TextChanged_1;
            // 
            // Frm_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 44, 69);
            ClientSize = new Size(643, 381);
            Controls.Add(Txt_Password);
            Controls.Add(PictureBox3);
            Controls.Add(PictureBox2);
            Controls.Add(Label2);
            Controls.Add(Btn_Ok);
            Controls.Add(Txt_Login);
            Controls.Add(Label3);
            Controls.Add(Label7);
            Controls.Add(PictureBox1);
            Controls.Add(Pb_Tiempo);
            Controls.Add(Label1);
            Controls.Add(PictureBox4);
            Controls.Add(Btn_Cerrar);
            Controls.Add(Label4);
            Controls.Add(Label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_Password";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Password";
            Load += Frm_Password_Load;
            VisibleChanged += Frm_Password_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void Txt_Password_TextChanged_1(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        //private void Txt_Password_TextChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Btn_Ok;
        internal System.Windows.Forms.TextBox Txt_Login;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.ProgressBar Pb_Tiempo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox4;
        internal System.Windows.Forms.Button Btn_Cerrar;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TextBox Txt_Password;
    }
}