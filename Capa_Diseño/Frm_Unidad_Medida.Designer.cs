namespace Capa_Diseño
{
    partial class Frm_Unidad_Medida : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Unidad_Medida));
            Cmd_Cancelar = new Button();
            Label1 = new Label();
            Cmd_Nuevo = new Button();
            Cmd_Editar = new Button();
            Cmd_Guardar = new Button();
            GroupBox1 = new GroupBox();
            Txt_Codigo = new TextBox();
            Label9 = new Label();
            Txt_Filtro = new TextBox();
            Lbl_Contador = new Label();
            Lv_Datos = new ListView();
            Imagenes = new ImageList(components);
            Txt_Descripcion = new TextBox();
            Chk_Estado = new CheckBox();
            Label7 = new Label();
            Label8 = new Label();
            Btn_Cerrar = new Button();
            PictureBox1 = new PictureBox();
            ep_Error = new ErrorProvider(components);
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep_Error).BeginInit();
            SuspendLayout();
            // 
            // Cmd_Cancelar
            // 
            Cmd_Cancelar.BackColor = Color.IndianRed;
            Cmd_Cancelar.FlatStyle = FlatStyle.Flat;
            Cmd_Cancelar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmd_Cancelar.ForeColor = Color.White;
            Cmd_Cancelar.Image = (Image)resources.GetObject("Cmd_Cancelar.Image");
            Cmd_Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            Cmd_Cancelar.Location = new Point(534, 59);
            Cmd_Cancelar.Margin = new Padding(4);
            Cmd_Cancelar.Name = "Cmd_Cancelar";
            Cmd_Cancelar.Size = new Size(150, 35);
            Cmd_Cancelar.TabIndex = 116;
            Cmd_Cancelar.Text = "Cancelar";
            Cmd_Cancelar.UseVisualStyleBackColor = false;
            Cmd_Cancelar.Click += Cmd_Cancelar_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(15, 8);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(305, 18);
            Label1.TabIndex = 121;
            Label1.Text = "Registro de las Unidades de Medidas:";
            // 
            // Cmd_Nuevo
            // 
            Cmd_Nuevo.BackColor = Color.IndianRed;
            Cmd_Nuevo.FlatStyle = FlatStyle.Flat;
            Cmd_Nuevo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmd_Nuevo.ForeColor = Color.White;
            Cmd_Nuevo.Image = (Image)resources.GetObject("Cmd_Nuevo.Image");
            Cmd_Nuevo.ImageAlign = ContentAlignment.MiddleLeft;
            Cmd_Nuevo.Location = new Point(20, 59);
            Cmd_Nuevo.Margin = new Padding(4);
            Cmd_Nuevo.Name = "Cmd_Nuevo";
            Cmd_Nuevo.Size = new Size(150, 35);
            Cmd_Nuevo.TabIndex = 114;
            Cmd_Nuevo.Text = "Agregar";
            Cmd_Nuevo.UseVisualStyleBackColor = false;
            Cmd_Nuevo.Click += Cmd_Nuevo_Click;
            // 
            // Cmd_Editar
            // 
            Cmd_Editar.BackColor = Color.IndianRed;
            Cmd_Editar.FlatStyle = FlatStyle.Flat;
            Cmd_Editar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmd_Editar.ForeColor = Color.White;
            Cmd_Editar.Image = (Image)resources.GetObject("Cmd_Editar.Image");
            Cmd_Editar.ImageAlign = ContentAlignment.MiddleLeft;
            Cmd_Editar.Location = new Point(797, 59);
            Cmd_Editar.Margin = new Padding(4);
            Cmd_Editar.Name = "Cmd_Editar";
            Cmd_Editar.Size = new Size(150, 35);
            Cmd_Editar.TabIndex = 117;
            Cmd_Editar.Text = "Editar";
            Cmd_Editar.UseVisualStyleBackColor = false;
            Cmd_Editar.Click += Cmd_Editar_Click;
            // 
            // Cmd_Guardar
            // 
            Cmd_Guardar.BackColor = Color.IndianRed;
            Cmd_Guardar.FlatStyle = FlatStyle.Flat;
            Cmd_Guardar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmd_Guardar.ForeColor = Color.White;
            Cmd_Guardar.Image = (Image)resources.GetObject("Cmd_Guardar.Image");
            Cmd_Guardar.ImageAlign = ContentAlignment.MiddleLeft;
            Cmd_Guardar.Location = new Point(274, 59);
            Cmd_Guardar.Margin = new Padding(4);
            Cmd_Guardar.Name = "Cmd_Guardar";
            Cmd_Guardar.Size = new Size(150, 35);
            Cmd_Guardar.TabIndex = 115;
            Cmd_Guardar.Text = "Guardar";
            Cmd_Guardar.UseVisualStyleBackColor = false;
            Cmd_Guardar.Click += Cmd_Guardar_Click;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Transparent;
            GroupBox1.Controls.Add(Txt_Codigo);
            GroupBox1.Controls.Add(Label9);
            GroupBox1.Controls.Add(Txt_Filtro);
            GroupBox1.Controls.Add(Lbl_Contador);
            GroupBox1.Controls.Add(Lv_Datos);
            GroupBox1.Controls.Add(Txt_Descripcion);
            GroupBox1.Controls.Add(Chk_Estado);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Controls.Add(Label8);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox1.ForeColor = Color.White;
            GroupBox1.Location = new Point(20, 101);
            GroupBox1.Margin = new Padding(4);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4);
            GroupBox1.Size = new Size(1186, 553);
            GroupBox1.TabIndex = 120;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Datos Generales de los Clientes:";
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.BackColor = SystemColors.ButtonHighlight;
            Txt_Codigo.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Codigo.Location = new Point(167, 30);
            Txt_Codigo.Margin = new Padding(4);
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(141, 21);
            Txt_Codigo.TabIndex = 105;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = Color.Transparent;
            Label9.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.ForeColor = Color.White;
            Label9.Location = new Point(10, 519);
            Label9.Margin = new Padding(4, 0, 4, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(225, 15);
            Label9.TabIndex = 45;
            Label9.Text = "Buscar Por Código o Descripción:";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Txt_Filtro
            // 
            Txt_Filtro.BackColor = Color.White;
            Txt_Filtro.CharacterCasing = CharacterCasing.Upper;
            Txt_Filtro.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Filtro.Location = new Point(267, 517);
            Txt_Filtro.Margin = new Padding(4);
            Txt_Filtro.Name = "Txt_Filtro";
            Txt_Filtro.Size = new Size(708, 21);
            Txt_Filtro.TabIndex = 44;
            Txt_Filtro.KeyPress += Txt_Filtro_KeyPress;
            // 
            // Lbl_Contador
            // 
            Lbl_Contador.BackColor = Color.Transparent;
            Lbl_Contador.BorderStyle = BorderStyle.FixedSingle;
            Lbl_Contador.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Contador.ForeColor = Color.White;
            Lbl_Contador.Location = new Point(988, 518);
            Lbl_Contador.Margin = new Padding(4, 0, 4, 0);
            Lbl_Contador.Name = "Lbl_Contador";
            Lbl_Contador.Size = new Size(187, 22);
            Lbl_Contador.TabIndex = 43;
            Lbl_Contador.Text = "Registro:";
            // 
            // Lv_Datos
            // 
            Lv_Datos.BackColor = Color.Thistle;
            Lv_Datos.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lv_Datos.ForeColor = Color.FromArgb(0, 0, 64);
            Lv_Datos.FullRowSelect = true;
            Lv_Datos.GridLines = true;
            Lv_Datos.LabelWrap = false;
            Lv_Datos.Location = new Point(13, 92);
            Lv_Datos.Margin = new Padding(4);
            Lv_Datos.MultiSelect = false;
            Lv_Datos.Name = "Lv_Datos";
            Lv_Datos.ShowGroups = false;
            Lv_Datos.Size = new Size(1162, 416);
            Lv_Datos.SmallImageList = Imagenes;
            Lv_Datos.StateImageList = Imagenes;
            Lv_Datos.TabIndex = 42;
            Lv_Datos.UseCompatibleStateImageBehavior = false;
            Lv_Datos.View = View.Details;
            Lv_Datos.ItemSelectionChanged += Lv_Datos_ItemSelectionChanged;
            Lv_Datos.DoubleClick += Lv_Datos_DoubleClick;
            // 
            // Imagenes
            // 
            Imagenes.ColorDepth = ColorDepth.Depth8Bit;
            Imagenes.ImageStream = (ImageListStreamer)resources.GetObject("Imagenes.ImageStream");
            Imagenes.TransparentColor = Color.Transparent;
            Imagenes.Images.SetKeyName(0, "Cerrar.ico");
            // 
            // Txt_Descripcion
            // 
            Txt_Descripcion.BackColor = Color.White;
            Txt_Descripcion.CharacterCasing = CharacterCasing.Upper;
            Txt_Descripcion.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Descripcion.Location = new Point(167, 61);
            Txt_Descripcion.Margin = new Padding(4);
            Txt_Descripcion.Name = "Txt_Descripcion";
            Txt_Descripcion.Size = new Size(985, 21);
            Txt_Descripcion.TabIndex = 34;
            Txt_Descripcion.WordWrap = false;
            Txt_Descripcion.KeyPress += Txt_Descripcion_KeyPress;
            // 
            // Chk_Estado
            // 
            Chk_Estado.AutoSize = true;
            Chk_Estado.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Chk_Estado.ForeColor = Color.White;
            Chk_Estado.Location = new Point(325, 31);
            Chk_Estado.Margin = new Padding(4);
            Chk_Estado.Name = "Chk_Estado";
            Chk_Estado.Size = new Size(71, 19);
            Chk_Estado.TabIndex = 41;
            Chk_Estado.Text = "Estado";
            Chk_Estado.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(55, 64);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(90, 15);
            Label7.TabIndex = 33;
            Label7.Text = "Descripción:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(94, 30);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(57, 15);
            Label8.TabIndex = 31;
            Label8.Text = "Código:";
            // 
            // Btn_Cerrar
            // 
            Btn_Cerrar.BackColor = Color.Brown;
            Btn_Cerrar.FlatStyle = FlatStyle.Flat;
            Btn_Cerrar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Cerrar.ForeColor = Color.White;
            Btn_Cerrar.Image = (Image)resources.GetObject("Btn_Cerrar.Image");
            Btn_Cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Cerrar.Location = new Point(1056, 59);
            Btn_Cerrar.Margin = new Padding(4);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(150, 35);
            Btn_Cerrar.TabIndex = 118;
            Btn_Cerrar.Text = "Cerrar";
            Btn_Cerrar.UseVisualStyleBackColor = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(20, 37);
            PictureBox1.Margin = new Padding(4);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(328, 5);
            PictureBox1.TabIndex = 122;
            PictureBox1.TabStop = false;
            // 
            // ep_Error
            // 
            ep_Error.ContainerControl = this;
            // 
            // Frm_Unidad_Medida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1221, 662);
            Controls.Add(Cmd_Cancelar);
            Controls.Add(Label1);
            Controls.Add(Cmd_Nuevo);
            Controls.Add(Cmd_Editar);
            Controls.Add(Cmd_Guardar);
            Controls.Add(GroupBox1);
            Controls.Add(Btn_Cerrar);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Unidad_Medida";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Frm_Unidad_Medida";
            FormClosing += Frm_Unidad_Medida_FormClosing;
            Load += Frm_Unidad_Medida_Load;
            VisibleChanged += Frm_Unidad_Medida_VisibleChanged;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep_Error).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Cmd_Cancelar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Cmd_Nuevo;
        internal System.Windows.Forms.Button Cmd_Editar;
        internal System.Windows.Forms.Button Cmd_Guardar;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox Txt_Codigo;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox Txt_Filtro;
        internal System.Windows.Forms.Label Lbl_Contador;
        internal System.Windows.Forms.ListView Lv_Datos;
        internal System.Windows.Forms.TextBox Txt_Descripcion;
        internal System.Windows.Forms.CheckBox Chk_Estado;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button Btn_Cerrar;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ImageList Imagenes;
        private System.Windows.Forms.ErrorProvider ep_Error;
    }
}