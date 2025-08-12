namespace Capa_Diseño
{
    partial class Frm_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios));
            this.Cmd_Cancelar = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Txt_Filtro = new System.Windows.Forms.TextBox();
            this.Lbl_Contador = new System.Windows.Forms.Label();
            this.Lv_Usuarios = new System.Windows.Forms.ListView();
            this.Label1 = new System.Windows.Forms.Label();
            this.Cbo_Tipo = new System.Windows.Forms.ComboBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Chk_Activo = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Cmd_Nuevo = new System.Windows.Forms.Button();
            this.Cmd_Editar = new System.Windows.Forms.Button();
            this.Cmd_Guardar = new System.Windows.Forms.Button();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Imagenes = new System.Windows.Forms.ImageList(this.components);
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
            this.Cmd_Cancelar.Location = new System.Drawing.Point(608, 63);
            this.Cmd_Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmd_Cancelar.Name = "Cmd_Cancelar";
            this.Cmd_Cancelar.Size = new System.Drawing.Size(171, 37);
            this.Cmd_Cancelar.TabIndex = 89;
            this.Cmd_Cancelar.Text = "Cancelar";
            this.Cmd_Cancelar.UseVisualStyleBackColor = false;
            this.Cmd_Cancelar.Click += new System.EventHandler(this.Cmd_Cancelar_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(11, 559);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(239, 20);
            this.Label9.TabIndex = 45;
            this.Label9.Text = "Buscar Usuario por nombre:";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Filtro
            // 
            this.Txt_Filtro.BackColor = System.Drawing.Color.White;
            this.Txt_Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Filtro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Filtro.Location = new System.Drawing.Point(271, 556);
            this.Txt_Filtro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Filtro.Name = "Txt_Filtro";
            this.Txt_Filtro.Size = new System.Drawing.Size(844, 25);
            this.Txt_Filtro.TabIndex = 44;
            this.Txt_Filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Filtro_KeyPress);
            // 
            // Lbl_Contador
            // 
            this.Lbl_Contador.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_Contador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contador.ForeColor = System.Drawing.Color.White;
            this.Lbl_Contador.Location = new System.Drawing.Point(1129, 558);
            this.Lbl_Contador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Contador.Name = "Lbl_Contador";
            this.Lbl_Contador.Size = new System.Drawing.Size(213, 23);
            this.Lbl_Contador.TabIndex = 43;
            this.Lbl_Contador.Text = "Registro:";
            // 
            // Lv_Usuarios
            // 
            this.Lv_Usuarios.BackColor = System.Drawing.Color.Thistle;
            this.Lv_Usuarios.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Usuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lv_Usuarios.FullRowSelect = true;
            this.Lv_Usuarios.GridLines = true;
            this.Lv_Usuarios.LabelWrap = false;
            this.Lv_Usuarios.Location = new System.Drawing.Point(15, 140);
            this.Lv_Usuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lv_Usuarios.MultiSelect = false;
            this.Lv_Usuarios.Name = "Lv_Usuarios";
            this.Lv_Usuarios.ShowGroups = false;
            this.Lv_Usuarios.Size = new System.Drawing.Size(1327, 402);
            this.Lv_Usuarios.TabIndex = 42;
            this.Lv_Usuarios.UseCompatibleStateImageBehavior = false;
            this.Lv_Usuarios.View = System.Windows.Forms.View.Details;
            this.Lv_Usuarios.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Lv_Usuarios_ItemSelectionChanged);
            this.Lv_Usuarios.DoubleClick += new System.EventHandler(this.Lv_Usuarios_DoubleClick);
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
            this.Label1.Size = new System.Drawing.Size(221, 23);
            this.Label1.TabIndex = 94;
            this.Label1.Text = "Registro de Usuarios:";
            // 
            // Cbo_Tipo
            // 
            this.Cbo_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Tipo.FormattingEnabled = true;
            this.Cbo_Tipo.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "GRABADOR",
            "CONSULTOR"});
            this.Cbo_Tipo.Location = new System.Drawing.Point(857, 100);
            this.Cbo_Tipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_Tipo.Name = "Cbo_Tipo";
            this.Cbo_Tipo.Size = new System.Drawing.Size(484, 26);
            this.Cbo_Tipo.TabIndex = 47;
            this.Cbo_Tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_Tipo_KeyPress);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Usuario.Location = new System.Drawing.Point(212, 100);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(484, 24);
            this.Txt_Usuario.TabIndex = 46;
            this.Txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Usuario_KeyPress);
            // 
            // Txt_Login
            // 
            this.Txt_Login.BackColor = System.Drawing.Color.White;
            this.Txt_Login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Login.Location = new System.Drawing.Point(212, 66);
            this.Txt_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(484, 25);
            this.Txt_Login.TabIndex = 34;
            this.Txt_Login.WordWrap = false;
            this.Txt_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Login_KeyPress);
            // 
            // Chk_Activo
            // 
            this.Chk_Activo.AutoSize = true;
            this.Chk_Activo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Activo.ForeColor = System.Drawing.Color.White;
            this.Chk_Activo.Location = new System.Drawing.Point(321, 32);
            this.Chk_Activo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Chk_Activo.Name = "Chk_Activo";
            this.Chk_Activo.Size = new System.Drawing.Size(83, 24);
            this.Chk_Activo.TabIndex = 41;
            this.Chk_Activo.Text = "Activo";
            this.Chk_Activo.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(700, 105);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(144, 20);
            this.Label5.TabIndex = 39;
            this.Label5.Text = "Tipo de Usuario:";
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
            this.Cmd_Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmd_Nuevo.Name = "Cmd_Nuevo";
            this.Cmd_Nuevo.Size = new System.Drawing.Size(171, 37);
            this.Cmd_Nuevo.TabIndex = 87;
            this.Cmd_Nuevo.Text = "Agregar";
            this.Cmd_Nuevo.UseVisualStyleBackColor = false;
            this.Cmd_Nuevo.Click += new System.EventHandler(this.Cmd_Nuevo_Click);
            // 
            // Cmd_Editar
            // 
            this.Cmd_Editar.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Editar.ForeColor = System.Drawing.Color.White;
            this.Cmd_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Cmd_Editar.Image")));
            this.Cmd_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cmd_Editar.Location = new System.Drawing.Point(909, 63);
            this.Cmd_Editar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmd_Editar.Name = "Cmd_Editar";
            this.Cmd_Editar.Size = new System.Drawing.Size(171, 37);
            this.Cmd_Editar.TabIndex = 90;
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
            this.Cmd_Guardar.Location = new System.Drawing.Point(315, 63);
            this.Cmd_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmd_Guardar.Name = "Cmd_Guardar";
            this.Cmd_Guardar.Size = new System.Drawing.Size(171, 37);
            this.Cmd_Guardar.TabIndex = 88;
            this.Cmd_Guardar.Text = "Guardar";
            this.Cmd_Guardar.UseVisualStyleBackColor = false;
            this.Cmd_Guardar.Click += new System.EventHandler(this.Cmd_Guardar_Click);
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.Color.White;
            this.Txt_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(857, 66);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(484, 25);
            this.Txt_Password.TabIndex = 38;
            this.Txt_Password.WordWrap = false;
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(733, 69);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(109, 20);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "Contraseña:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(17, 105);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(178, 20);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Nombre del Usuario:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(121, 69);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(78, 20);
            this.Label7.TabIndex = 33;
            this.Label7.Text = "Usuario:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(96, 33);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(103, 20);
            this.Label8.TabIndex = 31;
            this.Label8.Text = "Id. Usuario:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.Cbo_Tipo);
            this.GroupBox1.Controls.Add(this.Txt_Usuario);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Txt_Filtro);
            this.GroupBox1.Controls.Add(this.Lbl_Contador);
            this.GroupBox1.Controls.Add(this.Lv_Usuarios);
            this.GroupBox1.Controls.Add(this.Txt_Login);
            this.GroupBox1.Controls.Add(this.Chk_Activo);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Txt_Password);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Txt_Codigo);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(23, 108);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(1355, 590);
            this.GroupBox1.TabIndex = 93;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos Generales de los Usuarios:";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_Codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Codigo.Location = new System.Drawing.Point(212, 33);
            this.Txt_Codigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(91, 25);
            this.Txt_Codigo.TabIndex = 32;
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
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(171, 37);
            this.Btn_Cerrar.TabIndex = 91;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(23, 39);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(375, 5);
            this.PictureBox1.TabIndex = 95;
            this.PictureBox1.TabStop = false;
            // 
            // Imagenes
            // 
            this.Imagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Imagenes.ImageStream")));
            this.Imagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.Imagenes.Images.SetKeyName(0, "Cerrar.ico");
            // 
            // ep_Error
            // 
            this.ep_Error.ContainerControl = this;
            // 
            // Frm_Usuarios
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
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Usuarios";
            this.Text = "Frm_Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Usuarios_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Usuarios_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Usuarios_VisibleChanged);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Cmd_Cancelar;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox Txt_Filtro;
        internal System.Windows.Forms.Label Lbl_Contador;
        internal System.Windows.Forms.ListView Lv_Usuarios;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox Cbo_Tipo;
        internal System.Windows.Forms.TextBox Txt_Usuario;
        internal System.Windows.Forms.TextBox Txt_Login;
        internal System.Windows.Forms.CheckBox Chk_Activo;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button Cmd_Nuevo;
        internal System.Windows.Forms.Button Cmd_Editar;
        internal System.Windows.Forms.Button Cmd_Guardar;
        internal System.Windows.Forms.TextBox Txt_Password;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox Txt_Codigo;
        internal System.Windows.Forms.Button Btn_Cerrar;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ImageList Imagenes;
        private System.Windows.Forms.ErrorProvider ep_Error;
    }
}