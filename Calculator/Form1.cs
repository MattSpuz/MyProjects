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
        int position = 0;
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
            if (equate.Count == 0 && inputAndOutput.Text == "")
            {
                return;
            }
            equate.Add(inputAndOutput.Text);
            inputAndOutput.Text = "";
            inputAndOutput.Focus();

        }
        private void StoreSymbol() //used to store symbols
        {
            string input = inputAndOutput.Text;

            //this is to test if there is a symbol behind the number
            //that has yet to be stored.
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
                for (int i = 0 + position; i < equate.Count; i++) //checking for (
                {
                    if (equate.ElementAt(i) == "(")
                    {
                        //store the position of the parenthises
                        position += i + 1;

                        //enter a method within a method until you reach 
                        //the end of the parenthises
                        result = CalculateEquation();

                        //reset the position
                        position -= i + 1;
                    }
                }
                for (int i = 0 + position; i < equate.Count; i++) //checking for /
                {
                    if (equate.ElementAt(i) == "/")
                    {
                        result = Convert.ToDouble(equate[i - 1]) / Convert.ToDouble(equate[i + 1]);

                        equate.RemoveAt(i + 1);
                        equate.RemoveAt(i);
                        equate[i - 1] = result.ToString();
                        i--; //reset i 
                    }
                    //we can't go beyond the right parenthises 
                    //so we end the loop
                    else if (equate.ElementAt(i) == ")")
                        i = equate.Count + 1;
                }
                for (int i = 0 + position; i < equate.Count; i++) //checking for *
                {
                    if (equate.ElementAt(i) == "*")
                    {
                        result = Convert.ToDouble(equate[i - 1]) * Convert.ToDouble(equate[i + 1]);

                        equate.RemoveAt(i + 1);
                        equate.RemoveAt(i);
                        equate[i - 1] = result.ToString();
                        i--; //reset i 
                    }
                    //we can't go beyond the right parenthises 
                    //so we end the loop
                    else if (equate.ElementAt(i) == ")")
                        i = equate.Count + 1;
                }
                for (int i = 0 + position; i < equate.Count; i++) //checking for -
                {
                    if (equate.ElementAt(i) == "-")
                    {
                        result = Convert.ToDouble(equate[i - 1]) - Convert.ToDouble(equate[i + 1]);

                        equate.RemoveAt(i + 1);
                        equate.RemoveAt(i);
                        equate[i - 1] = result.ToString();
                        i--; //reset i 
                    }
                    //we can't go beyond the right parenthises 
                    //so we end the loop
                    else if (equate.ElementAt(i) == ")")
                        i = equate.Count + 1;
                }
                for (int i = 0 + position; i < equate.Count; i++) //checking for +
                {
                    if (equate.ElementAt(i) == "+")
                    {
                        result = Convert.ToDouble(equate[i - 1]) + Convert.ToDouble(equate[i + 1]);

                        equate.RemoveAt(i + 1);
                        equate.RemoveAt(i);
                        equate[i - 1] = result.ToString();
                        i--; //reset i 
                    }
                    //we can't go beyond the right parenthises 
                    //so we end the loop
                    else if (equate.ElementAt(i) == ")")
                        i = equate.Count + 1;
                }
                for (int i = 0 + position; i < equate.Count; i++) //checking for )
                {
                    if (equate.ElementAt(i) == ")")
                    {
                        equate.RemoveAt(i);
                        equate.RemoveAt(i - 2);
                        i -= 2;

                        //if there is a number behind the parenthises than
                        //it must be multiplied
                        if (i > 0)
                        {
                            double j;
                            if (double.TryParse(equate.ElementAt(i - 1), out j))
                            {
                                equate.Insert(i, "*");
                            }
                        }
                        return result;
                    }
                }
            }
            return result;
        }
        //returns true if their is an open parenthises
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

        private void done_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
