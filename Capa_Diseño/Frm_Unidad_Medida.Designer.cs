namespace Capa_Diseño
{
    partial class Frm_Unidad_Medida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Unidad_Medida));
            this.Cmd_Cancelar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Cmd_Nuevo = new System.Windows.Forms.Button();
            this.Cmd_Editar = new System.Windows.Forms.Button();
            this.Cmd_Guardar = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Txt_Filtro = new System.Windows.Forms.TextBox();
            this.Lbl_Contador = new System.Windows.Forms.Label();
            this.Lv_Datos = new System.Windows.Forms.ListView();
            this.Imagenes = new System.Windows.Forms.ImageList(this.components);
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Chk_Estado = new System.Windows.Forms.CheckBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
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
            this.Cmd_Cancelar.Location = new System.Drawing.Point(610, 63);
            this.Cmd_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Cmd_Cancelar.Name = "Cmd_Cancelar";
            this.Cmd_Cancelar.Size = new System.Drawing.Size(171, 37);
            this.Cmd_Cancelar.TabIndex = 116;
            this.Cmd_Cancelar.Text = "Cancelar";
            this.Cmd_Cancelar.UseVisualStyleBackColor = false;
            this.Cmd_Cancelar.Click += new System.EventHandler(this.Cmd_Cancelar_Click);
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
            this.Label1.Size = new System.Drawing.Size(378, 23);
            this.Label1.TabIndex = 121;
            this.Label1.Text = "Registro de las Unidades de Medidas:";
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
            this.Cmd_Nuevo.TabIndex = 114;
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
            this.Cmd_Editar.Location = new System.Drawing.Point(911, 63);
            this.Cmd_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.Cmd_Editar.Name = "Cmd_Editar";
            this.Cmd_Editar.Size = new System.Drawing.Size(171, 37);
            this.Cmd_Editar.TabIndex = 117;
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
            this.Cmd_Guardar.Location = new System.Drawing.Point(313, 63);
            this.Cmd_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Cmd_Guardar.Name = "Cmd_Guardar";
            this.Cmd_Guardar.Size = new System.Drawing.Size(171, 37);
            this.Cmd_Guardar.TabIndex = 115;
            this.Cmd_Guardar.Text = "Guardar";
            this.Cmd_Guardar.UseVisualStyleBackColor = false;
            this.Cmd_Guardar.Click += new System.EventHandler(this.Cmd_Guardar_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.Txt_Codigo);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Txt_Filtro);
            this.GroupBox1.Controls.Add(this.Lbl_Contador);
            this.GroupBox1.Controls.Add(this.Lv_Datos);
            this.GroupBox1.Controls.Add(this.Txt_Descripcion);
            this.GroupBox1.Controls.Add(this.Chk_Estado);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(23, 108);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(1355, 590);
            this.GroupBox1.TabIndex = 120;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos Generales de los Clientes:";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_Codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Codigo.Location = new System.Drawing.Point(191, 32);
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
            this.Label9.Size = new System.Drawing.Size(286, 20);
            this.Label9.TabIndex = 45;
            this.Label9.Text = "Buscar Por Código o Descripción:";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Filtro
            // 
            this.Txt_Filtro.BackColor = System.Drawing.Color.White;
            this.Txt_Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Filtro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Filtro.Location = new System.Drawing.Point(305, 551);
            this.Txt_Filtro.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Filtro.Name = "Txt_Filtro";
            this.Txt_Filtro.Size = new System.Drawing.Size(809, 25);
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
            // Lv_Datos
            // 
            this.Lv_Datos.BackColor = System.Drawing.Color.Thistle;
            this.Lv_Datos.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Datos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lv_Datos.FullRowSelect = true;
            this.Lv_Datos.GridLines = true;
            this.Lv_Datos.LabelWrap = false;
            this.Lv_Datos.Location = new System.Drawing.Point(15, 98);
            this.Lv_Datos.Margin = new System.Windows.Forms.Padding(4);
            this.Lv_Datos.MultiSelect = false;
            this.Lv_Datos.Name = "Lv_Datos";
            this.Lv_Datos.ShowGroups = false;
            this.Lv_Datos.Size = new System.Drawing.Size(1327, 444);
            this.Lv_Datos.SmallImageList = this.Imagenes;
            this.Lv_Datos.StateImageList = this.Imagenes;
            this.Lv_Datos.TabIndex = 42;
            this.Lv_Datos.UseCompatibleStateImageBehavior = false;
            this.Lv_Datos.View = System.Windows.Forms.View.Details;
            this.Lv_Datos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Lv_Datos_ItemSelectionChanged);
            this.Lv_Datos.DoubleClick += new System.EventHandler(this.Lv_Datos_DoubleClick);
            // 
            // Imagenes
            // 
            this.Imagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Imagenes.ImageStream")));
            this.Imagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.Imagenes.Images.SetKeyName(0, "Cerrar.ico");
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.White;
            this.Txt_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.Location = new System.Drawing.Point(191, 65);
            this.Txt_Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(1125, 25);
            this.Txt_Descripcion.TabIndex = 34;
            this.Txt_Descripcion.WordWrap = false;
            this.Txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Descripcion_KeyPress);
            // 
            // Chk_Estado
            // 
            this.Chk_Estado.AutoSize = true;
            this.Chk_Estado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Estado.ForeColor = System.Drawing.Color.White;
            this.Chk_Estado.Location = new System.Drawing.Point(371, 33);
            this.Chk_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.Chk_Estado.Name = "Chk_Estado";
            this.Chk_Estado.Size = new System.Drawing.Size(88, 24);
            this.Chk_Estado.TabIndex = 41;
            this.Chk_Estado.Text = "Estado";
            this.Chk_Estado.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(63, 68);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(114, 20);
            this.Label7.TabIndex = 33;
            this.Label7.Text = "Descripción:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(107, 32);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(74, 20);
            this.Label8.TabIndex = 31;
            this.Label8.Text = "Código:";
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
            this.Btn_Cerrar.TabIndex = 118;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(23, 39);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(375, 5);
            this.PictureBox1.TabIndex = 122;
            this.PictureBox1.TabStop = false;
            // 
            // ep_Error
            // 
            this.ep_Error.ContainerControl = this;
            // 
            // Frm_Unidad_Medida
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
            this.Name = "Frm_Unidad_Medida";
            this.Text = "Frm_Unidad_Medida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Unidad_Medida_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Unidad_Medida_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Unidad_Medida_VisibleChanged);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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