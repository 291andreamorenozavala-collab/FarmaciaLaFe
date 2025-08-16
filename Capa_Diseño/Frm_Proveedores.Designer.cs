namespace Capa_Diseño
{
    partial class Frm_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedores));
            Txt_Direccion = new TextBox();
            label2 = new Label();
            Txt_Codigo = new TextBox();
            Label9 = new Label();
            Txt_Filtro = new TextBox();
            Lbl_Contador = new Label();
            Lv_Proveedores = new ListView();
            Imagenes = new ImageList(components);
            Chk_Activo = new CheckBox();
            Cmd_Cancelar = new Button();
            Cmd_Nuevo = new Button();
            Cmd_Editar = new Button();
            Btn_Cerrar = new Button();
            Txt_Telefonos = new TextBox();
            Label4 = new Label();
            Label1 = new Label();
            Label8 = new Label();
            GroupBox1 = new GroupBox();
            Txt_Proveedor = new TextBox();
            Label7 = new Label();
            PictureBox1 = new PictureBox();
            Cmd_Guardar = new Button();
            ep_Error = new ErrorProvider(components);
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep_Error).BeginInit();
            SuspendLayout();
            // 
            // Txt_Direccion
            // 
            Txt_Direccion.CharacterCasing = CharacterCasing.Upper;
            Txt_Direccion.Location = new Point(200, 94);
            Txt_Direccion.Margin = new Padding(4);
            Txt_Direccion.Name = "Txt_Direccion";
            Txt_Direccion.Size = new Size(974, 21);
            Txt_Direccion.TabIndex = 107;
            Txt_Direccion.KeyPress += Txt_Direccion_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(106, 98);
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
            Txt_Codigo.Location = new Point(200, 31);
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
            // Lv_Proveedores
            // 
            Lv_Proveedores.BackColor = Color.Thistle;
            Lv_Proveedores.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lv_Proveedores.ForeColor = Color.FromArgb(0, 0, 64);
            Lv_Proveedores.FullRowSelect = true;
            Lv_Proveedores.GridLines = true;
            Lv_Proveedores.LabelWrap = false;
            Lv_Proveedores.Location = new Point(13, 125);
            Lv_Proveedores.Margin = new Padding(4);
            Lv_Proveedores.MultiSelect = false;
            Lv_Proveedores.Name = "Lv_Proveedores";
            Lv_Proveedores.ShowGroups = false;
            Lv_Proveedores.Size = new Size(1162, 384);
            Lv_Proveedores.SmallImageList = Imagenes;
            Lv_Proveedores.StateImageList = Imagenes;
            Lv_Proveedores.TabIndex = 42;
            Lv_Proveedores.UseCompatibleStateImageBehavior = false;
            Lv_Proveedores.View = View.Details;
            Lv_Proveedores.ItemSelectionChanged += Lv_Proveedores_ItemSelectionChanged;
            Lv_Proveedores.DoubleClick += Lv_Proveedores_DoubleClick;
            // 
            // Imagenes
            // 
            Imagenes.ColorDepth = ColorDepth.Depth8Bit;
            Imagenes.ImageStream = (ImageListStreamer)resources.GetObject("Imagenes.ImageStream");
            Imagenes.TransparentColor = Color.Transparent;
            Imagenes.Images.SetKeyName(0, "Cerrar.ico");
            // 
            // Chk_Activo
            // 
            Chk_Activo.AutoSize = true;
            Chk_Activo.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Chk_Activo.ForeColor = Color.White;
            Chk_Activo.Location = new Point(360, 31);
            Chk_Activo.Margin = new Padding(4);
            Chk_Activo.Name = "Chk_Activo";
            Chk_Activo.Size = new Size(67, 19);
            Chk_Activo.TabIndex = 41;
            Chk_Activo.Text = "Activo";
            Chk_Activo.UseVisualStyleBackColor = true;
            // 
            // Cmd_Cancelar
            // 
            Cmd_Cancelar.BackColor = Color.IndianRed;
            Cmd_Cancelar.FlatStyle = FlatStyle.Flat;
            Cmd_Cancelar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmd_Cancelar.ForeColor = Color.White;
            Cmd_Cancelar.Image = (Image)resources.GetObject("Cmd_Cancelar.Image");
            Cmd_Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            Cmd_Cancelar.Location = new Point(531, 59);
            Cmd_Cancelar.Margin = new Padding(4);
            Cmd_Cancelar.Name = "Cmd_Cancelar";
            Cmd_Cancelar.Size = new Size(150, 35);
            Cmd_Cancelar.TabIndex = 107;
            Cmd_Cancelar.Text = "Cancelar";
            Cmd_Cancelar.UseVisualStyleBackColor = false;
            Cmd_Cancelar.Click += Cmd_Cancelar_Click;
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
            Cmd_Nuevo.TabIndex = 105;
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
            Cmd_Editar.TabIndex = 108;
            Cmd_Editar.Text = "Editar";
            Cmd_Editar.UseVisualStyleBackColor = false;
            Cmd_Editar.Click += Cmd_Editar_Click;
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
            Btn_Cerrar.TabIndex = 109;
            Btn_Cerrar.Text = "Cerrar";
            Btn_Cerrar.UseVisualStyleBackColor = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // Txt_Telefonos
            // 
            Txt_Telefonos.BackColor = Color.White;
            Txt_Telefonos.CharacterCasing = CharacterCasing.Upper;
            Txt_Telefonos.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Telefonos.Location = new Point(750, 62);
            Txt_Telefonos.Margin = new Padding(4);
            Txt_Telefonos.Name = "Txt_Telefonos";
            Txt_Telefonos.Size = new Size(424, 21);
            Txt_Telefonos.TabIndex = 38;
            Txt_Telefonos.WordWrap = false;
            Txt_Telefonos.KeyPress += Txt_Telefonos_KeyPress;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(668, 65);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(67, 15);
            Label4.TabIndex = 37;
            Label4.Text = "Teléfono:";
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
            Label1.Size = new Size(212, 18);
            Label1.TabIndex = 112;
            Label1.Text = "Registro de Proveedores:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(18, 34);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(151, 15);
            Label8.TabIndex = 31;
            Label8.Text = "Código del Proveedor:";
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Transparent;
            GroupBox1.Controls.Add(Txt_Direccion);
            GroupBox1.Controls.Add(label2);
            GroupBox1.Controls.Add(Txt_Codigo);
            GroupBox1.Controls.Add(Label9);
            GroupBox1.Controls.Add(Txt_Filtro);
            GroupBox1.Controls.Add(Lbl_Contador);
            GroupBox1.Controls.Add(Lv_Proveedores);
            GroupBox1.Controls.Add(Txt_Proveedor);
            GroupBox1.Controls.Add(Chk_Activo);
            GroupBox1.Controls.Add(Txt_Telefonos);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Controls.Add(Label8);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox1.ForeColor = Color.White;
            GroupBox1.Location = new Point(20, 101);
            GroupBox1.Margin = new Padding(4);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4);
            GroupBox1.Size = new Size(1186, 553);
            GroupBox1.TabIndex = 111;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Datos Generales de los Proveedore:";
            // 
            // Txt_Proveedor
            // 
            Txt_Proveedor.BackColor = Color.White;
            Txt_Proveedor.CharacterCasing = CharacterCasing.Upper;
            Txt_Proveedor.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Proveedor.Location = new Point(200, 62);
            Txt_Proveedor.Margin = new Padding(4);
            Txt_Proveedor.Name = "Txt_Proveedor";
            Txt_Proveedor.Size = new Size(424, 21);
            Txt_Proveedor.TabIndex = 34;
            Txt_Proveedor.WordWrap = false;
            Txt_Proveedor.KeyPress += Txt_Proveedor_KeyPress;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(10, 65);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(157, 15);
            Label7.TabIndex = 33;
            Label7.Text = "Nombre del Proveedor:";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(20, 37);
            PictureBox1.Margin = new Padding(4);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(328, 5);
            PictureBox1.TabIndex = 113;
            PictureBox1.TabStop = false;
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
            Cmd_Guardar.TabIndex = 106;
            Cmd_Guardar.Text = "Guardar";
            Cmd_Guardar.UseVisualStyleBackColor = false;
            Cmd_Guardar.Click += Cmd_Guardar_Click;
            // 
            // ep_Error
            // 
            ep_Error.ContainerControl = this;
            // 
            // Frm_Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1221, 662);
            Controls.Add(Cmd_Cancelar);
            Controls.Add(Cmd_Nuevo);
            Controls.Add(Cmd_Editar);
            Controls.Add(Btn_Cerrar);
            Controls.Add(Label1);
            Controls.Add(GroupBox1);
            Controls.Add(PictureBox1);
            Controls.Add(Cmd_Guardar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Frm_Proveedores";
            Text = "Frm_Proveedores";
            FormClosing += Frm_Proveedores_FormClosing;
            Load += Frm_Proveedores_Load;
            VisibleChanged += Frm_Proveedores_VisibleChanged;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep_Error).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox Txt_Direccion;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox Txt_Codigo;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox Txt_Filtro;
        internal System.Windows.Forms.Label Lbl_Contador;
        internal System.Windows.Forms.ListView Lv_Proveedores;
        internal System.Windows.Forms.CheckBox Chk_Activo;
        internal System.Windows.Forms.Button Cmd_Cancelar;
        internal System.Windows.Forms.Button Cmd_Nuevo;
        internal System.Windows.Forms.Button Cmd_Editar;
        internal System.Windows.Forms.Button Btn_Cerrar;
        internal System.Windows.Forms.TextBox Txt_Telefonos;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox Txt_Proveedor;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button Cmd_Guardar;
        private System.Windows.Forms.ImageList Imagenes;
        private System.Windows.Forms.ErrorProvider ep_Error;
    }
}