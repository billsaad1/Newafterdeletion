using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanitarianProjectManagement.UI
{
    public static class ApplicationStyleManager
    {
        public static event EventHandler LanguageChanged;

        public static void SetLanguage(string language)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            LanguageChanged?.Invoke(null, EventArgs.Empty);
        }

        public static void InitializeModernTheme(Form form)
        {
            // Apply modern theme colors
            form.BackColor = Color.FromArgb(249, 250, 251);

            // Apply modern font
            form.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        }

        public static void ApplyCardStyling(Panel panel)
        {
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Paint += (sender, e) =>
            {
                var rect = panel.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;
                using (var pen = new Pen(Color.FromArgb(229, 231, 235), 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };
        }

        public static void StyleStatCard(Panel card, Color backgroundColor)
        {
            card.BackColor = backgroundColor;
            card.Paint += (sender, e) =>
            {
                // Add subtle rounded corner effect
                var rect = card.ClientRectangle;
                int radius = 10; // Adjust the radius for more or less rounded corners
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                e.Graphics.FillPath(new SolidBrush(backgroundColor), path);
            };
        }
    }
}
