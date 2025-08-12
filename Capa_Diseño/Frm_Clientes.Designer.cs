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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Clientes));
            this.Cmd_Cancelar = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Txt_Negocio = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Cmd_Nuevo = new System.Windows.Forms.Button();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.Cmd_Editar = new System.Windows.Forms.Button();
            this.Cmd_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Cbo_Tipo = new System.Windows.Forms.ComboBox();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.Txt_Filtro = new System.Windows.Forms.TextBox();
            this.Lbl_Contador = new System.Windows.Forms.Label();
            this.Lv_Clientes = new System.Windows.Forms.ListView();
            this.Imagenes = new System.Windows.Forms.ImageList(this.components);
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Chk_Activo = new System.Windows.Forms.CheckBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ep_Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Error)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmd_Cancelar
            // 
            this.Cmd_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cmd_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cmd_Cancelar.Image")));
            this.Cmd_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cmd_Cancelar.Location = new System.Drawing.Point(612, 63);
            this.Cmd_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Cmd_Cancelar.Name = "Cmd_Cancelar";
            this.Cmd_Cancelar.Size = new System.Drawing.Size(171, 37);
            this.Cmd_Cancelar.TabIndex = 98;
            this.Cmd_Cancelar.Text = "Cancelar";
            this.Cmd_Cancelar.UseVisualStyleBackColor = false;
            this.Cmd_Cancelar.Click += new System.EventHandler(this.Cmd_Cancelar_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(109, 138);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 20);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Teléfono:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(17, 69);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(173, 20);
            this.Label7.TabIndex = 33;
            this.Label7.Text = "Nombre del Cliente:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(31, 33);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(167, 20);
            this.Label8.TabIndex = 31;
            this.Label8.Text = "Código del Cliente:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(17, 9);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(213, 23);
            this.Label1.TabIndex = 103;
            this.Label1.Text = "Registro de Clientes:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(705, 138);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(139, 20);
            this.Label5.TabIndex = 39;
            this.Label5.Text = "Tipo de Cliente:";
            // 
            // Txt_Negocio
            // 
            this.Txt_Negocio.BackColor = System.Drawing.Color.White;
            this.Txt_Negocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Negocio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Negocio.Location = new System.Drawing.Point(857, 66);
            this.Txt_Negocio.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Negocio.Name = "Txt_Negocio";
            this.Txt_Negocio.Size = new System.Drawing.Size(464, 25);
            this.Txt_Negocio.TabIndex = 38;
            this.Txt_Negocio.WordWrap = false;
            this.Txt_Negocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Negocio_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(763, 69);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(83, 20);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "Negocio:";
            // 
            // Cmd_Nuevo
            // 
            this.Cmd_Nuevo.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Nuevo.ForeColor = System.Drawing.Color.White;
            this.Cmd_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Cmd_Nuevo.Image")));
            this.Cmd_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cmd_Nuevo.Location = new System.Drawing.Point(23, 63);
            this.Cmd_Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.Cmd_Nuevo.Name = "Cmd_Nuevo";
            this.Cmd_Nuevo.Size = new System.Drawing.Size(171, 37);
            this.Cmd_Nuevo.TabIndex = 96;
            this.Cmd_Nuevo.Text = "Agregar";
            this.Cmd_Nuevo.UseVisualStyleBackColor = false;
            this.Cmd_Nuevo.Click += new System.EventHandler(this.Cmd_Nuevo_Click);
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.BackColor = System.Drawing.Color.White;
            this.Txt_Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Cliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cliente.Location = new System.Drawing.Point(212, 66);
            this.Txt_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Size = new System.Drawing.Size(484, 25);
            this.Txt_Cliente.TabIndex = 34;
            this.Txt_Cliente.WordWrap = false;
            this.Txt_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cliente_KeyPress);
            // 
            // Cmd_Editar
            // 
            this.Cmd_Editar.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Editar.ForeColor = System.Drawing.Color.White;
            this.Cmd_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Cmd_Editar.Image")));
            this.Cmd_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cmd_Editar.Location = new System.Drawing.Point(924, 63);
            this.Cmd_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.Cmd_Editar.Name = "Cmd_Editar";
            this.Cmd_Editar.Size = new System.Drawing.Size(171, 37);
            this.Cmd_Editar.TabIndex = 99;
            this.Cmd_Editar.Text = "Editar";
            this.Cmd_Editar.UseVisualStyleBackColor = false;
            this.Cmd_Editar.Click += new System.EventHandler(this.Cmd_Editar_Click);
            // 
            // Cmd_Guardar
            // 
            this.Cmd_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Guardar.ForeColor = System.Drawing.Color.White;
            this.Cmd_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Cmd_Guardar.Image")));
            this.Cmd_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cmd_Guardar.Location = new System.Drawing.Point(308, 63);
            this.Cmd_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Cmd_Guardar.Name = "Cmd_Guardar";
            this.Cmd_Guardar.Size = new System.Drawing.Size(171, 37);
            this.Cmd_Guardar.TabIndex = 97;
            this.Cmd_Guardar.Text = "Guardar";
            this.Cmd_Guardar.UseVisualStyleBackColor = false;
            this.Cmd_Guardar.Click += new System.EventHandler(this.Cmd_Guardar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Location = new System.Drawing.Point(1207, 63);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(171, 37);
            this.Btn_Cerrar.TabIndex = 100;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Cbo_Tipo
            // 
            this.Cbo_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Tipo.FormattingEnabled = true;
            this.Cbo_Tipo.Items.AddRange(new object[] {
            "NATURAL",
            "JURIDICO"});
            this.Cbo_Tipo.Location = new System.Drawing.Point(857, 133);
            this.Cbo_Tipo.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Tipo.Name = "Cbo_Tipo";
            this.Cbo_Tipo.Size = new System.Drawing.Size(484, 26);
            this.Cbo_Tipo.TabIndex = 47;
            this.Cbo_Tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_Tipo_KeyPress);
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(212, 133);
            this.Txt_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(462, 24);
            this.Txt_Telefono.TabIndex = 46;
            this.Txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Telefono_KeyPress);
            // 
            // Txt_Filtro
            // 
            this.Txt_Filtro.BackColor = System.Drawing.Color.White;
            this.Txt_Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Filtro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Filtro.Location = new System.Drawing.Point(285, 551);
            this.Txt_Filtro.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Filtro.Name = "Txt_Filtro";
            this.Txt_Filtro.Size = new System.Drawing.Size(829, 25);
            this.Txt_Filtro.TabIndex = 44;
            this.Txt_Filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Filtro_KeyPress);
            // 
            // Lbl_Contador
            // 
            this.Lbl_Contador.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_Contador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contador.ForeColor = System.Drawing.Color.White;
            this.Lbl_Contador.Location = new System.Drawing.Point(1129, 553);
            this.Lbl_Contador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Contador.Name = "Lbl_Contador";
            this.Lbl_Contador.Size = new System.Drawing.Size(213, 23);
            this.Lbl_Contador.TabIndex = 43;
            this.Lbl_Contador.Text = "Registro:";
            // 
            // Lv_Clientes
            // 
            this.Lv_Clientes.BackColor = System.Drawing.Color.Thistle;
            this.Lv_Clientes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lv_Clientes.FullRowSelect = true;
            this.Lv_Clientes.GridLines = true;
            this.Lv_Clientes.LabelWrap = false;
            this.Lv_Clientes.Location = new System.Drawing.Point(15, 169);
            this.Lv_Clientes.Margin = new System.Windows.Forms.Padding(4);
            this.Lv_Clientes.MultiSelect = false;
            this.Lv_Clientes.Name = "Lv_Clientes";
            this.Lv_Clientes.ShowGroups = false;
            this.Lv_Clientes.Size = new System.Drawing.Size(1327, 373);
            this.Lv_Clientes.SmallImageList = this.Imagenes;
            this.Lv_Clientes.StateImageList = this.Imagenes;
            this.Lv_Clientes.TabIndex = 42;
            this.Lv_Clientes.UseCompatibleStateImageBehavior = false;
            this.Lv_Clientes.View = System.Windows.Forms.View.Details;
            this.Lv_Clientes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Lv_Clientes_ItemSelectionChanged);
            this.Lv_Clientes.DoubleClick += new System.EventHandler(this.Lv_Clientes_DoubleClick);
            this.Lv_Clientes.ImeModeChanged += new System.EventHandler(this.Lv_Clientes_ImeModeChanged);
            // 
            // Imagenes
            // 
            this.Imagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Imagenes.ImageStream")));
            this.Imagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.Imagenes.Images.SetKeyName(0, "Cerrar.ico");
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.Txt_Direccion);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.Txt_Codigo);
            this.GroupBox1.Controls.Add(this.Cbo_Tipo);
            this.GroupBox1.Controls.Add(this.Txt_Telefono);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Txt_Filtro);
            this.GroupBox1.Controls.Add(this.Lbl_Contador);
            this.GroupBox1.Controls.Add(this.Lv_Clientes);
            this.GroupBox1.Controls.Add(this.Txt_Cliente);
            this.GroupBox1.Controls.Add(this.Chk_Activo);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Txt_Negocio);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(23, 108);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(1355, 590);
            this.GroupBox1.TabIndex = 102;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos Generales de los Clientes:";
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Direccion.Location = new System.Drawing.Point(212, 100);
            this.Txt_Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(1109, 24);
            this.Txt_Direccion.TabIndex = 107;
            this.Txt_Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Direccion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 106;
            this.label2.Text = "Dirección:";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_Codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Codigo.Location = new System.Drawing.Point(212, 32);
            this.Txt_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(161, 25);
            this.Txt_Codigo.TabIndex = 105;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(11, 554);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(253, 20);
            this.Label9.TabIndex = 45;
            this.Label9.Text = "Buscar Cliente por el nombre:";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Chk_Activo
            // 
            this.Chk_Activo.AutoSize = true;
            this.Chk_Activo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Activo.ForeColor = System.Drawing.Color.White;
            this.Chk_Activo.Location = new System.Drawing.Point(393, 32);
            this.Chk_Activo.Margin = new System.Windows.Forms.Padding(4);
            this.Chk_Activo.Name = "Chk_Activo";
            this.Chk_Activo.Size = new System.Drawing.Size(83, 24);
            this.Chk_Activo.TabIndex = 41;
            this.Chk_Activo.Text = "Activo";
            this.Chk_Activo.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(23, 39);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(375, 5);
            this.PictureBox1.TabIndex = 104;
            this.PictureBox1.TabStop = false;
            // 
            // ep_Error
            // 
            this.ep_Error.ContainerControl = this;
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1395, 706);
            this.Controls.Add(this.Cmd_Cancelar);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Cmd_Nuevo);
            this.Controls.Add(this.Cmd_Editar);
            this.Controls.Add(this.Cmd_Guardar);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Clientes";
            this.Text = "Frm_Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Clientes_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Clientes_VisibleChanged);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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