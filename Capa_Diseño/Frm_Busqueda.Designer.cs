namespace Capa_Diseño
{
    partial class Frm_Busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busqueda));
            this.Opt_2 = new System.Windows.Forms.RadioButton();
            this.Opt_1 = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Txt_Filtro = new System.Windows.Forms.TextBox();
            this.Lbl_Contador = new System.Windows.Forms.Label();
            this.Lv_Listado = new System.Windows.Forms.ListView();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Opt_2
            // 
            this.Opt_2.AutoSize = true;
            this.Opt_2.BackColor = System.Drawing.Color.Transparent;
            this.Opt_2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opt_2.ForeColor = System.Drawing.Color.White;
            this.Opt_2.Location = new System.Drawing.Point(363, 47);
            this.Opt_2.Name = "Opt_2";
            this.Opt_2.Size = new System.Drawing.Size(111, 23);
            this.Opt_2.TabIndex = 138;
            this.Opt_2.TabStop = true;
            this.Opt_2.Text = "Alternativa 2";
            this.Opt_2.UseVisualStyleBackColor = false;
            // 
            // Opt_1
            // 
            this.Opt_1.AutoSize = true;
            this.Opt_1.BackColor = System.Drawing.Color.Transparent;
            this.Opt_1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opt_1.ForeColor = System.Drawing.Color.White;
            this.Opt_1.Location = new System.Drawing.Point(130, 47);
            this.Opt_1.Name = "Opt_1";
            this.Opt_1.Size = new System.Drawing.Size(111, 23);
            this.Opt_1.TabIndex = 137;
            this.Opt_1.TabStop = true;
            this.Opt_1.Text = "Alternativa 1";
            this.Opt_1.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(13, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(82, 19);
            this.Label2.TabIndex = 136;
            this.Label2.Text = "Buscar por:";
            // 
            // Txt_Filtro
            // 
            this.Txt_Filtro.BackColor = System.Drawing.Color.White;
            this.Txt_Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Filtro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Filtro.Location = new System.Drawing.Point(12, 80);
            this.Txt_Filtro.Name = "Txt_Filtro";
            this.Txt_Filtro.Size = new System.Drawing.Size(864, 21);
            this.Txt_Filtro.TabIndex = 135;
            // 
            // Lbl_Contador
            // 
            this.Lbl_Contador.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_Contador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contador.ForeColor = System.Drawing.Color.White;
            this.Lbl_Contador.Location = new System.Drawing.Point(882, 80);
            this.Lbl_Contador.Name = "Lbl_Contador";
            this.Lbl_Contador.Size = new System.Drawing.Size(153, 19);
            this.Lbl_Contador.TabIndex = 134;
            this.Lbl_Contador.Text = "Registro:";
            // 
            // Lv_Listado
            // 
            this.Lv_Listado.BackColor = System.Drawing.Color.LightGray;
            this.Lv_Listado.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Listado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lv_Listado.FullRowSelect = true;
            this.Lv_Listado.GridLines = true;
            this.Lv_Listado.LabelWrap = false;
            this.Lv_Listado.Location = new System.Drawing.Point(12, 107);
            this.Lv_Listado.MultiSelect = false;
            this.Lv_Listado.Name = "Lv_Listado";
            this.Lv_Listado.ShowGroups = false;
            this.Lv_Listado.Size = new System.Drawing.Size(1023, 460);
            this.Lv_Listado.TabIndex = 133;
            this.Lv_Listado.UseCompatibleStateImageBehavior = false;
            this.Lv_Listado.View = System.Windows.Forms.View.Details;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Titulo.Location = new System.Drawing.Point(13, 4);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(249, 22);
            this.Lbl_Titulo.TabIndex = 132;
            this.Lbl_Titulo.Text = "Información de Busqueda:";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Location = new System.Drawing.Point(966, 4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(68, 30);
            this.Btn_Cerrar.TabIndex = 131;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(17, 29);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(281, 4);
            this.PictureBox1.TabIndex = 139;
            this.PictureBox1.TabStop = false;
            // 
            // Frm_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1046, 574);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Opt_2);
            this.Controls.Add(this.Opt_1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Txt_Filtro);
            this.Controls.Add(this.Lbl_Contador);
            this.Controls.Add(this.Lv_Listado);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Btn_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Busqueda";
            this.Text = "Frm_Busqueda";
            this.Load += new System.EventHandler(this.Frm_Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RadioButton Opt_2;
        internal System.Windows.Forms.RadioButton Opt_1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox Txt_Filtro;
        internal System.Windows.Forms.Label Lbl_Contador;
        internal System.Windows.Forms.ListView Lv_Listado;
        internal System.Windows.Forms.Label Lbl_Titulo;
        internal System.Windows.Forms.Button Btn_Cerrar;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}