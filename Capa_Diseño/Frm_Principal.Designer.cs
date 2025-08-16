namespace Capa_Diseño
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            Mns_Menu = new MenuStrip();
            Mnu_Registrar = new ToolStripMenuItem();
            Mnu_Reg_Clientes = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            Mnu_Reg_Proveedore = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            Mnu_Reg_Medicamentos = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            Btn_Unidad_Medida = new ToolStripMenuItem();
            Mnu_Transacciones = new ToolStripMenuItem();
            Mnu_Trans_Entrada = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            Mnu_Trans_Facturar = new ToolStripMenuItem();
            Mnu_Reportes = new ToolStripMenuItem();
            Mnu_Rpt_Generales = new ToolStripMenuItem();
            Mnu_Rpt_Clientes = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            Mnu_Rpt_Proveedores = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            Mnu_Rpt_Productos = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            Mnu_Rpt_Especificos = new ToolStripMenuItem();
            Mnu_Rpt_Entradas = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            Mnu_Rpt_Facturas = new ToolStripMenuItem();
            Mnu_Administrador = new ToolStripMenuItem();
            Mnu_Admin_Usuarios = new ToolStripMenuItem();
            Mnu_Acerca = new ToolStripMenuItem();
            Mnu_Salir = new ToolStripMenuItem();
            Panel_1 = new ToolStripStatusLabel();
            Panel_2 = new ToolStripStatusLabel();
            Panel_3 = new ToolStripStatusLabel();
            Stb_Barra_Estado = new StatusStrip();
            Mns_Menu.SuspendLayout();
            Stb_Barra_Estado.SuspendLayout();
            SuspendLayout();
            // 
            // Mns_Menu
            // 
            Mns_Menu.BackgroundImage = (Image)resources.GetObject("Mns_Menu.BackgroundImage");
            Mns_Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mns_Menu.ImageScalingSize = new Size(20, 20);
            Mns_Menu.Items.AddRange(new ToolStripItem[] { Mnu_Registrar, Mnu_Transacciones, Mnu_Reportes, Mnu_Administrador, Mnu_Acerca, Mnu_Salir });
            Mns_Menu.Location = new Point(0, 0);
            Mns_Menu.Name = "Mns_Menu";
            Mns_Menu.Padding = new Padding(7, 2, 0, 2);
            Mns_Menu.Size = new Size(1004, 31);
            Mns_Menu.TabIndex = 1;
            Mns_Menu.Text = "menuStrip1";
            Mns_Menu.Visible = false;
            // 
            // Mnu_Registrar
            // 
            Mnu_Registrar.DropDownItems.AddRange(new ToolStripItem[] { Mnu_Reg_Clientes, toolStripSeparator2, Mnu_Reg_Proveedore, toolStripSeparator3, Mnu_Reg_Medicamentos, toolStripSeparator8, Btn_Unidad_Medida });
            Mnu_Registrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mnu_Registrar.ForeColor = Color.Black;
            Mnu_Registrar.Image = (Image)resources.GetObject("Mnu_Registrar.Image");
            Mnu_Registrar.Name = "Mnu_Registrar";
            Mnu_Registrar.Size = new Size(105, 27);
            Mnu_Registrar.Text = "Registrar";
            // 
            // Mnu_Reg_Clientes
            // 
            Mnu_Reg_Clientes.Image = (Image)resources.GetObject("Mnu_Reg_Clientes.Image");
            Mnu_Reg_Clientes.Name = "Mnu_Reg_Clientes";
            Mnu_Reg_Clientes.Size = new Size(212, 24);
            Mnu_Reg_Clientes.Text = "Clientes";
            Mnu_Reg_Clientes.Click += Mnu_Reg_Clientes_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(209, 6);
            // 
            // Mnu_Reg_Proveedore
            // 
            Mnu_Reg_Proveedore.Image = (Image)resources.GetObject("Mnu_Reg_Proveedore.Image");
            Mnu_Reg_Proveedore.Name = "Mnu_Reg_Proveedore";
            Mnu_Reg_Proveedore.Size = new Size(212, 24);
            Mnu_Reg_Proveedore.Text = "Proveedores";
            Mnu_Reg_Proveedore.Click += Mnu_Reg_Proveedore_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(209, 6);
            // 
            // Mnu_Reg_Medicamentos
            // 
            Mnu_Reg_Medicamentos.Image = (Image)resources.GetObject("Mnu_Reg_Medicamentos.Image");
            Mnu_Reg_Medicamentos.Name = "Mnu_Reg_Medicamentos";
            Mnu_Reg_Medicamentos.Size = new Size(212, 24);
            Mnu_Reg_Medicamentos.Text = "Médicamentos";
            Mnu_Reg_Medicamentos.Click += Mnu_Reg_Medicamentos_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(209, 6);
            // 
            // Btn_Unidad_Medida
            // 
            Btn_Unidad_Medida.Image = (Image)resources.GetObject("Btn_Unidad_Medida.Image");
            Btn_Unidad_Medida.Name = "Btn_Unidad_Medida";
            Btn_Unidad_Medida.Size = new Size(212, 24);
            Btn_Unidad_Medida.Text = "Unidad de Medidas";
            Btn_Unidad_Medida.Click += Btn_Unidad_Medida_Click;
            // 
            // Mnu_Transacciones
            // 
            Mnu_Transacciones.DropDownItems.AddRange(new ToolStripItem[] { Mnu_Trans_Entrada, toolStripSeparator7, Mnu_Trans_Facturar });
            Mnu_Transacciones.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mnu_Transacciones.ForeColor = Color.Black;
            Mnu_Transacciones.Image = (Image)resources.GetObject("Mnu_Transacciones.Image");
            Mnu_Transacciones.Name = "Mnu_Transacciones";
            Mnu_Transacciones.Size = new Size(138, 27);
            Mnu_Transacciones.Text = "Transacciones";
            // 
            // Mnu_Trans_Entrada
            // 
            Mnu_Trans_Entrada.Image = (Image)resources.GetObject("Mnu_Trans_Entrada.Image");
            Mnu_Trans_Entrada.Name = "Mnu_Trans_Entrada";
            Mnu_Trans_Entrada.ShortcutKeys = Keys.Control | Keys.E;
            Mnu_Trans_Entrada.Size = new Size(311, 24);
            Mnu_Trans_Entrada.Text = "Estrada de Médicamentos";
            Mnu_Trans_Entrada.Click += Mnu_Trans_Entrada_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(308, 6);
            // 
            // Mnu_Trans_Facturar
            // 
            Mnu_Trans_Facturar.Image = (Image)resources.GetObject("Mnu_Trans_Facturar.Image");
            Mnu_Trans_Facturar.Name = "Mnu_Trans_Facturar";
            Mnu_Trans_Facturar.ShortcutKeys = Keys.Control | Keys.F;
            Mnu_Trans_Facturar.Size = new Size(311, 24);
            Mnu_Trans_Facturar.Text = "Facturar";
            Mnu_Trans_Facturar.Click += Mnu_Trans_Facturar_Click;
            // 
            // Mnu_Reportes
            // 
            Mnu_Reportes.DropDownItems.AddRange(new ToolStripItem[] { Mnu_Rpt_Generales, toolStripSeparator1, Mnu_Rpt_Especificos });
            Mnu_Reportes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mnu_Reportes.ForeColor = Color.Black;
            Mnu_Reportes.Image = (Image)resources.GetObject("Mnu_Reportes.Image");
            Mnu_Reportes.Name = "Mnu_Reportes";
            Mnu_Reportes.Size = new Size(104, 27);
            Mnu_Reportes.Text = "Reportes";
            // 
            // Mnu_Rpt_Generales
            // 
            Mnu_Rpt_Generales.DropDownItems.AddRange(new ToolStripItem[] { Mnu_Rpt_Clientes, toolStripSeparator4, Mnu_Rpt_Proveedores, toolStripSeparator5, Mnu_Rpt_Productos });
            Mnu_Rpt_Generales.Image = (Image)resources.GetObject("Mnu_Rpt_Generales.Image");
            Mnu_Rpt_Generales.Name = "Mnu_Rpt_Generales";
            Mnu_Rpt_Generales.Size = new Size(154, 24);
            Mnu_Rpt_Generales.Text = "Generales";
            // 
            // Mnu_Rpt_Clientes
            // 
            Mnu_Rpt_Clientes.Image = (Image)resources.GetObject("Mnu_Rpt_Clientes.Image");
            Mnu_Rpt_Clientes.Name = "Mnu_Rpt_Clientes";
            Mnu_Rpt_Clientes.Size = new Size(241, 24);
            Mnu_Rpt_Clientes.Text = "Listado de Clientes";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(238, 6);
            // 
            // Mnu_Rpt_Proveedores
            // 
            Mnu_Rpt_Proveedores.Image = (Image)resources.GetObject("Mnu_Rpt_Proveedores.Image");
            Mnu_Rpt_Proveedores.Name = "Mnu_Rpt_Proveedores";
            Mnu_Rpt_Proveedores.Size = new Size(241, 24);
            Mnu_Rpt_Proveedores.Text = "Listado de Proveedores";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(238, 6);
            // 
            // Mnu_Rpt_Productos
            // 
            Mnu_Rpt_Productos.Image = (Image)resources.GetObject("Mnu_Rpt_Productos.Image");
            Mnu_Rpt_Productos.Name = "Mnu_Rpt_Productos";
            Mnu_Rpt_Productos.Size = new Size(241, 24);
            Mnu_Rpt_Productos.Text = "Listado de Productos";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(151, 6);
            // 
            // Mnu_Rpt_Especificos
            // 
            Mnu_Rpt_Especificos.DropDownItems.AddRange(new ToolStripItem[] { Mnu_Rpt_Entradas, toolStripSeparator6, Mnu_Rpt_Facturas });
            Mnu_Rpt_Especificos.Image = (Image)resources.GetObject("Mnu_Rpt_Especificos.Image");
            Mnu_Rpt_Especificos.Name = "Mnu_Rpt_Especificos";
            Mnu_Rpt_Especificos.Size = new Size(154, 24);
            Mnu_Rpt_Especificos.Text = "Específicos";
            // 
            // Mnu_Rpt_Entradas
            // 
            Mnu_Rpt_Entradas.Image = (Image)resources.GetObject("Mnu_Rpt_Entradas.Image");
            Mnu_Rpt_Entradas.Name = "Mnu_Rpt_Entradas";
            Mnu_Rpt_Entradas.Size = new Size(215, 24);
            Mnu_Rpt_Entradas.Text = "Listado de Entradas";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(212, 6);
            // 
            // Mnu_Rpt_Facturas
            // 
            Mnu_Rpt_Facturas.Image = (Image)resources.GetObject("Mnu_Rpt_Facturas.Image");
            Mnu_Rpt_Facturas.Name = "Mnu_Rpt_Facturas";
            Mnu_Rpt_Facturas.Size = new Size(215, 24);
            Mnu_Rpt_Facturas.Text = "Listado de Facturas";
            // 
            // Mnu_Administrador
            // 
            Mnu_Administrador.DropDownItems.AddRange(new ToolStripItem[] { Mnu_Admin_Usuarios });
            Mnu_Administrador.Image = (Image)resources.GetObject("Mnu_Administrador.Image");
            Mnu_Administrador.Name = "Mnu_Administrador";
            Mnu_Administrador.Size = new Size(129, 27);
            Mnu_Administrador.Text = "Administrador";
            // 
            // Mnu_Admin_Usuarios
            // 
            Mnu_Admin_Usuarios.Image = (Image)resources.GetObject("Mnu_Admin_Usuarios.Image");
            Mnu_Admin_Usuarios.Name = "Mnu_Admin_Usuarios";
            Mnu_Admin_Usuarios.Size = new Size(133, 26);
            Mnu_Admin_Usuarios.Text = "Usuarios";
            Mnu_Admin_Usuarios.Click += Mnu_Admin_Usuarios_Click;
            // 
            // Mnu_Acerca
            // 
            Mnu_Acerca.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mnu_Acerca.ForeColor = Color.Black;
            Mnu_Acerca.Image = (Image)resources.GetObject("Mnu_Acerca.Image");
            Mnu_Acerca.Name = "Mnu_Acerca";
            Mnu_Acerca.Size = new Size(88, 27);
            Mnu_Acerca.Text = "Acerca";
            // 
            // Mnu_Salir
            // 
            Mnu_Salir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mnu_Salir.ForeColor = Color.Black;
            Mnu_Salir.Image = (Image)resources.GetObject("Mnu_Salir.Image");
            Mnu_Salir.Name = "Mnu_Salir";
            Mnu_Salir.Size = new Size(71, 27);
            Mnu_Salir.Text = "Salir";
            Mnu_Salir.Click += Mnu_Salir_Click;
            // 
            // Panel_1
            // 
            Panel_1.AutoSize = false;
            Panel_1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Panel_1.ForeColor = Color.Black;
            Panel_1.Name = "Panel_1";
            Panel_1.Size = new Size(610, 24);
            Panel_1.Text = "Usuario:";
            Panel_1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Panel_2
            // 
            Panel_2.AutoSize = false;
            Panel_2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Panel_2.ForeColor = Color.Black;
            Panel_2.Image = (Image)resources.GetObject("Panel_2.Image");
            Panel_2.ImageAlign = ContentAlignment.MiddleRight;
            Panel_2.Name = "Panel_2";
            Panel_2.Size = new Size(320, 24);
            Panel_2.Text = "Fecha:";
            Panel_2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Panel_3
            // 
            Panel_3.AutoSize = false;
            Panel_3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Panel_3.ForeColor = Color.Black;
            Panel_3.Name = "Panel_3";
            Panel_3.Size = new Size(320, 20);
            Panel_3.Text = "Hora:";
            Panel_3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Stb_Barra_Estado
            // 
            Stb_Barra_Estado.AutoSize = false;
            Stb_Barra_Estado.BackgroundImage = (Image)resources.GetObject("Stb_Barra_Estado.BackgroundImage");
            Stb_Barra_Estado.ImageScalingSize = new Size(20, 20);
            Stb_Barra_Estado.Items.AddRange(new ToolStripItem[] { Panel_1, Panel_2, Panel_3 });
            Stb_Barra_Estado.Location = new Point(0, 545);
            Stb_Barra_Estado.Name = "Stb_Barra_Estado";
            Stb_Barra_Estado.Padding = new Padding(1, 0, 17, 0);
            Stb_Barra_Estado.RenderMode = ToolStripRenderMode.Professional;
            Stb_Barra_Estado.RightToLeft = RightToLeft.No;
            Stb_Barra_Estado.Size = new Size(1004, 29);
            Stb_Barra_Estado.TabIndex = 2;
            Stb_Barra_Estado.Text = "statusStrip1";
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 574);
            Controls.Add(Stb_Barra_Estado);
            Controls.Add(Mns_Menu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = Mns_Menu;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Principal";
            Text = "FARMACIA LA MJ - SISTEMA DE FACTURACIÓN";
            WindowState = FormWindowState.Maximized;
            FormClosing += Frm_Principal_FormClosing;
            Load += Frm_Principal_Load;
            Mns_Menu.ResumeLayout(false);
            Mns_Menu.PerformLayout();
            Stb_Barra_Estado.ResumeLayout(false);
            Stb_Barra_Estado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem Mnu_Registrar;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Transacciones;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Reportes;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Acerca;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Salir;
        private System.Windows.Forms.ToolStripStatusLabel Panel_1;
        private System.Windows.Forms.ToolStripStatusLabel Panel_2;
        private System.Windows.Forms.ToolStripStatusLabel Panel_3;
        protected System.Windows.Forms.StatusStrip Stb_Barra_Estado;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Rpt_Generales;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Rpt_Clientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Rpt_Especificos;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Administrador;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Admin_Usuarios;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Reg_Clientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Reg_Proveedore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Reg_Medicamentos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Rpt_Proveedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Rpt_Productos;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Rpt_Entradas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Rpt_Facturas;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Trans_Entrada;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Trans_Facturar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem Btn_Unidad_Medida;
        public System.Windows.Forms.MenuStrip Mns_Menu;
    }
}

