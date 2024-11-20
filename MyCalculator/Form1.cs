using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        private int num1;
        private int num2;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetInput()
        {
            num1 = int.Parse(FirstNumTextbox.Text);
            num2 = int.Parse(SecondNumTextBox.Text);
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            GetInput();
            ResultTextBox.Text = (num1+ num2).ToString();
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            GetInput();
            ResultTextBox.Text = (num1 - num2).ToString();
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            GetInput();
            ResultTextBox.Text = (num1 * num2).ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            GetInput();
            ResultTextBox.Text = (num1 / num2).ToString();
        }

        private void Modulo_Click(object sender, EventArgs e)
        {
            GetInput();
            ResultTextBox.Text = (num1 % num2).ToString();
        }
    }
}
