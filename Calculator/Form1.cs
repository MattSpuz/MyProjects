using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Current Problem:
 *  after pressing equals once the answor is saved twice?
 */

namespace Calculator
{
    public partial class Form1 : Form
    {
        List<string> equate = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void inputAndOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void FindError()
        {
            if (inputAndOutput.Text == "ERROR")
            {
                inputAndOutput.Text = "";
                inputAndOutput.Focus();
            }
            
        }
        private void StoreValue() //used to store numbers
        {
            equate.Add(inputAndOutput.Text);
            inputAndOutput.Text = "";
            inputAndOutput.Focus();
        }
        private void StoreSymbol() //used to store symbols
        {
            string input = inputAndOutput.Text;
            if (input == "(" || input == ")" || input == "^" || input == "/" ||
                input == "*" || input == "-" || input == "+")
            {
                equate.Add(inputAndOutput.Text);
                inputAndOutput.Text = "";
                inputAndOutput.Focus();
            }
        }
        private double CalculateEquation()
        {
            double result = 0;
            double num1;
            double num2;
            int pass = 0;
            while(equate.Count != 1)
            {
                if(pass == 0)
                {
                    for (int i = 0; i < equate.Count; i++) //checking for /
                    {
                        if (equate.ElementAt(i) == "/")
                        {
                            num1 = Convert.ToDouble(equate.ElementAt(i - 1));
                            num2 = Convert.ToDouble(equate.ElementAt(i + 1));

                            result = num1 / num2;

                            equate.RemoveAt(i + 1);
                            equate.RemoveAt(i);
                            equate[i - 1] = result.ToString();
                            pass = 1;
                        }
                    }
                }
                if (pass == 0)
                {
                    for (int i = 0; i < equate.Count; i++) //checking for *
                    {
                        if (equate.ElementAt(i) == "*")
                        {
                            num1 = Convert.ToDouble(equate.ElementAt(i - 1));
                            num2 = Convert.ToDouble(equate.ElementAt(i + 1));
                            
                            result = num1 * num2;

                            equate.RemoveAt(i + 1);
                            equate.RemoveAt(i);
                            equate[i - 1] = result.ToString();
                            pass = 1;
                        }
                    }
                }
                pass = 0;
            }

            return result;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputAndOutput.Text = "";
            inputAndOutput.Focus();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            //check if it says error
            FindError();
            equate.Add(inputAndOutput.Text);

            //reset the textbox
            inputAndOutput.Text = "";
            inputAndOutput.Focus();
            
            try //check if the equation lets out an error
            {
                double result = 0;
                result = CalculateEquation();
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
            FindError();
            StoreValue();
            inputAndOutput.Text += addButton.Text;
        }
        private void subtractButton_Click(object sender, EventArgs e)
        {
            FindError();
            StoreValue();
            inputAndOutput.Text += subtractButton.Text;
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            FindError();
            StoreValue();
            inputAndOutput.Text += multiplyButton.Text;
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            FindError();
            StoreValue();
            inputAndOutput.Text += divideButton.Text;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            FindError();
            inputAndOutput.Text += decimalButton.Text;
        }
        private void negitiveButton_Click(object sender, EventArgs e)
        {
            FindError();
            inputAndOutput.Text += subtractButton.Text;
        }
        private void exponentButton_Click(object sender, EventArgs e)
        {
            FindError();
            inputAndOutput.Text += "^";
        }


        //number keypad below
        private void One_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += One.Text;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Two.Text;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Three.Text;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Four.Text;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Five.Text;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Six.Text;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Seven.Text;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Eight.Text;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Nine.Text;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Zero.Text;
        }

    }
}
