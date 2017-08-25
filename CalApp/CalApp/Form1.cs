using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalApp
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        double result = 0.0 ;
        char operation;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "1";
            this.Display.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "2";
            this.Display.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "3";
            this.Display.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "4";
            this.Display.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "5";
            this.Display.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "6";
            this.Display.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "7";
            this.Display.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "8";
            this.Display.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "9";
            this.Display.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += "0";
            this.Display.Text += input;
        }

        private void buttonDott_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += ".";
            this.Display.Text += input;
        }

        private void buttonnDevide_Click(object sender, EventArgs e)
        {
            operand1 = input.Text;
            operation = '/';
            input.Text = string.Empty;
        }

        private void buttonnPlus_Click(object sender, EventArgs e)
        {
            operand1 = input.Text;
            operation = '+';
            input.Text = string.Empty;
        }

        private void buttonnMulti_Click(object sender, EventArgs e)
        {
            operand1 = input.Text;
            operation = '*';
            input.Text = string.Empty;
        }

        private void buttonnMinus_Click(object sender, EventArgs e)
        {
            operand1 = input.Text;
            operation = '-';
            input.Text = string.Empty;
        }

     
     
        private void buttonCRL_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void buttonequalll_Click(object sender, EventArgs e)
        {

            operand1 = input.Text;
            operation = '=';
            input.Text = string.Empty;
        }

      
    }
}
