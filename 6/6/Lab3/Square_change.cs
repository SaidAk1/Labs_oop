using FiguresLib;
using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Square_change : Form
    {
        public Square_change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int w = int.Parse(sq_w.Text);
                if (Init.figuresListBox.SelectedIndex != -1)
                {
                    Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                    if (figure.ToString() == "FiguresLib.Square")
                    {
                        if (Init.Coords_check(figure.x, figure.y, w, w))
                        {
                            figure.w = w;
                            figure.h = w;
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
                        MessageBox.Show("Selected not a square");
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
