using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int bet = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void RandomBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Return a randomized number between 1 and 100
        private int Randomizer()
        {
            int i;
            i = rand.Next(1, 101);
            return i;
        }

        //returns the number of points scored
        private int CaldulatePoints()
        {
            int totalPoints = 0;
            if(bet == 1)
            {
                if (1 <= Convert.ToInt16(RandomBox.Text) && Convert.ToInt16(RandomBox.Text) <= 25)
                    totalPoints++;
                if (1 <= Convert.ToInt16(textBox1.Text) && Convert.ToInt16(textBox1.Text) <= 25)
                    totalPoints++;
                if (1 <= Convert.ToInt16(textBox2.Text) && Convert.ToInt16(textBox2.Text) <= 25)
                    totalPoints++;
                if (1 <= Convert.ToInt16(textBox3.Text) && Convert.ToInt16(textBox3.Text) <= 25)
                    totalPoints++;
                if (1 <= Convert.ToInt16(textBox4.Text) && Convert.ToInt16(textBox4.Text) <= 25)
                    totalPoints++;
                if (1 <= Convert.ToInt16(textBox5.Text) && Convert.ToInt16(textBox5.Text) <= 25)
                    totalPoints++;
                if (1 <= Convert.ToInt16(textBox6.Text) && Convert.ToInt16(textBox6.Text) <= 25)
                    totalPoints++;
                if (1 <= Convert.ToInt16(textBox7.Text) && Convert.ToInt16(textBox7.Text) <= 25)
                    totalPoints++;
                if (1 <= Convert.ToInt16(textBox8.Text) && Convert.ToInt16(textBox8.Text) <= 25)
                    totalPoints++;
            }
            else if (bet == 2)
            {
                if (26 <= Convert.ToInt16(RandomBox.Text) && Convert.ToInt16(RandomBox.Text) <= 50)
                    totalPoints++;
                if (26 <= Convert.ToInt16(textBox1.Text) && Convert.ToInt16(textBox1.Text) <= 50)
                    totalPoints++;
                if (26 <= Convert.ToInt16(textBox2.Text) && Convert.ToInt16(textBox2.Text) <= 50)
                    totalPoints++;
                if (26 <= Convert.ToInt16(textBox3.Text) && Convert.ToInt16(textBox3.Text) <= 50)
                    totalPoints++;
                if (26 <= Convert.ToInt16(textBox4.Text) && Convert.ToInt16(textBox4.Text) <= 50)
                    totalPoints++;
                if (26 <= Convert.ToInt16(textBox5.Text) && Convert.ToInt16(textBox5.Text) <= 50)
                    totalPoints++;
                if (26 <= Convert.ToInt16(textBox6.Text) && Convert.ToInt16(textBox6.Text) <= 50)
                    totalPoints++;
                if (26 <= Convert.ToInt16(textBox7.Text) && Convert.ToInt16(textBox7.Text) <= 50)
                    totalPoints++;
                if (26 <= Convert.ToInt16(textBox8.Text) && Convert.ToInt16(textBox8.Text) <= 50)
                    totalPoints++;
            }
            else if (bet == 3)
            {
                if (51 <= Convert.ToInt16(RandomBox.Text) && Convert.ToInt16(RandomBox.Text) <= 75)
                    totalPoints++;
                if (51 <= Convert.ToInt16(textBox1.Text) && Convert.ToInt16(textBox1.Text) <= 75)
                    totalPoints++;
                if (51 <= Convert.ToInt16(textBox2.Text) && Convert.ToInt16(textBox2.Text) <= 75)
                    totalPoints++;
                if (51 <= Convert.ToInt16(textBox3.Text) && Convert.ToInt16(textBox3.Text) <= 75)
                    totalPoints++;
                if (51 <= Convert.ToInt16(textBox4.Text) && Convert.ToInt16(textBox4.Text) <= 75)
                    totalPoints++;
                if (51 <= Convert.ToInt16(textBox5.Text) && Convert.ToInt16(textBox5.Text) <= 75)
                    totalPoints++;
                if (51 <= Convert.ToInt16(textBox6.Text) && Convert.ToInt16(textBox6.Text) <= 75)
                    totalPoints++;
                if (51 <= Convert.ToInt16(textBox7.Text) && Convert.ToInt16(textBox7.Text) <= 75)
                    totalPoints++;
                if (51 <= Convert.ToInt16(textBox8.Text) && Convert.ToInt16(textBox8.Text) <= 75)
                    totalPoints++;
            }
            else if (bet == 4)
            {
                if (76 <= Convert.ToInt16(RandomBox.Text) && Convert.ToInt16(RandomBox.Text) <= 100)
                    totalPoints++;
                if (76 <= Convert.ToInt16(textBox1.Text) && Convert.ToInt16(textBox1.Text) <= 100)
                    totalPoints++;
                if (76 <= Convert.ToInt16(textBox2.Text) && Convert.ToInt16(textBox2.Text) <= 100)
                    totalPoints++;
                if (76 <= Convert.ToInt16(textBox3.Text) && Convert.ToInt16(textBox3.Text) <= 100)
                    totalPoints++;
                if (76 <= Convert.ToInt16(textBox4.Text) && Convert.ToInt16(textBox4.Text) <= 100)
                    totalPoints++;
                if (76 <= Convert.ToInt16(textBox5.Text) && Convert.ToInt16(textBox5.Text) <= 100)
                    totalPoints++;
                if (76 <= Convert.ToInt16(textBox6.Text) && Convert.ToInt16(textBox6.Text) <= 100)
                    totalPoints++;
                if (76 <= Convert.ToInt16(textBox7.Text) && Convert.ToInt16(textBox7.Text) <= 100)
                    totalPoints++;
                if (76 <= Convert.ToInt16(textBox8.Text) && Convert.ToInt16(textBox8.Text) <= 100)
                    totalPoints++;
            }
            return totalPoints;
        }

        //Determaines the players points scored and total bet
        private void RandomButton_Click(object sender, EventArgs e)
        {
            if(BetAmountTextBox.Text != "You Lose" && bet != 0)
            {
                ResetPleaseLabel.Text = "";
                RandomBox.Text = Randomizer().ToString();
                textBox1.Text = Randomizer().ToString();
                textBox2.Text = Randomizer().ToString();
                textBox3.Text = Randomizer().ToString();
                textBox4.Text = Randomizer().ToString();
                textBox5.Text = Randomizer().ToString();
                textBox6.Text = Randomizer().ToString();
                textBox7.Text = Randomizer().ToString();
                textBox8.Text = Randomizer().ToString();

                BetAmountTextBox.Text = (CaldulatePoints() * Convert.ToInt64(BetAmountTextBox.Text)).ToString();
                if (BetAmountTextBox.Text == "0")
                {
                    BetAmountTextBox.Text = "You Lose";
                }
            }
            else
            {
                ResetPleaseLabel.Text = "You've either lost or haven't picked a bet";
            }
        }

        //Changes bet to 1-25
        private void BettingButton1_Click(object sender, EventArgs e)
        {
            bet = 1;
            ChosenBetTextBox.Text = "1-25";
        }

        //Changes bet to 26-50
        private void BettingButton2_Click(object sender, EventArgs e)
        {
            bet = 2;
            ChosenBetTextBox.Text = "26-50";
        }

        //Changes bet to 51-75
        private void BettingButton3_Click(object sender, EventArgs e)
        {
            bet = 3;
            ChosenBetTextBox.Text = "51-75";
        }

        //Changes bet to 76-100
        private void BettingButton4_Click(object sender, EventArgs e)
        {
            bet = 4;
            ChosenBetTextBox.Text = "76-100";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            bet = 0;
            ChosenBetTextBox.Text = "";
            BetAmountTextBox.Text = "100";
        }
    }
}
