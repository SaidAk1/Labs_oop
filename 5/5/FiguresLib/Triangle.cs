using System.Drawing;

namespace FiguresLib
{
    public class Triangle : Polygon
    {
        public Triangle(int id, Point[] points) : base(id, points)
        {
            name = "Triangle";
        }
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
        {
            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            Point point3 = new Point(x3, y3);
            Point[] points = { point1, point2, point3 };
            this.points = points;
            name = "Triangle";
        }
    }
}
