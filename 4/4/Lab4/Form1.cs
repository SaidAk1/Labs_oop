using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FiguresLib;
using Rectangle = FiguresLib.Rectangle;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private Stack<Operator> operators = new Stack<Operator>();
        private Stack<Operand> operands = new Stack<Operand>();
        public Form1()
        {
            InitializeComponent();
            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 3);
            Init.mainCanvas = pictureBox1;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                operators.Clear();
                operands.Clear();

                string input_str = textBox1.Text.Replace(" ", "");
                for (int i = 0; i < input_str.Length; i++)
                {
                    char c = input_str[i];
                    if (IsNotOperation(c))
                    {
                        if (!Char.IsDigit(c))
                        {
                            operands.Push(new Operand(c));
                            while (i < input_str.Length - 1 && IsNotOperation(input_str[i + 1]))
                            {
                                string temp_str = operands.Pop().value.ToString() + input_str[i + 1].ToString();
                                operands.Push(new Operand(temp_str));
                                i++;
                            }
                        }
                        else if (Char.IsDigit(c))
                        {
                            operands.Push(new Operand(c.ToString()));
                            while (i < input_str.Length - 1 && Char.IsDigit(input_str[i + 1])
                                && IsNotOperation(input_str[i + 1]))
                            {
                                int temp_num = Convert.ToInt32(operands.Pop().value.ToString()) * 10 +
                                    (int)Char.GetNumericValue(input_str[i + 1]);
                                operands.Push(new Operand(temp_num));
                                i++;
                            }
                        }
                    }

                    else if ((c == 'R') || (c == 'M') || (c == 'I') || (c == 'D'))
                    {
                        if (operators.Count == 0)
                        {
                            operators.Push(OperatorContainer.FindOperator(c));
                        }
                    }
                    else if (input_str[i] == '(')
                    {
                        operators.Push(OperatorContainer.FindOperator(input_str[i]));
                    }
                    else if (c == ')')
                    {
                        do
                        {
                            if (operators.Peek().symbolOperator == '(')
                            {
                                operators.Pop();
                                break;
                            }
                            if (operators.Count == 0)
                            {
                                break;
                            }
                        }
                        while (operators.Peek().symbolOperator != '(');
                    }
                }

                if (operators.Count > 0)
                {
                    if (IsNotOperation(operators.Peek().symbolOperator))
                    {
                        MessageBox.Show("Entered operation does not exist");
                        comboBox1.Items.Add("Entered operation does not exist");
                    }
                    else
                    {
                        if (OperandsCheck())
                        {
                            SelectingPerformingOperation(operators.Pop());
                        }
                        else
                        {
                            MessageBox.Show("Wrong command arguments");
                            comboBox1.Items.Add("Wrong command arguments");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No operation found");
                    comboBox1.Items.Add("No operation found");
                }
            }
        }
        private void SelectingPerformingOperation(Operator op)
        {
            if (op.symbolOperator == 'R')
            {
                if (operands.Count == 5)
                {
                    int h = Convert.ToInt32(operands.Pop().value.ToString());
                    int w = Convert.ToInt32(operands.Pop().value.ToString());
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    if (Init.Coords_check(x, y, w, h))
                    {
                        Rectangle rectangle = new Rectangle(name, x, y, w, h);
                        ShapeContainer.AddFigure(rectangle);
                        rectangle.Draw();
                        comboBox1.Items.Add($"Rectangle {name} created");
                    }
                    else
                    {
                        MessageBox.Show("Rectangle out of bounds");
                        comboBox1.Items.Add("Rectangle out of bounds");
                    }

                }
                else
                {
                    MessageBox.Show("The R operator takes 5 arguments");
                    comboBox1.Items.Add("The R operator takes 5 arguments");
                }
            }
            else if (op.symbolOperator == 'M')
            {
                if (operands.Count == 3)
                {
                    Rectangle rectangle = null;
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    foreach (Rectangle rect in ShapeContainer.figureList)
                    {
                        if (rect.name == name)
                        {
                            rectangle = rect;
                        }
                    }
                    if (rectangle != null)
                    {
                        if (rectangle.Coords_check(x, y))
                        {
                            rectangle.MoveTo(x, y);
                            comboBox1.Items.Add($"Rectangle {name} moved");
                        }
                        else
                        {
                            MessageBox.Show("Rectangle out of bounds");
                            comboBox1.Items.Add("Rectangle out of bounds");
                        }
                    }
                    else
                    {
                        comboBox1.Items.Add($"Rectnagle {name} not found");
                    }
                }
                else
                {
                    MessageBox.Show("The M operator takes 3 arguments");
                    comboBox1.Items.Add("The M operator takes 3 arguments");
                }
            }
            else if (op.symbolOperator == 'I')
            {
                if (operands.Count == 3)
                {
                    Rectangle rectangle = null;
                    int ch = Convert.ToInt32(operands.Pop().value.ToString());
                    int cw = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    foreach (Rectangle rect in ShapeContainer.figureList)
                    {
                        if (rect.name == name)
                        {
                            rectangle = rect;
                        }
                    }
                    if (rectangle != null)
                    {
                        if (Init.Coords_check(rectangle.x, rectangle.y, cw, ch))
                        {
                            rectangle.w = cw;
                            rectangle.h = ch;
                            rectangle.DeleteF(rectangle, false);
                            rectangle.Draw();
                            comboBox1.Items.Add($"Rectangle {name} changed");
                        }
                        else
                        {
                            MessageBox.Show("Rectangle out of bounds");
                            comboBox1.Items.Add("Rectangle out of bounds");
                        }
                    }
                    else
                    {
                        comboBox1.Items.Add($"Rectnagle {name} not found");
                    }
                }
                else
                {
                    MessageBox.Show("The I operator takes 3 arguments");
                    comboBox1.Items.Add("The I operator takes 3 arguments");
                }
            }
            else if (op.symbolOperator == 'D')
            {
                if (operands.Count == 1)
                {
                    Rectangle rectangle = null;
                    string name = operands.Pop().value.ToString();
                    foreach (Rectangle rect in ShapeContainer.figureList)
                    {
                        if (rect.name == name)
                        {
                             rectangle = rect;
                        }
                    }
                    if (rectangle != null)
                    {
                        rectangle.DeleteF(rectangle, true);
                        comboBox1.Items.Add($"Rectangle {name} deleted");
                    }
                    else
                    {
                        comboBox1.Items.Add($"Rectangle {name} not found");
                    }
                }
                else
                {
                    MessageBox.Show("The D operator takes 1 argument");
                    comboBox1.Items.Add("The D operator takes 1 argument");
                }
            }
        }
        private bool IsNotOperation(char item)
        {
            if (!(item == 'R' || item == 'M' || item == 'I' || item == 'D' || item == ',' || item == '(' || item == ')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //all commands contains "name" first string argument and all other int arguments
        private bool OperandsCheck()
        {
            Stack<Operand> stack = new Stack<Operand>(operands);
            int stack_lenght = stack.Count;
            for (int i = 0; i < stack_lenght; i++)
            {
                Operand operand = stack.Pop();
                if (i == 0)
                {
                    if (!(operand.value is string) && !(operand.value is char))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!(int.TryParse(operand.value.ToString(), out int result)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
