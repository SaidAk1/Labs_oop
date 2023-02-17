using FiguresLib;
using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int r1 = int.Parse(el_r1.Text);
                int r2 = int.Parse(el_r2.Text);
                if (Init.figuresListBox.SelectedIndex != -1)
                {
                    Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                    if (figure.ToString() == "FiguresLib.Ellipse")
                    {
                        if (Init.Coords_check(figure.x, figure.y, r1 * 2, r2 * 2))
                        {
                            figure.w = r1 * 2;
                            figure.h = r2 * 2;
                            figure.DeleteF(figure, false);
                            figure.Draw();
                        }
                        else
                        {
                            MessageBox.Show("Figure out of bounds");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected not a ellipse");
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
    }
}
