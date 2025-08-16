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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Entrada));
            Cmd_Cancelar = new Button();
            label2 = new Label();
            Txt_IdEntrada = new TextBox();
            Label1 = new Label();
            Cmd_Nuevo = new Button();
            Cmd_Consultar = new Button();
            Cmd_Anular = new Button();
            Cmd_Guardar = new Button();
            Txt_CodProveedor = new TextBox();
            Chk_Anulado = new CheckBox();
            Txt_Proveedor = new TextBox();
            Label4 = new Label();
            GroupBox1 = new GroupBox();
            Btn_Proveedor = new Button();
            Dtp_Fecha = new DateTimePicker();
            Label3 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Btn_Cerrar = new Button();
            PictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            Fr_Busqueda = new GroupBox();
            label19 = new Label();
            Dtp_Hasta = new DateTimePicker();
            Dtp_Desde = new DateTimePicker();
            Cmd_Buscar = new Button();
            Txt_Filtro = new TextBox();
            label18 = new Label();
            Lbl_Leyenda = new Label();
            Cmd_Cerrar = new Button();
            Lv_Busqueda = new ListView();
            Imagenes = new ImageList(components);
            label17 = new Label();
            Btn_Unidad_Medida = new Button();
            label9 = new Label();
            Txt_Neto = new TextBox();
            Btn_Quitar = new Button();
            Btn_AgregarDetalle = new Button();
            label16 = new Label();
            Txt_Precio = new TextBox();
            label15 = new Label();
            Txt_Exixtencia = new TextBox();
            Txt_PVU = new TextBox();
            Txt_Total = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label6 = new Label();
            Btn_Medicamento = new Button();
            label5 = new Label();
            Txt_Cantidad = new TextBox();
            Txt_CodProducto = new TextBox();
            Txt_Unimed = new TextBox();
            Txt_Descripcion = new TextBox();
            label10 = new Label();
            Lv_Entradas = new ListView();
            Cmd_Imprimir = new Button();
            ep_Error = new ErrorProvider(components);
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            Fr_Busqueda.SuspendLayout();
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
            Cmd_Cancelar.Location = new Point(371, 59);
            Cmd_Cancelar.Margin = new Padding(4, 3, 4, 3);
            Cmd_Cancelar.Name = "Cmd_Cancelar";
            Cmd_Cancelar.Size = new Size(149, 35);
            Cmd_Cancelar.TabIndex = 107;
            Cmd_Cancelar.Text = "Cancelar";
            Cmd_Cancelar.UseVisualStyleBackColor = false;
            Cmd_Cancelar.Click += Cmd_Cancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(201, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 106;
            label2.Text = "Codigo";
            // 
            // Txt_IdEntrada
            // 
            Txt_IdEntrada.BackColor = SystemColors.ButtonHighlight;
            Txt_IdEntrada.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_IdEntrada.Location = new Point(140, 33);
            Txt_IdEntrada.Margin = new Padding(4, 3, 4, 3);
            Txt_IdEntrada.Name = "Txt_IdEntrada";
            Txt_IdEntrada.Size = new Size(157, 21);
            Txt_IdEntrada.TabIndex = 105;
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
            Label1.Size = new Size(317, 18);
            Label1.TabIndex = 112;
            Label1.Text = "Registro de Entrada de Medicamentos:";
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
            Cmd_Nuevo.Margin = new Padding(4, 3, 4, 3);
            Cmd_Nuevo.Name = "Cmd_Nuevo";
            Cmd_Nuevo.Size = new Size(149, 35);
            Cmd_Nuevo.TabIndex = 105;
            Cmd_Nuevo.Text = "Agregar";
            Cmd_Nuevo.UseVisualStyleBackColor = false;
            Cmd_Nuevo.Click += Cmd_Nuevo_Click;
            // 
            // Cmd_Consultar
            // 
            Cmd_Consultar.BackColor = Color.IndianRed;
            Cmd_Consultar.FlatStyle = FlatStyle.Flat;
            Cmd_Consultar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmd_Consultar.ForeColor = Color.White;
            Cmd_Consultar.Image = (Image)resources.GetObject("Cmd_Consultar.Image");
            Cmd_Consultar.ImageAlign = ContentAlignment.MiddleLeft;
            Cmd_Consultar.Location = new Point(541, 59);
            Cmd_Consultar.Margin = new Padding(4, 3, 4, 3);
            Cmd_Consultar.Name = "Cmd_Consultar";
            Cmd_Consultar.Size = new Size(149, 35);
            Cmd_Consultar.TabIndex = 108;
            Cmd_Consultar.Text = "Consultar";
            Cmd_Consultar.UseVisualStyleBackColor = false;
            Cmd_Consultar.Click += Cmd_Consultar_Click;
            // 
            // Cmd_Anular
            // 
            Cmd_Anular.BackColor = Color.IndianRed;
            Cmd_Anular.FlatStyle = FlatStyle.Flat;
            Cmd_Anular.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmd_Anular.ForeColor = Color.White;
            Cmd_Anular.Image = (Image)resources.GetObject("Cmd_Anular.Image");
            Cmd_Anular.ImageAlign = ContentAlignment.MiddleLeft;
            Cmd_Anular.Location = new Point(888, 59);
            Cmd_Anular.Margin = new Padding(4, 3, 4, 3);
            Cmd_Anular.Name = "Cmd_Anular";
            Cmd_Anular.Size = new Size(149, 35);
            Cmd_Anular.TabIndex = 110;
            Cmd_Anular.Text = "Anular";
            Cmd_Anular.UseVisualStyleBackColor = false;
            Cmd_Anular.Click += Cmd_Anular_Click;
            // 
            // Cmd_Guardar
            // 
            Cmd_Guardar.BackColor = Color.IndianRed;
            Cmd_Guardar.FlatStyle = FlatStyle.Flat;
            Cmd_Guardar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmd_Guardar.ForeColor = Color.White;
            Cmd_Guardar.Image = (Image)resources.GetObject("Cmd_Guardar.Image");
            Cmd_Guardar.ImageAlign = ContentAlignment.MiddleLeft;
            Cmd_Guardar.Location = new Point(196, 59);
            Cmd_Guardar.Margin = new Padding(4, 3, 4, 3);
            Cmd_Guardar.Name = "Cmd_Guardar";
            Cmd_Guardar.Size = new Size(149, 35);
            Cmd_Guardar.TabIndex = 106;
            Cmd_Guardar.Text = "Guardar";
            Cmd_Guardar.UseVisualStyleBackColor = false;
            Cmd_Guardar.Click += Cmd_Guardar_Click;
            // 
            // Txt_CodProveedor
            // 
            Txt_CodProveedor.BackColor = Color.White;
            Txt_CodProveedor.CharacterCasing = CharacterCasing.Upper;
            Txt_CodProveedor.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_CodProveedor.Location = new Point(167, 62);
            Txt_CodProveedor.Margin = new Padding(4, 3, 4, 3);
            Txt_CodProveedor.Name = "Txt_CodProveedor";
            Txt_CodProveedor.Size = new Size(130, 21);
            Txt_CodProveedor.TabIndex = 34;
            Txt_CodProveedor.WordWrap = false;
            // 
            // Chk_Anulado
            // 
            Chk_Anulado.AutoSize = true;
            Chk_Anulado.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Chk_Anulado.ForeColor = Color.White;
            Chk_Anulado.Location = new Point(510, 31);
            Chk_Anulado.Margin = new Padding(4, 3, 4, 3);
            Chk_Anulado.Name = "Chk_Anulado";
            Chk_Anulado.Size = new Size(79, 19);
            Chk_Anulado.TabIndex = 41;
            Chk_Anulado.Text = "Anulado";
            Chk_Anulado.UseVisualStyleBackColor = true;
            // 
            // Txt_Proveedor
            // 
            Txt_Proveedor.BackColor = Color.White;
            Txt_Proveedor.CharacterCasing = CharacterCasing.Upper;
            Txt_Proveedor.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Proveedor.Location = new Point(299, 62);
            Txt_Proveedor.Margin = new Padding(4, 3, 4, 3);
            Txt_Proveedor.Name = "Txt_Proveedor";
            Txt_Proveedor.Size = new Size(876, 21);
            Txt_Proveedor.TabIndex = 38;
            Txt_Proveedor.WordWrap = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(304, 36);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(51, 15);
            Label4.TabIndex = 37;
            Label4.Text = "Fecha:";
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Brown;
            GroupBox1.Controls.Add(Btn_Proveedor);
            GroupBox1.Controls.Add(Dtp_Fecha);
            GroupBox1.Controls.Add(label2);
            GroupBox1.Controls.Add(Txt_IdEntrada);
            GroupBox1.Controls.Add(Txt_CodProveedor);
            GroupBox1.Controls.Add(Chk_Anulado);
            GroupBox1.Controls.Add(Txt_Proveedor);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Controls.Add(Label8);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox1.ForeColor = Color.White;
            GroupBox1.Location = new Point(20, 102);
            GroupBox1.Margin = new Padding(4, 3, 4, 3);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4, 3, 4, 3);
            GroupBox1.Size = new Size(1185, 115);
            GroupBox1.TabIndex = 111;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Datos Generales del Proveedor:";
            // 
            // Btn_Proveedor
            // 
            Btn_Proveedor.BackColor = Color.Transparent;
            Btn_Proveedor.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Proveedor.ForeColor = Color.White;
            Btn_Proveedor.Image = (Image)resources.GetObject("Btn_Proveedor.Image");
            Btn_Proveedor.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Proveedor.Location = new Point(140, 62);
            Btn_Proveedor.Margin = new Padding(4, 3, 4, 3);
            Btn_Proveedor.Name = "Btn_Proveedor";
            Btn_Proveedor.Size = new Size(27, 24);
            Btn_Proveedor.TabIndex = 114;
            Btn_Proveedor.UseVisualStyleBackColor = false;
            Btn_Proveedor.Click += Btn_Proveedor_Click;
            // 
            // Dtp_Fecha
            // 
            Dtp_Fecha.Format = DateTimePickerFormat.Short;
            Dtp_Fecha.Location = new Point(371, 31);
            Dtp_Fecha.Margin = new Padding(4, 3, 4, 3);
            Dtp_Fecha.Name = "Dtp_Fecha";
            Dtp_Fecha.Size = new Size(130, 21);
            Dtp_Fecha.TabIndex = 108;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(562, 90);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(219, 15);
            Label3.TabIndex = 35;
            Label3.Text = "Nombre Completo del Proveedor";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(41, 62);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(79, 15);
            Label7.TabIndex = 33;
            Label7.Text = "Proveedor:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(35, 36);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(84, 15);
            Label8.TabIndex = 31;
            Label8.Text = "Entrada No:";
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
            Btn_Cerrar.Margin = new Padding(4, 3, 4, 3);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(149, 35);
            Btn_Cerrar.TabIndex = 109;
            Btn_Cerrar.Text = "Cerrar";
            Btn_Cerrar.UseVisualStyleBackColor = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(20, 37);
            PictureBox1.Margin = new Padding(4, 3, 4, 3);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(373, 5);
            PictureBox1.TabIndex = 113;
            PictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(Fr_Busqueda);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(Btn_Unidad_Medida);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(Txt_Neto);
            groupBox2.Controls.Add(Btn_Quitar);
            groupBox2.Controls.Add(Btn_AgregarDetalle);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(Txt_Precio);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(Txt_Exixtencia);
            groupBox2.Controls.Add(Txt_PVU);
            groupBox2.Controls.Add(Txt_Total);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(Btn_Medicamento);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(Txt_Cantidad);
            groupBox2.Controls.Add(Txt_CodProducto);
            groupBox2.Controls.Add(Txt_Unimed);
            groupBox2.Controls.Add(Txt_Descripcion);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(Lv_Entradas);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(19, 218);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1185, 438);
            groupBox2.TabIndex = 111;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Generales del Médicamento";
            // 
            // Fr_Busqueda
            // 
            Fr_Busqueda.BackColor = Color.LightCoral;
            Fr_Busqueda.Controls.Add(label19);
            Fr_Busqueda.Controls.Add(Dtp_Hasta);
            Fr_Busqueda.Controls.Add(Dtp_Desde);
            Fr_Busqueda.Controls.Add(Cmd_Buscar);
            Fr_Busqueda.Controls.Add(Txt_Filtro);
            Fr_Busqueda.Controls.Add(label18);
            Fr_Busqueda.Controls.Add(Lbl_Leyenda);
            Fr_Busqueda.Controls.Add(Cmd_Cerrar);
            Fr_Busqueda.Controls.Add(Lv_Busqueda);
            Fr_Busqueda.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fr_Busqueda.Location = new Point(166, 112);
            Fr_Busqueda.Margin = new Padding(2);
            Fr_Busqueda.Name = "Fr_Busqueda";
            Fr_Busqueda.Padding = new Padding(2);
            Fr_Busqueda.Size = new Size(988, 339);
            Fr_Busqueda.TabIndex = 161;
            Fr_Busqueda.TabStop = false;
            Fr_Busqueda.Text = "Buscando Registros...";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Black;
            label19.Location = new Point(646, 22);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(50, 17);
            label19.TabIndex = 144;
            label19.Text = "Hasta";
            // 
            // Dtp_Hasta
            // 
            Dtp_Hasta.Format = DateTimePickerFormat.Short;
            Dtp_Hasta.Location = new Point(710, 18);
            Dtp_Hasta.Margin = new Padding(4, 3, 4, 3);
            Dtp_Hasta.Name = "Dtp_Hasta";
            Dtp_Hasta.Size = new Size(130, 23);
            Dtp_Hasta.TabIndex = 143;
            // 
            // Dtp_Desde
            // 
            Dtp_Desde.Format = DateTimePickerFormat.Short;
            Dtp_Desde.Location = new Point(510, 18);
            Dtp_Desde.Margin = new Padding(4, 3, 4, 3);
            Dtp_Desde.Name = "Dtp_Desde";
            Dtp_Desde.Size = new Size(130, 23);
            Dtp_Desde.TabIndex = 142;
            // 
            // Cmd_Buscar
            // 
            Cmd_Buscar.BackColor = Color.FromArgb(255, 128, 128);
            Cmd_Buscar.ForeColor = Color.Black;
            Cmd_Buscar.Location = new Point(848, 13);
            Cmd_Buscar.Margin = new Padding(2);
            Cmd_Buscar.Name = "Cmd_Buscar";
            Cmd_Buscar.Size = new Size(86, 37);
            Cmd_Buscar.TabIndex = 141;
            Cmd_Buscar.Text = "Buscar";
            Cmd_Buscar.UseVisualStyleBackColor = false;
            Cmd_Buscar.Click += Cmd_Buscar_Click;
            // 
            // Txt_Filtro
            // 
            Txt_Filtro.BackColor = Color.FromArgb(255, 192, 192);
            Txt_Filtro.CharacterCasing = CharacterCasing.Upper;
            Txt_Filtro.Location = new Point(92, 20);
            Txt_Filtro.Margin = new Padding(2);
            Txt_Filtro.Name = "Txt_Filtro";
            Txt_Filtro.Size = new Size(412, 23);
            Txt_Filtro.TabIndex = 140;
            Txt_Filtro.KeyPress += Txt_Filtro_KeyPress;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Black;
            label18.Location = new Point(13, 22);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(63, 17);
            label18.TabIndex = 139;
            label18.Text = "Buscar:";
            // 
            // Lbl_Leyenda
            // 
            Lbl_Leyenda.AutoSize = true;
            Lbl_Leyenda.ForeColor = Color.Black;
            Lbl_Leyenda.Location = new Point(5, 317);
            Lbl_Leyenda.Margin = new Padding(2, 0, 2, 0);
            Lbl_Leyenda.Name = "Lbl_Leyenda";
            Lbl_Leyenda.Size = new Size(89, 17);
            Lbl_Leyenda.TabIndex = 138;
            Lbl_Leyenda.Text = "Total Reg.:";
            // 
            // Cmd_Cerrar
            // 
            Cmd_Cerrar.ForeColor = Color.Black;
            Cmd_Cerrar.Location = new Point(961, 0);
            Cmd_Cerrar.Margin = new Padding(2);
            Cmd_Cerrar.Name = "Cmd_Cerrar";
            Cmd_Cerrar.Size = new Size(27, 29);
            Cmd_Cerrar.TabIndex = 137;
            Cmd_Cerrar.Text = "X";
            Cmd_Cerrar.UseVisualStyleBackColor = true;
            Cmd_Cerrar.Click += Cmd_Cerrar_Click;
            // 
            // Lv_Busqueda
            // 
            Lv_Busqueda.BackColor = Color.Thistle;
            Lv_Busqueda.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lv_Busqueda.ForeColor = Color.FromArgb(0, 0, 64);
            Lv_Busqueda.FullRowSelect = true;
            Lv_Busqueda.GridLines = true;
            Lv_Busqueda.LabelWrap = false;
            Lv_Busqueda.Location = new Point(16, 52);
            Lv_Busqueda.Margin = new Padding(4, 3, 4, 3);
            Lv_Busqueda.MultiSelect = false;
            Lv_Busqueda.Name = "Lv_Busqueda";
            Lv_Busqueda.ShowGroups = false;
            Lv_Busqueda.Size = new Size(965, 262);
            Lv_Busqueda.SmallImageList = Imagenes;
            Lv_Busqueda.StateImageList = Imagenes;
            Lv_Busqueda.TabIndex = 136;
            Lv_Busqueda.UseCompatibleStateImageBehavior = false;
            Lv_Busqueda.View = View.Details;
            Lv_Busqueda.ItemSelectionChanged += Lv_Busqueda_ItemSelectionChanged;
            Lv_Busqueda.DoubleClick += Lv_Busqueda_DoubleClick;
            // 
            // Imagenes
            // 
            Imagenes.ColorDepth = ColorDepth.Depth8Bit;
            Imagenes.ImageStream = (ImageListStreamer)resources.GetObject("Imagenes.ImageStream");
            Imagenes.TransparentColor = Color.Transparent;
            Imagenes.Images.SetKeyName(0, "Cerrar.ico");
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(138, 55);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(86, 15);
            label17.TabIndex = 160;
            label17.Text = "Descripción";
            // 
            // Btn_Unidad_Medida
            // 
            Btn_Unidad_Medida.BackColor = Color.Transparent;
            Btn_Unidad_Medida.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Unidad_Medida.ForeColor = Color.White;
            Btn_Unidad_Medida.Image = (Image)resources.GetObject("Btn_Unidad_Medida.Image");
            Btn_Unidad_Medida.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Unidad_Medida.Location = new Point(86, 28);
            Btn_Unidad_Medida.Margin = new Padding(4, 3, 4, 3);
            Btn_Unidad_Medida.Name = "Btn_Unidad_Medida";
            Btn_Unidad_Medida.Size = new Size(27, 24);
            Btn_Unidad_Medida.TabIndex = 159;
            Btn_Unidad_Medida.UseVisualStyleBackColor = false;
            Btn_Unidad_Medida.Click += Btn_Unidad_Medida_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(939, 411);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 158;
            label9.Text = "Neto C$:";
            // 
            // Txt_Neto
            // 
            Txt_Neto.BackColor = Color.White;
            Txt_Neto.CharacterCasing = CharacterCasing.Upper;
            Txt_Neto.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Neto.Location = new Point(1020, 408);
            Txt_Neto.Margin = new Padding(4, 3, 4, 3);
            Txt_Neto.Name = "Txt_Neto";
            Txt_Neto.Size = new Size(157, 21);
            Txt_Neto.TabIndex = 157;
            Txt_Neto.WordWrap = false;
            // 
            // Btn_Quitar
            // 
            Btn_Quitar.BackColor = Color.Brown;
            Btn_Quitar.FlatStyle = FlatStyle.Flat;
            Btn_Quitar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Quitar.ForeColor = Color.White;
            Btn_Quitar.Image = (Image)resources.GetObject("Btn_Quitar.Image");
            Btn_Quitar.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Quitar.Location = new Point(817, 80);
            Btn_Quitar.Margin = new Padding(4, 3, 4, 3);
            Btn_Quitar.Name = "Btn_Quitar";
            Btn_Quitar.Size = new Size(91, 24);
            Btn_Quitar.TabIndex = 156;
            Btn_Quitar.Text = "  Quitar";
            Btn_Quitar.UseVisualStyleBackColor = false;
            Btn_Quitar.Click += Btn_Quitar_Click;
            // 
            // Btn_AgregarDetalle
            // 
            Btn_AgregarDetalle.BackColor = Color.Brown;
            Btn_AgregarDetalle.FlatStyle = FlatStyle.Flat;
            Btn_AgregarDetalle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_AgregarDetalle.ForeColor = Color.White;
            Btn_AgregarDetalle.Image = (Image)resources.GetObject("Btn_AgregarDetalle.Image");
            Btn_AgregarDetalle.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_AgregarDetalle.Location = new Point(726, 80);
            Btn_AgregarDetalle.Margin = new Padding(4, 3, 4, 3);
            Btn_AgregarDetalle.Name = "Btn_AgregarDetalle";
            Btn_AgregarDetalle.Size = new Size(91, 24);
            Btn_AgregarDetalle.TabIndex = 136;
            Btn_AgregarDetalle.Text = "    Agregar";
            Btn_AgregarDetalle.UseVisualStyleBackColor = false;
            Btn_AgregarDetalle.Click += Btn_AgregarDetalle_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(467, 83);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(75, 15);
            label16.TabIndex = 155;
            label16.Text = "Precio C$:";
            // 
            // Txt_Precio
            // 
            Txt_Precio.BackColor = Color.White;
            Txt_Precio.CharacterCasing = CharacterCasing.Upper;
            Txt_Precio.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Precio.Location = new Point(562, 80);
            Txt_Precio.Margin = new Padding(4, 3, 4, 3);
            Txt_Precio.Name = "Txt_Precio";
            Txt_Precio.Size = new Size(128, 21);
            Txt_Precio.TabIndex = 154;
            Txt_Precio.WordWrap = false;
            Txt_Precio.KeyPress += Txt_Precio_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(212, 80);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(70, 15);
            label15.TabIndex = 153;
            label15.Text = "Cantidad:";
            // 
            // Txt_Exixtencia
            // 
            Txt_Exixtencia.BackColor = Color.White;
            Txt_Exixtencia.CharacterCasing = CharacterCasing.Upper;
            Txt_Exixtencia.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Exixtencia.Location = new Point(897, 28);
            Txt_Exixtencia.Margin = new Padding(4, 3, 4, 3);
            Txt_Exixtencia.Name = "Txt_Exixtencia";
            Txt_Exixtencia.Size = new Size(93, 21);
            Txt_Exixtencia.TabIndex = 152;
            Txt_Exixtencia.WordWrap = false;
            // 
            // Txt_PVU
            // 
            Txt_PVU.BackColor = Color.White;
            Txt_PVU.CharacterCasing = CharacterCasing.Upper;
            Txt_PVU.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_PVU.Location = new Point(990, 28);
            Txt_PVU.Margin = new Padding(4, 3, 4, 3);
            Txt_PVU.Name = "Txt_PVU";
            Txt_PVU.Size = new Size(93, 21);
            Txt_PVU.TabIndex = 151;
            Txt_PVU.WordWrap = false;
            // 
            // Txt_Total
            // 
            Txt_Total.BackColor = Color.White;
            Txt_Total.CharacterCasing = CharacterCasing.Upper;
            Txt_Total.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Total.Location = new Point(1084, 28);
            Txt_Total.Margin = new Padding(4, 3, 4, 3);
            Txt_Total.Name = "Txt_Total";
            Txt_Total.Size = new Size(93, 21);
            Txt_Total.TabIndex = 150;
            Txt_Total.WordWrap = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(1107, 55);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 149;
            label14.Text = "Total";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(1013, 55);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 148;
            label13.Text = "Costo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(899, 55);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 147;
            label12.Text = "Existencia";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(7, 30);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 146;
            label11.Text = "Medición:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(567, 55);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(200, 15);
            label6.TabIndex = 145;
            label6.Text = "Descripción del Médicamento";
            // 
            // Btn_Medicamento
            // 
            Btn_Medicamento.BackColor = Color.Transparent;
            Btn_Medicamento.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Medicamento.ForeColor = Color.White;
            Btn_Medicamento.Image = (Image)resources.GetObject("Btn_Medicamento.Image");
            Btn_Medicamento.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Medicamento.Location = new Point(394, 28);
            Btn_Medicamento.Margin = new Padding(4, 3, 4, 3);
            Btn_Medicamento.Name = "Btn_Medicamento";
            Btn_Medicamento.Size = new Size(27, 24);
            Btn_Medicamento.TabIndex = 144;
            Btn_Medicamento.UseVisualStyleBackColor = false;
            Btn_Medicamento.Click += Btn_Medicamento_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(442, 55);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 143;
            label5.Text = "Codigo";
            // 
            // Txt_Cantidad
            // 
            Txt_Cantidad.BackColor = Color.White;
            Txt_Cantidad.CharacterCasing = CharacterCasing.Upper;
            Txt_Cantidad.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Cantidad.Location = new Point(301, 80);
            Txt_Cantidad.Margin = new Padding(4, 3, 4, 3);
            Txt_Cantidad.Name = "Txt_Cantidad";
            Txt_Cantidad.Size = new Size(139, 21);
            Txt_Cantidad.TabIndex = 140;
            Txt_Cantidad.WordWrap = false;
            Txt_Cantidad.KeyPress += Txt_Cantidad_KeyPress;
            // 
            // Txt_CodProducto
            // 
            Txt_CodProducto.BackColor = Color.White;
            Txt_CodProducto.CharacterCasing = CharacterCasing.Upper;
            Txt_CodProducto.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_CodProducto.Location = new Point(424, 28);
            Txt_CodProducto.Margin = new Padding(4, 3, 4, 3);
            Txt_CodProducto.Name = "Txt_CodProducto";
            Txt_CodProducto.Size = new Size(100, 21);
            Txt_CodProducto.TabIndex = 139;
            Txt_CodProducto.WordWrap = false;
            // 
            // Txt_Unimed
            // 
            Txt_Unimed.BackColor = Color.White;
            Txt_Unimed.CharacterCasing = CharacterCasing.Upper;
            Txt_Unimed.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Unimed.Location = new Point(114, 29);
            Txt_Unimed.Margin = new Padding(4, 3, 4, 3);
            Txt_Unimed.Name = "Txt_Unimed";
            Txt_Unimed.Size = new Size(167, 21);
            Txt_Unimed.TabIndex = 142;
            Txt_Unimed.WordWrap = false;
            // 
            // Txt_Descripcion
            // 
            Txt_Descripcion.BackColor = Color.White;
            Txt_Descripcion.CharacterCasing = CharacterCasing.Upper;
            Txt_Descripcion.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Descripcion.Location = new Point(523, 28);
            Txt_Descripcion.Margin = new Padding(4, 3, 4, 3);
            Txt_Descripcion.Name = "Txt_Descripcion";
            Txt_Descripcion.Size = new Size(374, 21);
            Txt_Descripcion.TabIndex = 141;
            Txt_Descripcion.WordWrap = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(288, 31);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 138;
            label10.Text = "Médicamento:";
            // 
            // Lv_Entradas
            // 
            Lv_Entradas.BackColor = Color.Thistle;
            Lv_Entradas.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lv_Entradas.ForeColor = Color.FromArgb(0, 0, 64);
            Lv_Entradas.FullRowSelect = true;
            Lv_Entradas.GridLines = true;
            Lv_Entradas.LabelWrap = false;
            Lv_Entradas.Location = new Point(15, 112);
            Lv_Entradas.Margin = new Padding(4, 3, 4, 3);
            Lv_Entradas.MultiSelect = false;
            Lv_Entradas.Name = "Lv_Entradas";
            Lv_Entradas.ShowGroups = false;
            Lv_Entradas.Size = new Size(1161, 291);
            Lv_Entradas.SmallImageList = Imagenes;
            Lv_Entradas.StateImageList = Imagenes;
            Lv_Entradas.TabIndex = 135;
            Lv_Entradas.UseCompatibleStateImageBehavior = false;
            Lv_Entradas.View = View.Details;
            Lv_Entradas.ItemSelectionChanged += Lv_Entradas_ItemSelectionChanged;
            // 
            // Cmd_Imprimir
            // 
            Cmd_Imprimir.BackColor = Color.IndianRed;
            Cmd_Imprimir.FlatStyle = FlatStyle.Flat;
            Cmd_Imprimir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmd_Imprimir.ForeColor = Color.White;
            Cmd_Imprimir.Image = (Image)resources.GetObject("Cmd_Imprimir.Image");
            Cmd_Imprimir.ImageAlign = ContentAlignment.MiddleLeft;
            Cmd_Imprimir.Location = new Point(713, 59);
            Cmd_Imprimir.Margin = new Padding(4, 3, 4, 3);
            Cmd_Imprimir.Name = "Cmd_Imprimir";
            Cmd_Imprimir.Size = new Size(149, 35);
            Cmd_Imprimir.TabIndex = 124;
            Cmd_Imprimir.Text = "Imprimir";
            Cmd_Imprimir.UseVisualStyleBackColor = false;
            Cmd_Imprimir.Click += Cmd_Imprimir_Click;
            // 
            // ep_Error
            // 
            ep_Error.ContainerControl = this;
            // 
            // Frm_Entrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1213, 662);
            Controls.Add(Cmd_Imprimir);
            Controls.Add(Cmd_Cancelar);
            Controls.Add(Label1);
            Controls.Add(Cmd_Nuevo);
            Controls.Add(Cmd_Consultar);
            Controls.Add(Cmd_Anular);
            Controls.Add(Cmd_Guardar);
            Controls.Add(groupBox2);
            Controls.Add(GroupBox1);
            Controls.Add(Btn_Cerrar);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_Entrada";
            Text = "Frm_Entrada";
            FormClosing += Frm_Entrada_FormClosing;
            Load += Frm_Entrada_Load;
            VisibleChanged += Frm_Entrada_VisibleChanged;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            Fr_Busqueda.ResumeLayout(false);
            Fr_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ep_Error).EndInit();
            ResumeLayout(false);
            PerformLayout();

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