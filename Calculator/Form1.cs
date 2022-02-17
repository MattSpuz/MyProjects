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
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void inputAndOutput_TextChanged(object sender, EventArgs e)
        {

        }
        private void Output2_Click(object sender, EventArgs e)
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

        //translates and solves a string equation
        private double CalculateEquation() 
        {
            while (equate.Count != 1)
            {
                for (int i = 0; i < equate.Count; i++) //checking for /
                {
                    if (equate.ElementAt(i) == "(")
                    {
                        //enter a method within a method until you reach 
                        //the end of the parenthises
                        result = CalculateEquation();
                        equate.RemoveAt(i);
                        equate.RemoveAt(i - 2);
                        equate[i - 1] = result.ToString();
                    }
                    else if(equate.ElementAt(i) == ")")
                    {
                        return result;
                    }
                }
                for (int i = 0; i < equate.Count; i++) //checking for /
                {
                    if (equate.ElementAt(i) == "/")
                    {
                        result = Convert.ToDouble(equate[i - 1]) / Convert.ToDouble(equate[i + 1]);

                        equate.RemoveAt(i + 1);
                        equate.RemoveAt(i);
                        equate[i - 1] = result.ToString();

                    }
                }
                for (int i = 0; i < equate.Count; i++) //checking for =
                {
                    if (equate.ElementAt(i) == "+")
                    {
                        result = Convert.ToDouble(equate[i - 1]) + Convert.ToDouble(equate[i + 1]);

                        equate.RemoveAt(i + 1);
                        equate.RemoveAt(i);
                        equate[i - 1] = result.ToString();

                    }
                }
            }
            return result;
        }
        //returns true if their is a open parenthises
        //that needs to be closed
        private bool FindParenthises()
        {
            int rightParenthises = 0;
            int leftParenthises = 0;
            for (int i = 0; i < equate.Count; i++)
            {
                if (equate.ElementAt(i) == "(")
                {
                    leftParenthises++;
                }
                if (equate.ElementAt(i) == ")")
                {
                    rightParenthises++;
                }
            }
            if (leftParenthises != rightParenthises)
            {
                return true;
            }
            return false;
        }

        //GUI buttons
        private void clearButton_Click(object sender, EventArgs e)
        {
            inputAndOutput.Text = "";
            inputAndOutput.Focus();

            Output2.Text = "";
            Output2.Focus();

            equate.Clear();
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
                result = CalculateEquation();
                equate.Clear();
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
            Output2.Text += addButton.Text;
        }
        private void subtractButton_Click(object sender, EventArgs e)
        {
            FindError();
            StoreValue();
            inputAndOutput.Text += subtractButton.Text;
            Output2.Text += subtractButton.Text;
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            FindError();
            StoreValue();
            inputAndOutput.Text += multiplyButton.Text;
            Output2.Text += multiplyButton.Text;
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            FindError();
            StoreValue();
            inputAndOutput.Text += divideButton.Text;
            Output2.Text += divideButton.Text;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            FindError();
            StoreValue();
            inputAndOutput.Text += decimalButton.Text;
            Output2.Text += decimalButton.Text;
        }
        private void negitiveButton_Click(object sender, EventArgs e)
        {
            FindError();
            StoreValue();
            inputAndOutput.Text += subtractButton.Text;
            Output2.Text += subtractButton.Text;
        }
        private void exponentButton_Click(object sender, EventArgs e)
        {
            FindError();
            StoreValue();
            inputAndOutput.Text += exponentButton.Text;
            Output2.Text += exponentButton.Text;
        }
        private void parenthesesButton_Click(object sender, EventArgs e)
        {
            FindError();
            StoreValue();
            if (FindParenthises() == true)
            {
                inputAndOutput.Text += ")";
                Output2.Text += ")";
            }
            else
            {
                inputAndOutput.Text += "(";
                Output2.Text += "(";
            }
        }


        //number keypad below
        private void One_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += One.Text;
            Output2.Text += One.Text;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Two.Text;
            Output2.Text += Two.Text;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Three.Text;
            Output2.Text += Three.Text;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Four.Text;
            Output2.Text += Four.Text;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Five.Text;
            Output2.Text += Five.Text;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Six.Text;
            Output2.Text += Six.Text;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Seven.Text;
            Output2.Text += Seven.Text;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Eight.Text;
            Output2.Text += Eight.Text;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Nine.Text;
            Output2.Text += Nine.Text;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            FindError();
            StoreSymbol();
            inputAndOutput.Text += Zero.Text;
            Output2.Text += Zero.Text; 
        }

        
    }
}
