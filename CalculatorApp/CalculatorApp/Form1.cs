using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string input = string.Empty;        //string storing user input
        string operand1 = string.Empty;     //string storing first operand
        string operand2 = string.Empty;     //string storing second operand
        double result = 0.0;                //calculated result
        char operation;                     //char for operation
  
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e) //button zero 
        {
            this.Display.Text = ""; 
            input += "0";
            this.Display.Text += input; //make more than 1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "1";
            this.Display.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "2";
            this.Display.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "3";
            this.Display.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "4";
            this.Display.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "5";
            this.Display.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "6";
            this.Display.Text += input;
        }

        private void buttonn7_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "7";
            this.Display.Text += input;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "8";
            this.Display.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "9";
            this.Display.Text += input;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            int c = Display.TextLength;
            int flag = 0;
            string text = Display.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                Display.Text = Display.Text + ".";
            }
        }

        private void buttonMuti_Click(object sender, EventArgs e) 
        {
                operand1 = input;
                operation = '*';
                input = string.Empty;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
                operand1 = input;
                operation = '-';
                input = string.Empty;
        }   

        private void buttonPlus_Click(object sender, EventArgs e)
        {
                operand1 = input;
                operation = '+';
                input = string.Empty;
        }

        private void buttonDevi_Click(object sender, EventArgs e)
        {
                operand1 = input;
                operation = '/';
                input = string.Empty;
        }

        private void buttonCRL_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.Display.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            num2 = num1 * (num2 / 100);

            if (operation == '+')
            {
                result = num1 + num2;
                Display.Text = result.ToString();
            }
            else if (operation == '-')
            {   
                result = num1 - num2;
                Display.Text = result.ToString();
            }
            
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            ButtonEqual();
        }

        private void ButtonEqual()
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.Display.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            //add addition looked like it was subtracking .. let check the logic
            if (operation == '+')
            {
                result = num1 + num2;
                Display.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                Display.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1* num2;
                Display.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Display.Text = result.ToString();
                }
                else
                {
                    Display.Text = "∞";
                }
            
            }
        }

       
    }
}
