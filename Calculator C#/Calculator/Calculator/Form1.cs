using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            input.Text = Regex.Replace(input.Text, "\\.+", ".");
            if (input.Text.Contains(".") && !Regex.IsMatch(input.Text, "^\\d*\\.\\d*$"))
            {
                int dotPosition = input.Text.IndexOf('.');
                if (dotPosition > 0)
                {
                    input.Text = input.Text.Substring(0, dotPosition) + input.Text.Substring(dotPosition + 1);
                }
            }
            input.Text = Regex.Replace(input.Text, "^0+\\.", ".");

            if (string.IsNullOrWhiteSpace(input.Text) || input.Text.StartsWith("."))
            {
                input.Text = "0"; 
            }
        }

        private void ACbutton_Click(object sender, EventArgs e)
        {
            input.Text = "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "1";
            }
            else
            {
                input.Text = input.Text + "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "2";
            }
            else
            {
                input.Text = input.Text + "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "3";
            }
            else
            {
                input.Text = input.Text + "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "4";
            }
            else
            {
                input.Text = input.Text + "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "5";
            }
            else
            {
                input.Text = input.Text + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "6";
            }
            else
            {
                input.Text = input.Text + "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "7";
            }
            else
            {
                input.Text = input.Text + "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "8";
            }
            else
            {
                input.Text = input.Text + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "9";
            }
            else
            {
                input.Text = input.Text + "9";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "0";
            }
            else
            {
                input.Text = input.Text + "0";
            }
        }

        private void equalsbutton_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            if (!double.TryParse(input.Text, out SecondNumber))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            switch (Operation)
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    Result = FirstNumber - SecondNumber;
                    break;
                case "*":
                    Result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    if (SecondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    Result = FirstNumber / SecondNumber;
                    break;
                default:
                    MessageBox.Show("Invalid operation selected.");
                    return;
            }

            input.Text = Result.ToString();
            FirstNumber = Result;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(input.Text);
            input.Text = "0";
            Operation = "+";
        }

        private void subtractbutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(input.Text);
            input.Text = "0";
            Operation = "-";

        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(input.Text);
            input.Text = "0";
            Operation = "*";
        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(input.Text);
            input.Text = "0";
            Operation = "/";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(input.Text) || (input.Text.Trim() == "."))
            {
                input.Text = "0";
            }
            else
            {
                var tempText = input.Text.Remove(input.Text.Length - 1);

                if (!string.IsNullOrWhiteSpace(tempText))
                {
                    input.Text = tempText;
                }
                else
                {
                    input.Text = "0";
                }
            }
        }

        private void decimalbutton_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + ".";
        }
    }
}