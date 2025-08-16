namespace Capa_Diseño
{
    partial class Frm_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Clientes));
            Cmd_Cancelar = new Button();
            Label3 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label1 = new Label();
            Label5 = new Label();
            Txt_Negocio = new TextBox();
            Label4 = new Label();
            Cmd_Nuevo = new Button();
            Txt_Cliente = new TextBox();
            Cmd_Editar = new Button();
            Cmd_Guardar = new Button();
            Btn_Cerrar = new Button();
            Cbo_Tipo = new ComboBox();
            Txt_Telefono = new TextBox();
            Txt_Filtro = new TextBox();
            Lbl_Contador = new Label();
            Lv_Clientes = new ListView();
            Imagenes = new ImageList(components);
            GroupBox1 = new GroupBox();
            Txt_Direccion = new TextBox();
            label2 = new Label();
            Txt_Codigo = new TextBox();
            Label9 = new Label();
            Chk_Activo = new CheckBox();
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
            Cmd_Cancelar.Location = new Point(536, 59);
            Cmd_Cancelar.Margin = new Padding(4);
            Cmd_Cancelar.Name = "Cmd_Cancelar";
            Cmd_Cancelar.Size = new Size(150, 35);
            Cmd_Cancelar.TabIndex = 98;
            Cmd_Cancelar.Text = "Cancelar";
            Cmd_Cancelar.UseVisualStyleBackColor = false;
            Cmd_Cancelar.Click += Cmd_Cancelar_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(95, 129);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(67, 15);
            Label3.TabIndex = 35;
            Label3.Text = "Teléfono:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(15, 65);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(136, 15);
            Label7.TabIndex = 33;
            Label7.Text = "Nombre del Cliente:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(27, 31);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(130, 15);
            Label8.TabIndex = 31;
            Label8.Text = "Código del Cliente:";
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
            Label1.Size = new Size(174, 18);
            Label1.TabIndex = 103;
            Label1.Text = "Registro de Clientes:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(617, 129);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(108, 15);
            Label5.TabIndex = 39;
            Label5.Text = "Tipo de Cliente:";
            // 
            // Txt_Negocio
            // 
            Txt_Negocio.BackColor = Color.White;
            Txt_Negocio.CharacterCasing = CharacterCasing.Upper;
            Txt_Negocio.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Negocio.Location = new Point(750, 62);
            Txt_Negocio.Margin = new Padding(4);
            Txt_Negocio.Name = "Txt_Negocio";
            Txt_Negocio.Size = new Size(406, 21);
            Txt_Negocio.TabIndex = 38;
            Txt_Negocio.WordWrap = false;
            Txt_Negocio.KeyPress += Txt_Negocio_KeyPress;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(668, 65);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(65, 15);
            Label4.TabIndex = 37;
            Label4.Text = "Negocio:";
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
            Cmd_Nuevo.TabIndex = 96;
            Cmd_Nuevo.Text = "Agregar";
            Cmd_Nuevo.UseVisualStyleBackColor = false;
            Cmd_Nuevo.Click += Cmd_Nuevo_Click;
            // 
            // Txt_Cliente
            // 
            Txt_Cliente.BackColor = Color.White;
            Txt_Cliente.CharacterCasing = CharacterCasing.Upper;
            Txt_Cliente.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Cliente.Location = new Point(186, 62);
            Txt_Cliente.Margin = new Padding(4);
            Txt_Cliente.Name = "Txt_Cliente";
            Txt_Cliente.Size = new Size(424, 21);
            Txt_Cliente.TabIndex = 34;
            Txt_Cliente.WordWrap = false;
            Txt_Cliente.KeyPress += Txt_Cliente_KeyPress;
            // 
            // Cmd_Editar
            // 
            Cmd_Editar.BackColor = Color.IndianRed;
            Cmd_Editar.FlatStyle = FlatStyle.Flat;
            Cmd_Editar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmd_Editar.ForeColor = Color.White;
            Cmd_Editar.Image = (Image)resources.GetObject("Cmd_Editar.Image");
            Cmd_Editar.ImageAlign = ContentAlignment.MiddleLeft;
            Cmd_Editar.Location = new Point(808, 59);
            Cmd_Editar.Margin = new Padding(4);
            Cmd_Editar.Name = "Cmd_Editar";
            Cmd_Editar.Size = new Size(150, 35);
            Cmd_Editar.TabIndex = 99;
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
            Cmd_Guardar.Location = new Point(270, 59);
            Cmd_Guardar.Margin = new Padding(4);
            Cmd_Guardar.Name = "Cmd_Guardar";
            Cmd_Guardar.Size = new Size(150, 35);
            Cmd_Guardar.TabIndex = 97;
            Cmd_Guardar.Text = "Guardar";
            Cmd_Guardar.UseVisualStyleBackColor = false;
            Cmd_Guardar.Click += Cmd_Guardar_Click;
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
            Btn_Cerrar.TabIndex = 100;
            Btn_Cerrar.Text = "Cerrar";
            Btn_Cerrar.UseVisualStyleBackColor = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // Cbo_Tipo
            // 
            Cbo_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Tipo.FormattingEnabled = true;
            Cbo_Tipo.Items.AddRange(new object[] { "NATURAL", "JURIDICO" });
            Cbo_Tipo.Location = new Point(750, 125);
            Cbo_Tipo.Margin = new Padding(4);
            Cbo_Tipo.Name = "Cbo_Tipo";
            Cbo_Tipo.Size = new Size(424, 23);
            Cbo_Tipo.TabIndex = 47;
            Cbo_Tipo.KeyPress += Cbo_Tipo_KeyPress;
            // 
            // Txt_Telefono
            // 
            Txt_Telefono.Location = new Point(186, 125);
            Txt_Telefono.Margin = new Padding(4);
            Txt_Telefono.Name = "Txt_Telefono";
            Txt_Telefono.Size = new Size(405, 21);
            Txt_Telefono.TabIndex = 46;
            Txt_Telefono.KeyPress += Txt_Telefono_KeyPress;
            // 
            // Txt_Filtro
            // 
            Txt_Filtro.BackColor = Color.White;
            Txt_Filtro.CharacterCasing = CharacterCasing.Upper;
            Txt_Filtro.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Filtro.Location = new Point(249, 517);
            Txt_Filtro.Margin = new Padding(4);
            Txt_Filtro.Name = "Txt_Filtro";
            Txt_Filtro.Size = new Size(726, 21);
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
            // Lv_Clientes
            // 
            Lv_Clientes.BackColor = Color.Thistle;
            Lv_Clientes.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lv_Clientes.ForeColor = Color.FromArgb(0, 0, 64);
            Lv_Clientes.FullRowSelect = true;
            Lv_Clientes.GridLines = true;
            Lv_Clientes.LabelWrap = false;
            Lv_Clientes.Location = new Point(13, 158);
            Lv_Clientes.Margin = new Padding(4);
            Lv_Clientes.MultiSelect = false;
            Lv_Clientes.Name = "Lv_Clientes";
            Lv_Clientes.ShowGroups = false;
            Lv_Clientes.Size = new Size(1162, 350);
            Lv_Clientes.SmallImageList = Imagenes;
            Lv_Clientes.StateImageList = Imagenes;
            Lv_Clientes.TabIndex = 42;
            Lv_Clientes.UseCompatibleStateImageBehavior = false;
            Lv_Clientes.View = View.Details;
            Lv_Clientes.ItemSelectionChanged += Lv_Clientes_ItemSelectionChanged;
            Lv_Clientes.DoubleClick += Lv_Clientes_DoubleClick;
            Lv_Clientes.ImeModeChanged += Lv_Clientes_ImeModeChanged;
            // 
            // Imagenes
            // 
            Imagenes.ColorDepth = ColorDepth.Depth8Bit;
            Imagenes.ImageStream = (ImageListStreamer)resources.GetObject("Imagenes.ImageStream");
            Imagenes.TransparentColor = Color.Transparent;
            Imagenes.Images.SetKeyName(0, "Cerrar.ico");
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Transparent;
            GroupBox1.Controls.Add(Txt_Direccion);
            GroupBox1.Controls.Add(label2);
            GroupBox1.Controls.Add(Txt_Codigo);
            GroupBox1.Controls.Add(Cbo_Tipo);
            GroupBox1.Controls.Add(Txt_Telefono);
            GroupBox1.Controls.Add(Label9);
            GroupBox1.Controls.Add(Txt_Filtro);
            GroupBox1.Controls.Add(Lbl_Contador);
            GroupBox1.Controls.Add(Lv_Clientes);
            GroupBox1.Controls.Add(Txt_Cliente);
            GroupBox1.Controls.Add(Chk_Activo);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(Txt_Negocio);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Controls.Add(Label8);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox1.ForeColor = Color.White;
            GroupBox1.Location = new Point(20, 101);
            GroupBox1.Margin = new Padding(4);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4);
            GroupBox1.Size = new Size(1186, 553);
            GroupBox1.TabIndex = 102;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Datos Generales de los Clientes:";
            // 
            // Txt_Direccion
            // 
            Txt_Direccion.CharacterCasing = CharacterCasing.Upper;
            Txt_Direccion.Location = new Point(186, 94);
            Txt_Direccion.Margin = new Padding(4);
            Txt_Direccion.Name = "Txt_Direccion";
            Txt_Direccion.Size = new Size(971, 21);
            Txt_Direccion.TabIndex = 107;
            Txt_Direccion.KeyPress += Txt_Direccion_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(87, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 106;
            label2.Text = "Dirección:";
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.BackColor = SystemColors.ButtonHighlight;
            Txt_Codigo.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Codigo.Location = new Point(186, 30);
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
            Label9.Size = new Size(200, 15);
            Label9.TabIndex = 45;
            Label9.Text = "Buscar Cliente por el nombre:";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Chk_Activo
            // 
            Chk_Activo.AutoSize = true;
            Chk_Activo.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Chk_Activo.ForeColor = Color.White;
            Chk_Activo.Location = new Point(344, 30);
            Chk_Activo.Margin = new Padding(4);
            Chk_Activo.Name = "Chk_Activo";
            Chk_Activo.Size = new Size(67, 19);
            Chk_Activo.TabIndex = 41;
            Chk_Activo.Text = "Activo";
            Chk_Activo.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(20, 37);
            PictureBox1.Margin = new Padding(4);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(328, 5);
            PictureBox1.TabIndex = 104;
            PictureBox1.TabStop = false;
            // 
            // ep_Error
            // 
            ep_Error.ContainerControl = this;
            // 
            // Frm_Clientes
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
            Controls.Add(Btn_Cerrar);
            Controls.Add(GroupBox1);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Frm_Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Clientes";
            FormClosing += Frm_Clientes_FormClosing;
            Load += Frm_Clientes_Load;
            VisibleChanged += Frm_Clientes_VisibleChanged;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep_Error).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Cmd_Cancelar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Txt_Negocio;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button Cmd_Nuevo;
        internal System.Windows.Forms.TextBox Txt_Cliente;
        internal System.Windows.Forms.Button Cmd_Editar;
        internal System.Windows.Forms.Button Cmd_Guardar;
        internal System.Windows.Forms.Button Btn_Cerrar;
        internal System.Windows.Forms.ComboBox Cbo_Tipo;
        internal System.Windows.Forms.TextBox Txt_Telefono;
        internal System.Windows.Forms.TextBox Txt_Filtro;
        internal System.Windows.Forms.Label Lbl_Contador;
        internal System.Windows.Forms.ListView Lv_Clientes;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.CheckBox Chk_Activo;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox Txt_Direccion;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.ImageList Imagenes;
        private System.Windows.Forms.ErrorProvider ep_Error;
    }
}