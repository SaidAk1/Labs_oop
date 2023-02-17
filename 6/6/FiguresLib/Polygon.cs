using System.Drawing;

namespace FiguresLib
{
    public class Polygon : Figure
    {
        public Polygon(int id, Point[] points) : base(id, points[0].X, points[0].Y)
        {
            this.points = points;
            name = "Polygon";
        }
        public Polygon(int id, int x1, int y1) : base(id, x1, y1)
        {
            name = "Polygon";
        }
        public Polygon(int x1, int y1) : base(0, x1, y1)
        {
            name = "Polygon";
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Transform = matrix;
            g.DrawPolygon(Init.pen, points);
            Init.mainCanvas.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += x;
                points[i].Y += y;
            }
            this.x = points[0].X;
            this.y = points[0].Y;
            this.DeleteF(this, false);
            this.Draw();
        }
        public override bool Coords_check(int x, int y)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if ((points[i].X + x < 0) || (points[i].Y + y < 0) || (points[i].X + x > Init.mainCanvas.Width) ||
                    (points[i].Y + y > Init.mainCanvas.Height))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
