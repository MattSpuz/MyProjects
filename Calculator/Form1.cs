using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputAndOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void findError()
        {
            if (inputAndOutput.Text == "ERROR")
            {
                inputAndOutput.Text = "";
                inputAndOutput.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputAndOutput.Text = "";
            inputAndOutput.Focus();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            findError();
            string equation = inputAndOutput.Text;
            DataTable table = new DataTable();

            try
            {
                object result = table.Compute(equation, "");
                inputAndOutput.Text = result.ToString();
            }
            catch 
            {
                inputAndOutput.Text = "ERROR";
                Console.WriteLine("ERROR");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += addButton.Text;
        }
        private void subtractButton_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += subtractButton.Text;
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += multiplyButton.Text;
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += divideButton.Text;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += decimalButton.Text;
        }
        private void negitiveButton_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += subtractButton.Text;
        }


        //number keypad below
        private void One_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += One.Text;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += Two.Text;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += Three.Text;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += Four.Text;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += Five.Text;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += Six.Text;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += Seven.Text;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += Eight.Text;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += Nine.Text;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += Zero.Text;
        }

        private void exponentButton_Click(object sender, EventArgs e)
        {
            findError();
            inputAndOutput.Text += "^";
        }
    }
}
