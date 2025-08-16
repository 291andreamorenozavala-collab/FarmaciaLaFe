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
            Opt_2 = new RadioButton();
            Opt_1 = new RadioButton();
            Label2 = new Label();
            Txt_Filtro = new TextBox();
            Lbl_Contador = new Label();
            Lv_Listado = new ListView();
            Lbl_Titulo = new Label();
            Btn_Cerrar = new Button();
            PictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Opt_2
            // 
            Opt_2.AutoSize = true;
            Opt_2.BackColor = Color.Transparent;
            Opt_2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Opt_2.ForeColor = Color.White;
            Opt_2.Location = new Point(424, 54);
            Opt_2.Margin = new Padding(4, 3, 4, 3);
            Opt_2.Name = "Opt_2";
            Opt_2.Size = new Size(111, 23);
            Opt_2.TabIndex = 138;
            Opt_2.TabStop = true;
            Opt_2.Text = "Alternativa 2";
            Opt_2.UseVisualStyleBackColor = false;
            // 
            // Opt_1
            // 
            Opt_1.AutoSize = true;
            Opt_1.BackColor = Color.Transparent;
            Opt_1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Opt_1.ForeColor = Color.White;
            Opt_1.Location = new Point(152, 54);
            Opt_1.Margin = new Padding(4, 3, 4, 3);
            Opt_1.Name = "Opt_1";
            Opt_1.Size = new Size(111, 23);
            Opt_1.TabIndex = 137;
            Opt_1.TabStop = true;
            Opt_1.Text = "Alternativa 1";
            Opt_1.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(15, 57);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(82, 19);
            Label2.TabIndex = 136;
            Label2.Text = "Buscar por:";
            // 
            // Txt_Filtro
            // 
            Txt_Filtro.BackColor = Color.White;
            Txt_Filtro.CharacterCasing = CharacterCasing.Upper;
            Txt_Filtro.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Filtro.Location = new Point(14, 92);
            Txt_Filtro.Margin = new Padding(4, 3, 4, 3);
            Txt_Filtro.Name = "Txt_Filtro";
            Txt_Filtro.Size = new Size(1007, 21);
            Txt_Filtro.TabIndex = 135;
            // 
            // Lbl_Contador
            // 
            Lbl_Contador.BackColor = Color.Transparent;
            Lbl_Contador.BorderStyle = BorderStyle.FixedSingle;
            Lbl_Contador.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Contador.ForeColor = Color.White;
            Lbl_Contador.Location = new Point(1029, 92);
            Lbl_Contador.Margin = new Padding(4, 0, 4, 0);
            Lbl_Contador.Name = "Lbl_Contador";
            Lbl_Contador.Size = new Size(178, 22);
            Lbl_Contador.TabIndex = 134;
            Lbl_Contador.Text = "Registro:";
            // 
            // Lv_Listado
            // 
            Lv_Listado.BackColor = Color.LightGray;
            Lv_Listado.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lv_Listado.ForeColor = Color.FromArgb(0, 0, 64);
            Lv_Listado.FullRowSelect = true;
            Lv_Listado.GridLines = true;
            Lv_Listado.LabelWrap = false;
            Lv_Listado.Location = new Point(14, 123);
            Lv_Listado.Margin = new Padding(4, 3, 4, 3);
            Lv_Listado.MultiSelect = false;
            Lv_Listado.Name = "Lv_Listado";
            Lv_Listado.ShowGroups = false;
            Lv_Listado.Size = new Size(1193, 530);
            Lv_Listado.TabIndex = 133;
            Lv_Listado.UseCompatibleStateImageBehavior = false;
            Lv_Listado.View = View.Details;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.BackColor = Color.Transparent;
            Lbl_Titulo.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Titulo.ForeColor = Color.White;
            Lbl_Titulo.Location = new Point(15, 5);
            Lbl_Titulo.Margin = new Padding(4, 0, 4, 0);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(249, 22);
            Lbl_Titulo.TabIndex = 132;
            Lbl_Titulo.Text = "Información de Busqueda:";
            // 
            // Btn_Cerrar
            // 
            Btn_Cerrar.BackColor = Color.Transparent;
            Btn_Cerrar.FlatAppearance.BorderSize = 0;
            Btn_Cerrar.FlatStyle = FlatStyle.Flat;
            Btn_Cerrar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Cerrar.ForeColor = Color.White;
            Btn_Cerrar.Image = (Image)resources.GetObject("Btn_Cerrar.Image");
            Btn_Cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Cerrar.Location = new Point(1127, 5);
            Btn_Cerrar.Margin = new Padding(4, 3, 4, 3);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(79, 35);
            Btn_Cerrar.TabIndex = 131;
            Btn_Cerrar.Text = "Cerrar";
            Btn_Cerrar.TextAlign = ContentAlignment.MiddleRight;
            Btn_Cerrar.UseVisualStyleBackColor = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(20, 33);
            PictureBox1.Margin = new Padding(4, 3, 4, 3);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(328, 5);
            PictureBox1.TabIndex = 139;
            PictureBox1.TabStop = false;
            // 
            // Frm_Busqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1220, 662);
            Controls.Add(PictureBox1);
            Controls.Add(Opt_2);
            Controls.Add(Opt_1);
            Controls.Add(Label2);
            Controls.Add(Txt_Filtro);
            Controls.Add(Lbl_Contador);
            Controls.Add(Lv_Listado);
            Controls.Add(Lbl_Titulo);
            Controls.Add(Btn_Cerrar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_Busqueda";
            Text = "Frm_Busqueda";
            Load += Frm_Busqueda_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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