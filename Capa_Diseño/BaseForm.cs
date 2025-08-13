using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño
{
    public partial class BaseForm : Form
    {

        private Panel header = null!;
        private Label title = null!;
        private Button btnMin = null!;
        private Button btnClose = null!;

        // 0 = sin esquinas redondeadas
        protected virtual int CornerRadius => 10;
        public BaseForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.Padding = new Padding(1);
            this.BackColor = Theme.FormBg;
            this.Font = new Font("Segoe UI", 10f, FontStyle.Regular);

            ConfigureChrome(); // barra superior
            ApplyTheme();      // aplicar estilos

            this.HandleCreated += (_, __) => ApplyRoundCorners();
            this.Resize += (_, __) => ApplyRoundCorners();
            this.TextChanged += (_, __) => title.Text = this.Text;
            this.Paint += BaseForm_PaintBorder;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
        private void BaseForm_PaintBorder(object? sender, PaintEventArgs e)
        {
            using var pen = new Pen(Color.FromArgb(230, 232, 236));
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }

        // Fondo del cuerpo con degradado suave
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (header == null) { base.OnPaintBackground(e); return; }

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int top = header.Height;
            var rect = new Rectangle(0, top, this.ClientSize.Width, this.ClientSize.Height - top);
            if (rect.Width <= 0 || rect.Height <= 0) { base.OnPaintBackground(e); return; }

            using var lg = new LinearGradientBrush(
            rect,
            Color.FromArgb(178, 66, 45),   // verde oscuro arriba
            Color.FromArgb(254, 240, 225),   // naranja abajo
            LinearGradientMode.Vertical);

            g.FillRectangle(lg, rect);
        }

        private void ConfigureChrome()
        {
            // Header con degradado (naranja -> verde usando la paleta del Theme)
            header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 40
            };
            header.MouseDown += Header_MouseDown;
            header.Paint += (s, e) =>
            {
                using var brush = new LinearGradientBrush(
                    header.ClientRectangle,
                    Theme.BtnHoverBg,   // naranja
                    Theme.BtnBg,        // verde
                    LinearGradientMode.Horizontal);
                e.Graphics.FillRectangle(brush, header.ClientRectangle);
            };

            // Título
            title = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                Padding = new Padding(12, 0, 0, 0),
                Text = this.Text
            };

            // Minimizar
            btnMin = new Button
            {
                Text = "—",
                Width = 40,
                Dock = DockStyle.Right,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                TabStop = false,
                UseVisualStyleBackColor = false
            };
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.Click += (_, __) => this.WindowState = FormWindowState.Minimized;

            // Cerrar
            btnClose = new Button
            {
                Text = "✕",
                Width = 40,
                Dock = DockStyle.Right,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                TabStop = false,
                UseVisualStyleBackColor = false
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (_, __) => this.Close();

            // Ensamble
            header.Controls.Add(title);
            header.Controls.Add(btnMin);
            header.Controls.Add(btnClose);
            this.Controls.Add(header);
        }

        protected virtual void ApplyTheme()
        {
            // Aplica colores/estilos a todo el árbol de controles (incluye botones con UseVisualStyleBackColor=false)
            Theme.ApplyTo(this);
        }

        private void ApplyRoundCorners()
        {
            if (CornerRadius <= 0 || this.Width <= 0 || this.Height <= 0)
            {
                this.Region = null;
                return;
            }

            using var path = new GraphicsPath();
            int r = CornerRadius;
            var rect = new Rectangle(0, 0, this.Width, this.Height);

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        // Arrastrar la ventana desde el header (como barra del sistema)
        private void Header_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Capture = false;
            var msg = Message.Create(this.Handle, 0xA1 /*WM_NCLBUTTONDOWN*/, new IntPtr(2)/*HTCAPTION*/, IntPtr.Zero);
            this.DefWndProc(ref msg);
        }
    }
}


