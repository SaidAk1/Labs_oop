using System;
using FiguresLib;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Polygon_form : Form
    {
        int i;
        int numPoints;
        bool flag;
        Point[] points;
        Form1 form_1;
        public Polygon_form(Form1 form_1)
        {
            InitializeComponent();
            this.form_1 = form_1;
            this.flag = false;
            this.i = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.flag == false)
            {
                try
                {
                    this.numPoints = int.Parse(dots_count.Text);
                    if (this.numPoints <= 2 )
                    {
                        MessageBox.Show("Wrong input");
                        this.numPoints = 0;
                    }
                    else
                    {
                        this.points = new Point[numPoints];
                        this.flag = true;
                        dots_count.Enabled = false;
                        dot_x.Enabled = true;
                        dot_y.Enabled = true;
                        label3.Text = $"Point {i + 1} coordinates:";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong input");
                }
            }
            else
            {
                try
                {
                    int x = int.Parse(dot_x.Text);
                    int y = int.Parse(dot_y.Text);
                    if (i < numPoints - 1)
                    {
                        this.points[i].X = x;
                        this.points[i].Y = y;
                        i += 1;
                        label3.Text = $"Point {i + 1} coordinates:";
                    }
                    else
                    {
                        this.points[i].X = x;
                        this.points[i].Y = y;
                        btnAdd.Enabled = false;
                        btnDraw.Enabled = true;
                        this.flag = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong input");
                }
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (Init.Coords_check(points, 0, 0))
            {
                form_1.poly_count += 1;
                Polygon polygon = new Polygon(form_1.poly_count, points);
                ShapeContainer.AddFigure(polygon);
                Init.bs.ResetBindings(false);
                polygon.Draw();
                this.Close();
            }
            else
            {
                MessageBox.Show("Figure out of bounds");
                this.Close();
            }
        }
    }
}
