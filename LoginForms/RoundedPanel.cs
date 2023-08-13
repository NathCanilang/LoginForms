using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LoginForms
{
    public class RoundedPanel : Panel
    {
        private int borderRadius = 10; // Adjust this value to control the roundness

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (borderRadius != value)
                {
                    borderRadius = value;
                    Invalidate(); // Redraw the panel when the border radius changes
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(ClientRectangle.Left, ClientRectangle.Top, borderRadius * 2, borderRadius * 2, 180, 90);
                path.AddArc(ClientRectangle.Right - borderRadius * 2, ClientRectangle.Top, borderRadius * 2, borderRadius * 2, 270, 90);
                path.AddArc(ClientRectangle.Right - borderRadius * 2, ClientRectangle.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
                path.AddArc(ClientRectangle.Left, ClientRectangle.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
                path.CloseFigure();

                Region = new Region(path);

                using (Pen pen = new Pen(BackColor, 1))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
