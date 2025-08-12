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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inicio));
            this.Label1 = new System.Windows.Forms.Label();
            this.Pb_Tiempo = new System.Windows.Forms.ProgressBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Cmd_Cerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(16, 273);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(519, 28);
            this.Label1.TabIndex = 95;
            this.Label1.Text = "SISTEMA DE FARMACIA DE FACTURACIÓN";
            // 
            // Pb_Tiempo
            // 
            this.Pb_Tiempo.BackColor = System.Drawing.Color.Black;
            this.Pb_Tiempo.ForeColor = System.Drawing.Color.Navy;
            this.Pb_Tiempo.Location = new System.Drawing.Point(143, 326);
            this.Pb_Tiempo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pb_Tiempo.Name = "Pb_Tiempo";
            this.Pb_Tiempo.Size = new System.Drawing.Size(664, 25);
            this.Pb_Tiempo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Pb_Tiempo.TabIndex = 94;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 2000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(703, 481);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(101, 20);
            this.Label4.TabIndex = 99;
            this.Label4.Text = "Version 1.0";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(12, 481);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(276, 20);
            this.Label6.TabIndex = 98;
            this.Label6.Text = "Copyright © Farmacia la Fé 2019";
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(275, 14);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(285, 223);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 97;
            this.PictureBox3.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(16, 235);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(213, 28);
            this.Label3.TabIndex = 96;
            this.Label3.Text = "FARMACIA LA FÉ";
            // 
            // Cmd_Cerrar
            // 
            this.Cmd_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Cerrar.FlatAppearance.BorderSize = 0;
            this.Cmd_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Cerrar.ForeColor = System.Drawing.Color.Transparent;
            this.Cmd_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cmd_Cerrar.Image")));
            this.Cmd_Cerrar.Location = new System.Drawing.Point(749, 10);
            this.Cmd_Cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmd_Cerrar.Name = "Cmd_Cerrar";
            this.Cmd_Cerrar.Size = new System.Drawing.Size(49, 28);
            this.Cmd_Cerrar.TabIndex = 92;
            this.Cmd_Cerrar.UseVisualStyleBackColor = false;
            this.Cmd_Cerrar.Click += new System.EventHandler(this.Cmd_Cerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 28);
            this.label5.TabIndex = 100;
            this.label5.Text = "Iniciando";
            // 
            // Frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 517);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Pb_Tiempo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Cmd_Cerrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Inicio";
            this.ShowInTaskbar = false;
            this.Text = "Frm_Inicio";
            this.Load += new System.EventHandler(this.Frm_Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ProgressBar Pb_Tiempo;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button Cmd_Cerrar;
        internal System.Windows.Forms.Label label5;
    }
}