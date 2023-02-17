using System.Drawing;

namespace FiguresLib
{
    public class Rectangle : Figure
    {
        public Rectangle(string name, int x, int y, int w, int h) : base(name, x, y)
        {
            this.w = w;
            this.h = h;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, x, y, w, h);
            Init.mainCanvas.Image = Init.bitmap;
        }
        public override bool Coords_check(int x, int y)
        {
            if ((this.x + x > 0) & (this.y + y > 0) & (this.x + x + w < Init.mainCanvas.Width) &
                (this.y + y + h < Init.mainCanvas.Height))
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
