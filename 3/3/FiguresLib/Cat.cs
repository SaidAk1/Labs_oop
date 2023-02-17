using System.Collections.Generic;
using System.Drawing;

namespace FiguresLib
{
    public class Cat : Rectangle
    {
        public Square square1;
        public Circle circle1;
        public Ellipse ellipse1;
        public Triangle triangle1;
        public Triangle triangle2;
        public Triangle triangle3;
        public List<Figure> figures;

        public Cat(int id, int x, int y, int w, int h) : base(id, x, y, w, h)
        {
            name = "Cat";
            figures = new List<Figure>();
            triangle1 = new Triangle(x, y, x + 30, y + 10, x + 12, y + 30);
            triangle2 = new Triangle(x + 58, y + 10, x + 88, y, x + 73, y + 30);
            circle1 = new Circle(0, x + 18, y + 11, 25);
            triangle3 = new Triangle(x + 45, y + 65, x + 45, y + 160, x + 130, y + 160);
            square1 = new Square(0, x + 25, y + 140, 20);
            Figure[] temp = { triangle1, triangle2, triangle3, circle1, square1 };
            figures.AddRange(temp);

        }
        public override void Draw()
        {
            Init.pen.Color = Color.Orange;
            foreach (Figure figure in figures)
            {
                figure.Draw();
            }
            ellipse1 = new Ellipse(0, x + 120, y + 98, 15, 30);
            ellipse1.matrix.RotateAt(30, new Point(x + 130, y + 150));
            ellipse1.Draw();
            Init.pen.Color = Color.Black;
        }
        public override void MoveTo(int x, int y)
        {
            Init.Clear();
            this.x += x;
            this.y += y;
            for (int i = 0; i < 5; i++)
            {
                Figure figure = figures[i];
                if (figure.points != null)
                {
                    for (int j = 0; j < figure.points.Length; j++)
                    {
                        figure.points[j].X += x;
                        figure.points[j].Y += y;
                    }
                    figure.x = figure.points[0].X;
                    figure.y = figure.points[0].Y;
                }
                else
                {
                    figure.x += x;
                    figure.y += y;
                }

            }
            ellipse1.x += x;
            ellipse1.y += y;
            this.Draw();
            foreach (Figure f in ShapeContainer.figureList)
            {
                f.Draw();
            }
        }
    }
}
