namespace Capa_Diseño
{
    partial class Frm_Inicio
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inicio));
            Label1 = new Label();
            Pb_Tiempo = new ProgressBar();
            Timer1 = new System.Windows.Forms.Timer(components);
            Label4 = new Label();
            Label6 = new Label();
            PictureBox3 = new PictureBox();
            Cmd_Cerrar = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(169, 285);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(416, 22);
            Label1.TabIndex = 95;
            Label1.Text = "SISTEMA DE FARMACIA DE FACTURACIÓN";
            // 
            // Pb_Tiempo
            // 
            Pb_Tiempo.BackColor = Color.Black;
            Pb_Tiempo.ForeColor = Color.Navy;
            Pb_Tiempo.Location = new Point(56, 373);
            Pb_Tiempo.Margin = new Padding(4);
            Pb_Tiempo.Name = "Pb_Tiempo";
            Pb_Tiempo.Size = new Size(581, 23);
            Pb_Tiempo.Style = ProgressBarStyle.Marquee;
            Pb_Tiempo.TabIndex = 94;
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 2000;
            Timer1.Tick += Timer1_Tick;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(615, 451);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(80, 15);
            Label4.TabIndex = 99;
            Label4.Text = "Version 1.2";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(10, 451);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(220, 15);
            Label6.TabIndex = 98;
            Label6.Text = "Copyright © Farmacia la MJ 2025";
            // 
            // PictureBox3
            // 
            PictureBox3.BackColor = Color.Transparent;
            PictureBox3.Image = (Image)resources.GetObject("PictureBox3.Image");
            PictureBox3.Location = new Point(262, 76);
            PictureBox3.Margin = new Padding(4);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(199, 185);
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox3.TabIndex = 97;
            PictureBox3.TabStop = false;
            // 
            // Cmd_Cerrar
            // 
            Cmd_Cerrar.BackColor = Color.Transparent;
            Cmd_Cerrar.FlatAppearance.BorderSize = 0;
            Cmd_Cerrar.FlatStyle = FlatStyle.Flat;
            Cmd_Cerrar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmd_Cerrar.ForeColor = Color.Transparent;
            Cmd_Cerrar.Image = (Image)resources.GetObject("Cmd_Cerrar.Image");
            Cmd_Cerrar.Location = new Point(655, 9);
            Cmd_Cerrar.Margin = new Padding(4);
            Cmd_Cerrar.Name = "Cmd_Cerrar";
            Cmd_Cerrar.Size = new Size(43, 26);
            Cmd_Cerrar.TabIndex = 92;
            Cmd_Cerrar.UseVisualStyleBackColor = false;
            Cmd_Cerrar.Click += Cmd_Cerrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(310, 332);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 22);
            label5.TabIndex = 100;
            label5.Text = "Iniciando";
            // 
            // Frm_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 240, 225);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(718, 485);
            Controls.Add(label5);
            Controls.Add(Label1);
            Controls.Add(Pb_Tiempo);
            Controls.Add(Label4);
            Controls.Add(Label6);
            Controls.Add(PictureBox3);
            Controls.Add(Cmd_Cerrar);
            Margin = new Padding(4);
            Name = "Farmacia MJ";
            ShowInTaskbar = false;
            Text = "Farmacia MJ";
            Load += Frm_Inicio_Load;
            Controls.SetChildIndex(Cmd_Cerrar, 0);
            Controls.SetChildIndex(PictureBox3, 0);
            Controls.SetChildIndex(Label6, 0);
            Controls.SetChildIndex(Label4, 0);
            Controls.SetChildIndex(Pb_Tiempo, 0);
            Controls.SetChildIndex(Label1, 0);
            Controls.SetChildIndex(label5, 0);
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

     
       internal System.Windows.Forms.Label Label1;
    
        internal System.Windows.Forms.ProgressBar Pb_Tiempo;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.Button Cmd_Cerrar;
        internal System.Windows.Forms.Label label5;
    }
}