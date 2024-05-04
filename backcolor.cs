using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Santral_Rehberi
{
    public static class GradientBackground
    {
        public static void Apply(Form form, Color color1, Color color2, LinearGradientMode mode)
        {
            form.Paint += (sender, e) =>
            {
                Rectangle rect = new Rectangle(0, 0, form.Width, form.Height);
                using (Brush brush = new LinearGradientBrush(rect, color1, color2, mode))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            };
        }
    }
}
