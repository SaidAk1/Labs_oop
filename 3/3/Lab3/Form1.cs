using FiguresLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        int rect_count = 0;
        int sq_count = 0;
        int ellipse_count = 0;
        int circle_count = 0;
        int cat_count = 0;
        public int poly_count = 0;
        public int tri_count = 0;
        public Form1()
        {
            InitializeComponent();
            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 3);
            Init.mainCanvas = pictureBox1;
            Init.figuresListBox = figuresListBox;
            Init.bs = new BindingSource();
            Init.bs.DataSource = ShapeContainer.figureList;
            Init.figuresListBox.DataSource = Init.bs;
            Init.figuresListBox.DisplayMember = "Name";
        }

        private void Rect_create_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(rect_x.Text);
                int y = int.Parse(rect_y.Text);
                int w = int.Parse(rect_w.Text);
                int h = int.Parse(rect_h.Text);
                if (Init.Coords_check(x, y, w, h))
                {
                    rect_count += 1;
                    FiguresLib.Rectangle rectangle = new FiguresLib.Rectangle(rect_count, x, y, w, h);
                    ShapeContainer.AddFigure(rectangle);
                    Init.bs.ResetBindings(false);
                    rectangle.Draw();
                }
                else
                {
                    MessageBox.Show("Figure out of bounds");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void Sq_create_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(sq_x.Text);
                int y = int.Parse(sq_y.Text);
                int w = int.Parse(sq_w.Text);
                if (Init.Coords_check(x, y, w, w))
                {
                    sq_count += 1;
                    Square square = new Square(sq_count, x, y, w);
                    ShapeContainer.AddFigure(square);
                    Init.bs.ResetBindings(false);
                    square.Draw();
                }
                else
                {
                    MessageBox.Show("Figure out of bounds");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void El_create_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(el_x.Text);
                int y = int.Parse(el_y.Text);
                int r1 = int.Parse(el_r1.Text);
                int r2 = int.Parse(el_r2.Text);
                if (Init.Coords_check(x, y, r1 * 2, r2 * 2))
                {
                    ellipse_count += 1;
                    Ellipse ellipse = new Ellipse(ellipse_count, x, y, r1, r2);
                    ShapeContainer.AddFigure(ellipse);
                    Init.bs.ResetBindings(false);
                    ellipse.Draw();
                }
                else
                {
                    MessageBox.Show("Figure out of bounds");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void Circle_create_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(circ_x.Text);
                int y = int.Parse(circ_y.Text);
                int r = int.Parse(circ_r.Text);
                if (Init.Coords_check(x, y, r * 2, r * 2))
                {
                    circle_count += 1;
                    Circle circle = new Circle(circle_count, x, y, r);
                    ShapeContainer.AddFigure(circle);
                    Init.bs.ResetBindings(false);
                    circle.Draw();
                }
                else
                {
                    MessageBox.Show("Figure out of bounds");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input");
            }
        }
        private void Car_create_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(cat_x.Text);
                int y = int.Parse(cat_y.Text);
                if (Init.Coords_check(x, y, 165, 160))
                {
                    cat_count += 1;
                    Cat cat = new Cat(cat_count, x, y, 165, 160);
                    ShapeContainer.AddFigure(cat);
                    Init.bs.ResetBindings(false);
                    cat.Draw();
                }
                else
                {
                    MessageBox.Show("Figure out of bounds");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input");
            }
        }
        private void Polygon_create_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6(this);
            f6.Show();
        }

        private void Triangle_create_Click(object sender, EventArgs e)
        {
            Form f7 = new Form7(this);
            f7.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (Init.figuresListBox.SelectedIndex != -1)
            {
                Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                figure.DeleteF(figure, true);
                Init.bs.ResetBindings(false);
            }
        }

        private void move_button_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(move_x.Text);
                int y = int.Parse(move_y.Text);
                if (Init.figuresListBox.SelectedIndex != -1)
                {
                    Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                    if (figure.Coords_check(x, y))
                    {
                        figure.MoveTo(x, y);
                    }
                    else
                    {
                        MessageBox.Show("Figure out of bounds");
                    }
                }
                else
                {
                    MessageBox.Show("Figure not selected");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.Show();
        }
    }
}
