using System.Collections.Generic;
using System.Drawing;

namespace FiguresLib
{
    public class Olymp : Rectangle
    {
        public Ellipse ellipse1;
        public Ellipse ellipse2;
        public Ellipse ellipse3;
        public Ellipse ellipse4;
        public Ellipse ellipse5;
        public List<Figure> figures = new List<Figure>();

        public Olymp(int id, int x, int y, int scale_x, int scale_y) : base(id, x, y, 70 * scale_x, 50 * scale_y)
        {
            ellipse1 = new Ellipse(0, x, y, 15 * scale_x, 15 * scale_y);
            ellipse2 = new Ellipse(0, x + 20 * scale_x, y, 15 * scale_x, 15 * scale_y);
            ellipse3 = new Ellipse(0, x + 40 * scale_x, y, 15 * scale_x, 15 * scale_y);
            ellipse4 = new Ellipse(0, x + 10 * scale_x, y + 20 * scale_y, 15 * scale_x, 15 * scale_y);
            ellipse5 = new Ellipse(0, x + 30 * scale_x, y + 20 * scale_y, 15 * scale_x, 15 * scale_y);
            Figure[] temp = { ellipse1, ellipse2, ellipse3, ellipse4, ellipse5 };
            figures.AddRange(temp);
            name = "Olymp";
        }
        public override void Draw()
        {
            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        Init.pen.Color = Color.Blue;
                        ellipse1.Draw();
                        break;
                    case 1:
                        Init.pen.Color = Color.Black;
                        ellipse2.Draw();
                        break;
                    case 2:
                        Init.pen.Color = Color.Red;
                        ellipse3.Draw();
                        break;
                    case 3:
                        Init.pen.Color = Color.Yellow;
                        ellipse4.Draw();
                        break;
                    case 4:
                        Init.pen.Color = Color.Green;
                        ellipse5.Draw();
                        break;
                }
            }
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
            this.Draw();
            foreach (Figure f in ShapeContainer.figureList)
            {
                f.Draw();
            }
        }
    }
}
