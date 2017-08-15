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
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += buttonNum1.Text;
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += buttonNum2.Text;
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += buttonNum3.Text;
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += buttonNum4.Text;
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += buttonNum5.Text;
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += buttonNum6.Text;
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += buttonNum7.Text;
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += buttonNum8.Text;
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += buttonNum9.Text;
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += buttonNum0.Text;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += buttonNum0.Text;
        }
    }
}
