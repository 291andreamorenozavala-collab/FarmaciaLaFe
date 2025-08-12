namespace Capa_Diseño
{
    partial class Frm_Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Entrada));
            this.Cmd_Cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_IdEntrada = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Cmd_Nuevo = new System.Windows.Forms.Button();
            this.Cmd_Consultar = new System.Windows.Forms.Button();
            this.Cmd_Anular = new System.Windows.Forms.Button();
            this.Cmd_Guardar = new System.Windows.Forms.Button();
            this.Txt_CodProveedor = new System.Windows.Forms.TextBox();
            this.Chk_Anulado = new System.Windows.Forms.CheckBox();
            this.Txt_Proveedor = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Proveedor = new System.Windows.Forms.Button();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Fr_Busqueda = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Dtp_Hasta = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Desde = new System.Windows.Forms.DateTimePicker();
            this.Cmd_Buscar = new System.Windows.Forms.Button();
            this.Txt_Filtro = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Lbl_Leyenda = new System.Windows.Forms.Label();
            this.Cmd_Cerrar = new System.Windows.Forms.Button();
            this.Lv_Busqueda = new System.Windows.Forms.ListView();
            this.Imagenes = new System.Windows.Forms.ImageList(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.Btn_Unidad_Medida = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Neto = new System.Windows.Forms.TextBox();
            this.Btn_Quitar = new System.Windows.Forms.Button();
            this.Btn_AgregarDetalle = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Txt_Exixtencia = new System.Windows.Forms.TextBox();
            this.Txt_PVU = new System.Windows.Forms.TextBox();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Medicamento = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Txt_CodProducto = new System.Windows.Forms.TextBox();
            this.Txt_Unimed = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Lv_Entradas = new System.Windows.Forms.ListView();
            this.Cmd_Imprimir = new System.Windows.Forms.Button();
            this.ep_Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Fr_Busqueda.SuspendLayout();
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
            this.Cmd_Cancelar.Location = new System.Drawing.Point(318, 51);
            this.Cmd_Cancelar.Name = "Cmd_Cancelar";
            this.Cmd_Cancelar.Size = new System.Drawing.Size(128, 30);
            this.Cmd_Cancelar.TabIndex = 107;
            this.Cmd_Cancelar.Text = "Cancelar";
            this.Cmd_Cancelar.UseVisualStyleBackColor = false;
            this.Cmd_Cancelar.Click += new System.EventHandler(this.Cmd_Cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 106;
            this.label2.Text = "Codigo";
            // 
            // Txt_IdEntrada
            // 
            this.Txt_IdEntrada.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_IdEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdEntrada.Location = new System.Drawing.Point(120, 29);
            this.Txt_IdEntrada.Name = "Txt_IdEntrada";
            this.Txt_IdEntrada.Size = new System.Drawing.Size(135, 21);
            this.Txt_IdEntrada.TabIndex = 105;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(13, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(317, 18);
            this.Label1.TabIndex = 112;
            this.Label1.Text = "Registro de Entrada de Medicamentos:";
            // 
            // Cmd_Nuevo
            // 
            this.Cmd_Nuevo.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Nuevo.ForeColor = System.Drawing.Color.White;
            this.Cmd_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Cmd_Nuevo.Image")));
            this.Cmd_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cmd_Nuevo.Location = new System.Drawing.Point(17, 51);
            this.Cmd_Nuevo.Name = "Cmd_Nuevo";
            this.Cmd_Nuevo.Size = new System.Drawing.Size(128, 30);
            this.Cmd_Nuevo.TabIndex = 105;
            this.Cmd_Nuevo.Text = "Agregar";
            this.Cmd_Nuevo.UseVisualStyleBackColor = false;
            this.Cmd_Nuevo.Click += new System.EventHandler(this.Cmd_Nuevo_Click);
            // 
            // Cmd_Consultar
            // 
            this.Cmd_Consultar.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Consultar.ForeColor = System.Drawing.Color.White;
            this.Cmd_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("Cmd_Consultar.Image")));
            this.Cmd_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cmd_Consultar.Location = new System.Drawing.Point(464, 51);
            this.Cmd_Consultar.Name = "Cmd_Consultar";
            this.Cmd_Consultar.Size = new System.Drawing.Size(128, 30);
            this.Cmd_Consultar.TabIndex = 108;
            this.Cmd_Consultar.Text = "Consultar";
            this.Cmd_Consultar.UseVisualStyleBackColor = false;
            this.Cmd_Consultar.Click += new System.EventHandler(this.Cmd_Consultar_Click);
            // 
            // Cmd_Anular
            // 
            this.Cmd_Anular.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Anular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Anular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Anular.ForeColor = System.Drawing.Color.White;
            this.Cmd_Anular.Image = ((System.Drawing.Image)(resources.GetObject("Cmd_Anular.Image")));
            this.Cmd_Anular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cmd_Anular.Location = new System.Drawing.Point(761, 51);
            this.Cmd_Anular.Name = "Cmd_Anular";
            this.Cmd_Anular.Size = new System.Drawing.Size(128, 30);
            this.Cmd_Anular.TabIndex = 110;
            this.Cmd_Anular.Text = "Anular";
            this.Cmd_Anular.UseVisualStyleBackColor = false;
            this.Cmd_Anular.Click += new System.EventHandler(this.Cmd_Anular_Click);
            // 
            // Cmd_Guardar
            // 
            this.Cmd_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Guardar.ForeColor = System.Drawing.Color.White;
            this.Cmd_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Cmd_Guardar.Image")));
            this.Cmd_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cmd_Guardar.Location = new System.Drawing.Point(168, 51);
            this.Cmd_Guardar.Name = "Cmd_Guardar";
            this.Cmd_Guardar.Size = new System.Drawing.Size(128, 30);
            this.Cmd_Guardar.TabIndex = 106;
            this.Cmd_Guardar.Text = "Guardar";
            this.Cmd_Guardar.UseVisualStyleBackColor = false;
            this.Cmd_Guardar.Click += new System.EventHandler(this.Cmd_Guardar_Click);
            // 
            // Txt_CodProveedor
            // 
            this.Txt_CodProveedor.BackColor = System.Drawing.Color.White;
            this.Txt_CodProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_CodProveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodProveedor.Location = new System.Drawing.Point(143, 54);
            this.Txt_CodProveedor.Name = "Txt_CodProveedor";
            this.Txt_CodProveedor.Size = new System.Drawing.Size(112, 21);
            this.Txt_CodProveedor.TabIndex = 34;
            this.Txt_CodProveedor.WordWrap = false;
            // 
            // Chk_Anulado
            // 
            this.Chk_Anulado.AutoSize = true;
            this.Chk_Anulado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Anulado.ForeColor = System.Drawing.Color.White;
            this.Chk_Anulado.Location = new System.Drawing.Point(437, 27);
            this.Chk_Anulado.Name = "Chk_Anulado";
            this.Chk_Anulado.Size = new System.Drawing.Size(79, 19);
            this.Chk_Anulado.TabIndex = 41;
            this.Chk_Anulado.Text = "Anulado";
            this.Chk_Anulado.UseVisualStyleBackColor = true;
            // 
            // Txt_Proveedor
            // 
            this.Txt_Proveedor.BackColor = System.Drawing.Color.White;
            this.Txt_Proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Proveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Proveedor.Location = new System.Drawing.Point(256, 54);
            this.Txt_Proveedor.Name = "Txt_Proveedor";
            this.Txt_Proveedor.Size = new System.Drawing.Size(751, 21);
            this.Txt_Proveedor.TabIndex = 38;
            this.Txt_Proveedor.WordWrap = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(261, 31);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(51, 15);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "Fecha:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Brown;
            this.GroupBox1.Controls.Add(this.Btn_Proveedor);
            this.GroupBox1.Controls.Add(this.Dtp_Fecha);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.Txt_IdEntrada);
            this.GroupBox1.Controls.Add(this.Txt_CodProveedor);
            this.GroupBox1.Controls.Add(this.Chk_Anulado);
            this.GroupBox1.Controls.Add(this.Txt_Proveedor);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(17, 88);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1016, 100);
            this.GroupBox1.TabIndex = 111;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos Generales del Proveedor:";
            // 
            // Btn_Proveedor
            // 
            this.Btn_Proveedor.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Proveedor.ForeColor = System.Drawing.Color.White;
            this.Btn_Proveedor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Proveedor.Image")));
            this.Btn_Proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Proveedor.Location = new System.Drawing.Point(120, 54);
            this.Btn_Proveedor.Name = "Btn_Proveedor";
            this.Btn_Proveedor.Size = new System.Drawing.Size(23, 21);
            this.Btn_Proveedor.TabIndex = 114;
            this.Btn_Proveedor.UseVisualStyleBackColor = false;
            this.Btn_Proveedor.Click += new System.EventHandler(this.Btn_Proveedor_Click);
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha.Location = new System.Drawing.Point(318, 27);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(112, 21);
            this.Dtp_Fecha.TabIndex = 108;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(482, 78);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(219, 15);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Nombre Completo del Proveedor";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(35, 54);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(79, 15);
            this.Label7.TabIndex = 33;
            this.Label7.Text = "Proveedor:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(30, 31);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(84, 15);
            this.Label8.TabIndex = 31;
            this.Label8.Text = "Entrada No:";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Location = new System.Drawing.Point(905, 51);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(128, 30);
            this.Btn_Cerrar.TabIndex = 109;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(17, 32);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(320, 4);
            this.PictureBox1.TabIndex = 113;
            this.PictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Fr_Busqueda);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.Btn_Unidad_Medida);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Txt_Neto);
            this.groupBox2.Controls.Add(this.Btn_Quitar);
            this.groupBox2.Controls.Add(this.Btn_AgregarDetalle);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.Txt_Precio);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.Txt_Exixtencia);
            this.groupBox2.Controls.Add(this.Txt_PVU);
            this.groupBox2.Controls.Add(this.Txt_Total);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Btn_Medicamento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Txt_Cantidad);
            this.groupBox2.Controls.Add(this.Txt_CodProducto);
            this.groupBox2.Controls.Add(this.Txt_Unimed);
            this.groupBox2.Controls.Add(this.Txt_Descripcion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Lv_Entradas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 380);
            this.groupBox2.TabIndex = 111;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Generales del Médicamento";
            // 
            // Fr_Busqueda
            // 
            this.Fr_Busqueda.BackColor = System.Drawing.Color.Gray;
            this.Fr_Busqueda.Controls.Add(this.label19);
            this.Fr_Busqueda.Controls.Add(this.Dtp_Hasta);
            this.Fr_Busqueda.Controls.Add(this.Dtp_Desde);
            this.Fr_Busqueda.Controls.Add(this.Cmd_Buscar);
            this.Fr_Busqueda.Controls.Add(this.Txt_Filtro);
            this.Fr_Busqueda.Controls.Add(this.label18);
            this.Fr_Busqueda.Controls.Add(this.Lbl_Leyenda);
            this.Fr_Busqueda.Controls.Add(this.Cmd_Cerrar);
            this.Fr_Busqueda.Controls.Add(this.Lv_Busqueda);
            this.Fr_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fr_Busqueda.Location = new System.Drawing.Point(142, 97);
            this.Fr_Busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.Fr_Busqueda.Name = "Fr_Busqueda";
            this.Fr_Busqueda.Padding = new System.Windows.Forms.Padding(2);
            this.Fr_Busqueda.Size = new System.Drawing.Size(847, 294);
            this.Fr_Busqueda.TabIndex = 161;
            this.Fr_Busqueda.TabStop = false;
            this.Fr_Busqueda.Text = "Buscando Registros...";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(554, 19);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 17);
            this.label19.TabIndex = 144;
            this.label19.Text = "Hasta";
            // 
            // Dtp_Hasta
            // 
            this.Dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Hasta.Location = new System.Drawing.Point(609, 16);
            this.Dtp_Hasta.Name = "Dtp_Hasta";
            this.Dtp_Hasta.Size = new System.Drawing.Size(112, 23);
            this.Dtp_Hasta.TabIndex = 143;
            // 
            // Dtp_Desde
            // 
            this.Dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Desde.Location = new System.Drawing.Point(437, 16);
            this.Dtp_Desde.Name = "Dtp_Desde";
            this.Dtp_Desde.Size = new System.Drawing.Size(112, 23);
            this.Dtp_Desde.TabIndex = 142;
            // 
            // Cmd_Buscar
            // 
            this.Cmd_Buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Cmd_Buscar.ForeColor = System.Drawing.Color.Black;
            this.Cmd_Buscar.Location = new System.Drawing.Point(727, 11);
            this.Cmd_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Cmd_Buscar.Name = "Cmd_Buscar";
            this.Cmd_Buscar.Size = new System.Drawing.Size(74, 32);
            this.Cmd_Buscar.TabIndex = 141;
            this.Cmd_Buscar.Text = "Buscar";
            this.Cmd_Buscar.UseVisualStyleBackColor = false;
            this.Cmd_Buscar.Click += new System.EventHandler(this.Cmd_Buscar_Click);
            // 
            // Txt_Filtro
            // 
            this.Txt_Filtro.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Filtro.Location = new System.Drawing.Point(79, 17);
            this.Txt_Filtro.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Filtro.Name = "Txt_Filtro";
            this.Txt_Filtro.Size = new System.Drawing.Size(354, 23);
            this.Txt_Filtro.TabIndex = 140;
            this.Txt_Filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Filtro_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(11, 19);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 17);
            this.label18.TabIndex = 139;
            this.label18.Text = "Buscar:";
            // 
            // Lbl_Leyenda
            // 
            this.Lbl_Leyenda.AutoSize = true;
            this.Lbl_Leyenda.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Leyenda.Location = new System.Drawing.Point(4, 275);
            this.Lbl_Leyenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Leyenda.Name = "Lbl_Leyenda";
            this.Lbl_Leyenda.Size = new System.Drawing.Size(89, 17);
            this.Lbl_Leyenda.TabIndex = 138;
            this.Lbl_Leyenda.Text = "Total Reg.:";
            // 
            // Cmd_Cerrar
            // 
            this.Cmd_Cerrar.ForeColor = System.Drawing.Color.Black;
            this.Cmd_Cerrar.Location = new System.Drawing.Point(824, 0);
            this.Cmd_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Cmd_Cerrar.Name = "Cmd_Cerrar";
            this.Cmd_Cerrar.Size = new System.Drawing.Size(23, 25);
            this.Cmd_Cerrar.TabIndex = 137;
            this.Cmd_Cerrar.Text = "X";
            this.Cmd_Cerrar.UseVisualStyleBackColor = true;
            this.Cmd_Cerrar.Click += new System.EventHandler(this.Cmd_Cerrar_Click);
            // 
            // Lv_Busqueda
            // 
            this.Lv_Busqueda.BackColor = System.Drawing.Color.Thistle;
            this.Lv_Busqueda.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lv_Busqueda.FullRowSelect = true;
            this.Lv_Busqueda.GridLines = true;
            this.Lv_Busqueda.LabelWrap = false;
            this.Lv_Busqueda.Location = new System.Drawing.Point(14, 45);
            this.Lv_Busqueda.MultiSelect = false;
            this.Lv_Busqueda.Name = "Lv_Busqueda";
            this.Lv_Busqueda.ShowGroups = false;
            this.Lv_Busqueda.Size = new System.Drawing.Size(828, 228);
            this.Lv_Busqueda.SmallImageList = this.Imagenes;
            this.Lv_Busqueda.StateImageList = this.Imagenes;
            this.Lv_Busqueda.TabIndex = 136;
            this.Lv_Busqueda.UseCompatibleStateImageBehavior = false;
            this.Lv_Busqueda.View = System.Windows.Forms.View.Details;
            this.Lv_Busqueda.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Lv_Busqueda_ItemSelectionChanged);
            this.Lv_Busqueda.DoubleClick += new System.EventHandler(this.Lv_Busqueda_DoubleClick);
            // 
            // Imagenes
            // 
            this.Imagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Imagenes.ImageStream")));
            this.Imagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.Imagenes.Images.SetKeyName(0, "Cerrar.ico");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(118, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 15);
            this.label17.TabIndex = 160;
            this.label17.Text = "Descripción";
            // 
            // Btn_Unidad_Medida
            // 
            this.Btn_Unidad_Medida.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Unidad_Medida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Unidad_Medida.ForeColor = System.Drawing.Color.White;
            this.Btn_Unidad_Medida.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Unidad_Medida.Image")));
            this.Btn_Unidad_Medida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Unidad_Medida.Location = new System.Drawing.Point(74, 24);
            this.Btn_Unidad_Medida.Name = "Btn_Unidad_Medida";
            this.Btn_Unidad_Medida.Size = new System.Drawing.Size(23, 21);
            this.Btn_Unidad_Medida.TabIndex = 159;
            this.Btn_Unidad_Medida.UseVisualStyleBackColor = false;
            this.Btn_Unidad_Medida.Click += new System.EventHandler(this.Btn_Unidad_Medida_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(805, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 158;
            this.label9.Text = "Neto C$:";
            // 
            // Txt_Neto
            // 
            this.Txt_Neto.BackColor = System.Drawing.Color.White;
            this.Txt_Neto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Neto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Neto.Location = new System.Drawing.Point(874, 354);
            this.Txt_Neto.Name = "Txt_Neto";
            this.Txt_Neto.Size = new System.Drawing.Size(135, 21);
            this.Txt_Neto.TabIndex = 157;
            this.Txt_Neto.WordWrap = false;
            // 
            // Btn_Quitar
            // 
            this.Btn_Quitar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quitar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Quitar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Quitar.Image")));
            this.Btn_Quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Quitar.Location = new System.Drawing.Point(700, 69);
            this.Btn_Quitar.Name = "Btn_Quitar";
            this.Btn_Quitar.Size = new System.Drawing.Size(78, 21);
            this.Btn_Quitar.TabIndex = 156;
            this.Btn_Quitar.Text = "  Quitar";
            this.Btn_Quitar.UseVisualStyleBackColor = false;
            this.Btn_Quitar.Click += new System.EventHandler(this.Btn_Quitar_Click);
            // 
            // Btn_AgregarDetalle
            // 
            this.Btn_AgregarDetalle.BackColor = System.Drawing.Color.Transparent;
            this.Btn_AgregarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AgregarDetalle.ForeColor = System.Drawing.Color.Black;
            this.Btn_AgregarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AgregarDetalle.Image")));
            this.Btn_AgregarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AgregarDetalle.Location = new System.Drawing.Point(622, 69);
            this.Btn_AgregarDetalle.Name = "Btn_AgregarDetalle";
            this.Btn_AgregarDetalle.Size = new System.Drawing.Size(78, 21);
            this.Btn_AgregarDetalle.TabIndex = 136;
            this.Btn_AgregarDetalle.Text = "    Agregar";
            this.Btn_AgregarDetalle.UseVisualStyleBackColor = false;
            this.Btn_AgregarDetalle.Click += new System.EventHandler(this.Btn_AgregarDetalle_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(400, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 15);
            this.label16.TabIndex = 155;
            this.label16.Text = "Precio C$:";
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.BackColor = System.Drawing.Color.White;
            this.Txt_Precio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Precio.Location = new System.Drawing.Point(482, 69);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(110, 21);
            this.Txt_Precio.TabIndex = 154;
            this.Txt_Precio.WordWrap = false;
            this.Txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Precio_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(182, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 15);
            this.label15.TabIndex = 153;
            this.label15.Text = "Cantidad:";
            // 
            // Txt_Exixtencia
            // 
            this.Txt_Exixtencia.BackColor = System.Drawing.Color.White;
            this.Txt_Exixtencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Exixtencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Exixtencia.Location = new System.Drawing.Point(769, 24);
            this.Txt_Exixtencia.Name = "Txt_Exixtencia";
            this.Txt_Exixtencia.Size = new System.Drawing.Size(80, 21);
            this.Txt_Exixtencia.TabIndex = 152;
            this.Txt_Exixtencia.WordWrap = false;
            // 
            // Txt_PVU
            // 
            this.Txt_PVU.BackColor = System.Drawing.Color.White;
            this.Txt_PVU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_PVU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PVU.Location = new System.Drawing.Point(849, 24);
            this.Txt_PVU.Name = "Txt_PVU";
            this.Txt_PVU.Size = new System.Drawing.Size(80, 21);
            this.Txt_PVU.TabIndex = 151;
            this.Txt_PVU.WordWrap = false;
            // 
            // Txt_Total
            // 
            this.Txt_Total.BackColor = System.Drawing.Color.White;
            this.Txt_Total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.Location = new System.Drawing.Point(929, 24);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(80, 21);
            this.Txt_Total.TabIndex = 150;
            this.Txt_Total.WordWrap = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(949, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 15);
            this.label14.TabIndex = 149;
            this.label14.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(868, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 148;
            this.label13.Text = "Costo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(771, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 147;
            this.label12.Text = "Existencia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 146;
            this.label11.Text = "Medición:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(486, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 15);
            this.label6.TabIndex = 145;
            this.label6.Text = "Descripción del Médicamento";
            // 
            // Btn_Medicamento
            // 
            this.Btn_Medicamento.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Medicamento.ForeColor = System.Drawing.Color.White;
            this.Btn_Medicamento.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Medicamento.Image")));
            this.Btn_Medicamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Medicamento.Location = new System.Drawing.Point(338, 24);
            this.Btn_Medicamento.Name = "Btn_Medicamento";
            this.Btn_Medicamento.Size = new System.Drawing.Size(23, 21);
            this.Btn_Medicamento.TabIndex = 144;
            this.Btn_Medicamento.UseVisualStyleBackColor = false;
            this.Btn_Medicamento.Click += new System.EventHandler(this.Btn_Medicamento_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(379, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 143;
            this.label5.Text = "Codigo";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.BackColor = System.Drawing.Color.White;
            this.Txt_Cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Cantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.Location = new System.Drawing.Point(258, 69);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(120, 21);
            this.Txt_Cantidad.TabIndex = 140;
            this.Txt_Cantidad.WordWrap = false;
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // Txt_CodProducto
            // 
            this.Txt_CodProducto.BackColor = System.Drawing.Color.White;
            this.Txt_CodProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_CodProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodProducto.Location = new System.Drawing.Point(363, 24);
            this.Txt_CodProducto.Name = "Txt_CodProducto";
            this.Txt_CodProducto.Size = new System.Drawing.Size(86, 21);
            this.Txt_CodProducto.TabIndex = 139;
            this.Txt_CodProducto.WordWrap = false;
            // 
            // Txt_Unimed
            // 
            this.Txt_Unimed.BackColor = System.Drawing.Color.White;
            this.Txt_Unimed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Unimed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Unimed.Location = new System.Drawing.Point(98, 25);
            this.Txt_Unimed.Name = "Txt_Unimed";
            this.Txt_Unimed.Size = new System.Drawing.Size(144, 21);
            this.Txt_Unimed.TabIndex = 142;
            this.Txt_Unimed.WordWrap = false;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.White;
            this.Txt_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.Location = new System.Drawing.Point(448, 24);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(321, 21);
            this.Txt_Descripcion.TabIndex = 141;
            this.Txt_Descripcion.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(247, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 138;
            this.label10.Text = "Médicamento:";
            // 
            // Lv_Entradas
            // 
            this.Lv_Entradas.BackColor = System.Drawing.Color.Thistle;
            this.Lv_Entradas.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Entradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lv_Entradas.FullRowSelect = true;
            this.Lv_Entradas.GridLines = true;
            this.Lv_Entradas.LabelWrap = false;
            this.Lv_Entradas.Location = new System.Drawing.Point(13, 97);
            this.Lv_Entradas.MultiSelect = false;
            this.Lv_Entradas.Name = "Lv_Entradas";
            this.Lv_Entradas.ShowGroups = false;
            this.Lv_Entradas.Size = new System.Drawing.Size(996, 253);
            this.Lv_Entradas.SmallImageList = this.Imagenes;
            this.Lv_Entradas.StateImageList = this.Imagenes;
            this.Lv_Entradas.TabIndex = 135;
            this.Lv_Entradas.UseCompatibleStateImageBehavior = false;
            this.Lv_Entradas.View = System.Windows.Forms.View.Details;
            this.Lv_Entradas.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Lv_Entradas_ItemSelectionChanged);
            // 
            // Cmd_Imprimir
            // 
            this.Cmd_Imprimir.BackColor = System.Drawing.Color.Transparent;
            this.Cmd_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmd_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Imprimir.ForeColor = System.Drawing.Color.White;
            this.Cmd_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Cmd_Imprimir.Image")));
            this.Cmd_Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cmd_Imprimir.Location = new System.Drawing.Point(611, 51);
            this.Cmd_Imprimir.Name = "Cmd_Imprimir";
            this.Cmd_Imprimir.Size = new System.Drawing.Size(128, 30);
            this.Cmd_Imprimir.TabIndex = 124;
            this.Cmd_Imprimir.Text = "Imprimir";
            this.Cmd_Imprimir.UseVisualStyleBackColor = false;
            this.Cmd_Imprimir.Click += new System.EventHandler(this.Cmd_Imprimir_Click);
            // 
            // ep_Error
            // 
            this.ep_Error.ContainerControl = this;
            // 
            // Frm_Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1040, 574);
            this.Controls.Add(this.Cmd_Imprimir);
            this.Controls.Add(this.Cmd_Cancelar);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Cmd_Nuevo);
            this.Controls.Add(this.Cmd_Consultar);
            this.Controls.Add(this.Cmd_Anular);
            this.Controls.Add(this.Cmd_Guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Entrada";
            this.Text = "Frm_Entrada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Entrada_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Entrada_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Entrada_VisibleChanged);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Fr_Busqueda.ResumeLayout(false);
            this.Fr_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Cmd_Cancelar;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox Txt_IdEntrada;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Cmd_Nuevo;
        internal System.Windows.Forms.Button Cmd_Consultar;
        internal System.Windows.Forms.Button Cmd_Anular;
        internal System.Windows.Forms.Button Cmd_Guardar;
        internal System.Windows.Forms.TextBox Txt_CodProveedor;
        internal System.Windows.Forms.CheckBox Chk_Anulado;
        internal System.Windows.Forms.TextBox Txt_Proveedor;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Btn_Proveedor;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button Btn_Cerrar;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox Txt_Neto;
        internal System.Windows.Forms.Button Btn_Quitar;
        internal System.Windows.Forms.Button Btn_AgregarDetalle;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox Txt_Precio;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox Txt_Exixtencia;
        internal System.Windows.Forms.TextBox Txt_PVU;
        internal System.Windows.Forms.TextBox Txt_Total;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Button Btn_Medicamento;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox Txt_Cantidad;
        internal System.Windows.Forms.TextBox Txt_CodProducto;
        internal System.Windows.Forms.TextBox Txt_Unimed;
        internal System.Windows.Forms.TextBox Txt_Descripcion;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ListView Lv_Entradas;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Button Btn_Unidad_Medida;
        internal System.Windows.Forms.Button Cmd_Imprimir;
        private System.Windows.Forms.ImageList Imagenes;
        private System.Windows.Forms.ErrorProvider ep_Error;
        private System.Windows.Forms.GroupBox Fr_Busqueda;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker Dtp_Hasta;
        private System.Windows.Forms.DateTimePicker Dtp_Desde;
        private System.Windows.Forms.Button Cmd_Buscar;
        private System.Windows.Forms.TextBox Txt_Filtro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Lbl_Leyenda;
        private System.Windows.Forms.Button Cmd_Cerrar;
        internal System.Windows.Forms.ListView Lv_Busqueda;
    }
}