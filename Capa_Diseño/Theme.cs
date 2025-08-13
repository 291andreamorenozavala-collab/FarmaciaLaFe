using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Capa_Diseño
{
    public static class Theme
    {
        // 🎨 Colores principales
        public static Color FormBg = Color.FromArgb(240, 249, 244);   // Verde claro de fondo
        public static Color FormFg = Color.Black;                     // Texto general

        public static Color BtnBg = Color.FromArgb(34, 139, 34);       // Verde intenso
        public static Color BtnFg = Color.White;                       // Texto de botones

        public static Color BtnHoverBg = Color.FromArgb(255, 140, 0);  // Naranja hover
        public static Color BtnHoverFg = Color.White;

        public static Color LabelFg = Color.FromArgb(25, 25, 25);      // Texto oscuro
        public static Color TextBoxBg = Color.White;
        public static Color TextBoxFg = Color.Black;
        public static Color PanelBg = Color.FromArgb(220, 237, 200);   // Verde pálido
        public static Color ProgressBg = Color.LightGray;
        public static Color ProgressFg = Color.FromArgb(255, 140, 0);  // Naranja

        public static void ApplyTo(Control control)
        {
            control.BackColor = FormBg;
            control.ForeColor = FormFg;

            foreach (Control child in control.Controls)
            {
                switch (child)
                {
                    // 🎯 Botones
                    case Button b:
                        b.UseVisualStyleBackColor = false;
                        b.BackColor = BtnBg;
                        b.ForeColor = BtnFg;
                        b.FlatStyle = FlatStyle.Flat;
                        b.FlatAppearance.BorderSize = 0;
                        b.MouseEnter += (s, e) => { b.BackColor = BtnHoverBg; b.ForeColor = BtnHoverFg; };
                        b.MouseLeave += (s, e) => { b.BackColor = BtnBg; b.ForeColor = BtnFg; };
                        break;

                    // 🏷️ Labels
                    case Label lbl:
                        lbl.ForeColor = LabelFg;
                        break;

                    // ✏️ TextBox
                    case TextBox txt:
                        txt.BackColor = TextBoxBg;
                        txt.ForeColor = TextBoxFg;
                        txt.BorderStyle = BorderStyle.FixedSingle;
                        break;

                    // 📦 Paneles
                    case Panel p:
                        p.BackColor = PanelBg;
                        break;

                    // 📊 ProgressBar
                    case ProgressBar pb:
                        pb.ForeColor = ProgressFg;
                        pb.BackColor = ProgressBg;
                        break;
                }

                // Recursivo para aplicar a subcontroles
                if (child.HasChildren)
                    ApplyTo(child);
            }
        }
    }
}