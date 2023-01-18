using HotelAppForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerEdit : Form
    {
        //declarations
        string roomNum = GlobalVariables.globalRoomId;

        public CustomerEdit()
        {
            InitializeComponent();
            calculateTotal();
        }


        private void CustomerEdit_Load(object sender, EventArgs e) //sets the values within the form textboxes
        {
            nameTextBox.Text = GlobalVariables.rooms.getRoomNumber(roomNum).CustomerName;
            roomComboBox.Text = GlobalVariables.rooms.getRoomNumber(roomNum).RoomNumber;
            floorComboBox.Text = roomComboBox.Text.Substring(0, 1);
        }

        private double getTypeCost() //returns the cost of a specific room
        {
            string roomType = roomTypeComboBox.Text;
            switch (roomType)
            {
                case "Standard":
                    return 125.00;
                case "Deluxe":
                    return 150.00;
                case "Joint":
                    return 200.00;
                case "Connecting":
                    return 275.00;
                case "Suite":
                    return 525.00;
                case "Accessable":
                    return 150.00;
            }
            return 0.00;

        }

        private void calculateTotal() //calculates and sets the daily rate and total
        {
            double numOfGuests = Convert.ToDouble(numOfGuestsComboBox.Text);
            double roomCost = getTypeCost();
            double dailyRate = numOfGuests * roomCost;
            dailyRateTextBox.Text = dailyRate.ToString();
            totalTextBox.Text = dailyRateTextBox.Text;
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }
       
        private void numOfGuestsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void floorComboBox_SelectedIndexChanged(object sender, EventArgs e) //adds functionality to comboBox
        {

            //uses floorComboBox to determine avaliable values in roomComboBox
            if (floorComboBox.Text == "1")
            {
                roomComboBox.Items.Clear();
                roomComboBox.Text = "101";
                roomComboBox.Items.Add("101");
                roomComboBox.Items.Add("102");
                roomComboBox.Items.Add("103");
                roomComboBox.Items.Add("104");
                roomComboBox.Items.Add("105");
                roomComboBox.Items.Add("106");
                roomComboBox.Items.Add("107");
                roomComboBox.Items.Add("108");
                roomComboBox.Items.Add("109");
                roomComboBox.Items.Add("110");
                roomComboBox.Items.Add("111");
                roomComboBox.Items.Add("112");
                roomComboBox.Items.Add("113");
                roomComboBox.Items.Add("114");
                roomComboBox.Items.Add("115");
            }
            else if (floorComboBox.Text == "2")
            {
                roomComboBox.Items.Clear();
                roomComboBox.Text = "201";
                roomComboBox.Items.Add("201");
                roomComboBox.Items.Add("202");
                roomComboBox.Items.Add("203");
                roomComboBox.Items.Add("204");
                roomComboBox.Items.Add("205");
                roomComboBox.Items.Add("206");
                roomComboBox.Items.Add("207");
                roomComboBox.Items.Add("208");
                roomComboBox.Items.Add("209");
                roomComboBox.Items.Add("210");
                roomComboBox.Items.Add("211");
                roomComboBox.Items.Add("212");
                roomComboBox.Items.Add("213");
                roomComboBox.Items.Add("214");
                roomComboBox.Items.Add("215");
            }
            else if (floorComboBox.Text == "3")
            {
                roomComboBox.Items.Clear();
                roomComboBox.Text = "301";
                roomComboBox.Items.Add("301");
                roomComboBox.Items.Add("302");
                roomComboBox.Items.Add("303");
                roomComboBox.Items.Add("304");
                roomComboBox.Items.Add("305");
                roomComboBox.Items.Add("306");
                roomComboBox.Items.Add("307");
                roomComboBox.Items.Add("308");
                roomComboBox.Items.Add("309");
                roomComboBox.Items.Add("310");
                roomComboBox.Items.Add("311");
                roomComboBox.Items.Add("312");
                roomComboBox.Items.Add("313");
                roomComboBox.Items.Add("314");
                roomComboBox.Items.Add("315");
            }
        }

        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //error message when selected room is unavaliable
            if (!GlobalVariables.rooms.avaliable(roomComboBox.Text))
            {
                ErrorMessage.Text = "Room not avaliable";
            }
            else
            {
                ErrorMessage.Text = "";
            }
        }

        private void backButton_Click(object sender, EventArgs e) //close the form
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e) //finalize changes
        {            
            if(GlobalVariables.rooms.avaliable(roomComboBox.Text) || roomComboBox.Text == roomNum)
            {
                DateTime tempTime = new DateTime(1111, 11, 11);
                Customer temp = new Customer(nameTextBox.Text, tempTime, tempTime, roomComboBox.Text, roomTypeComboBox.Text, 3, 
                                             Convert.ToInt32(numOfGuestsComboBox.Text), Convert.ToInt32(dailyRateTextBox.Text), Convert.ToInt32(totalTextBox.Text));

                GlobalVariables.rooms.remove(GlobalVariables.rooms.getRoomNumber(roomNum)); //remove old room
                GlobalVariables.rooms.insert(temp);                                         //insert new room 

                this.Close();
            }
            else
            {
                ErrorMessage.Text = "Room not avaliable";
            }
            
        }
    }
}
