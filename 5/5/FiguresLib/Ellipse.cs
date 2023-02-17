using System.Drawing;

namespace FiguresLib
{
    public class Ellipse : Figure
    {
        public Ellipse(int id, int x, int y, int r1, int r2) : base(id, x, y)
        {
            w = r1 * 2;
            h = r2 * 2;
            name = "Ellipse";
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Transform = matrix;
            g.DrawEllipse(Init.pen, x, y, w, h);
            Init.mainCanvas.Image = Init.bitmap;
        }
        public override bool Coords_check(int x, int y)
        {
            if (!((x < 0) || (y < 0) || (x + w > Init.mainCanvas.Width) || (y + h > Init.mainCanvas.Height)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
