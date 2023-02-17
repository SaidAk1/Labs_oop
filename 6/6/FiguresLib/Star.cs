using System.Drawing;

namespace FiguresLib
{
    public class Star : Polygon
    {
        public Star(int id, int x, int y, int scale_x, int scale_y) : base(id, x, y)
        {
            w = 50 * scale_x;
            h = 50 * scale_y;
            Point point1 = new Point(x + 25 * scale_x, y);
            Point point2 = new Point(x, y + 20 * scale_y);
            Point point3 = new Point(x + 15 * scale_x, y + 20 * scale_y);
            Point point4 = new Point(x + 35 * scale_x, y + 20 * scale_y);
            Point point5 = new Point(x + 50 * scale_x, y + 20 * scale_y);
            Point point6 = new Point(x + 15 * scale_x, y + 30 * scale_y);
            Point point7 = new Point(x + 35 * scale_x, y + 30 * scale_y);
            Point point8 = new Point(x + 25 * scale_x, y + 40 * scale_y);
            Point point9 = new Point(x + 5 * scale_x, y + 50 * scale_y);
            Point point10 = new Point(x + 45 * scale_x, y + 50 * scale_y);
            Point[] points = { point1, point4, point5, point7, point10, point8, point9, point6, point2, point3, point1 };
            this.points = points;
            name = "Star";
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Transform = matrix;
            g.DrawLines(Init.pen, points);
            Init.mainCanvas.Image = Init.bitmap;
        }
    }
}
