using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelAppForm;
using HotelAppForm;

namespace HotelAppForm
{
    public partial class mainform : Form
    {
        public mainform() //initialize form
        {
            DateTime tempTime = new DateTime(2023, 1, 3);
            Customer temp = new Customer("John Hankcock", tempTime, tempTime.AddDays(3), "101", "Standard", 3, 2, 12, 36);
            GlobalVariables.rooms.insert(temp);
            DateTime tempTime2 = new DateTime(2023, 1, 1);
            Customer temp2 = new Customer("Salene Brand", tempTime2, tempTime2.AddDays(6), "201", "Suite", 6, 1, 12, 72);
            GlobalVariables.rooms.insert(temp2);
            InitializeComponent();
            
        }

        private void CheckInButton_Click(object sender, EventArgs e) //send user to customer edit form to check in
        {
            this.Hide();
            CheckIn addCustomer = new CheckIn();
            addCustomer.ShowDialog();
            this.Show();

        }
        private void editbutton_Click(object sender, EventArgs e) //edits a pre-existing room
        {
            string roomNum = roomNumTextBox.Text;
            if (roomNum != "N/A")
            {
                this.Hide();
                GlobalVariables.globalRoomId = roomNum;
                CustomerEdit edit = new CustomerEdit();
                edit.ShowDialog();
                this.Show();
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e) //removes a customer from a room
        {
            string roomNum = roomNumTextBox.Text; //selected room number
            if(roomNum != "N/A")
            {
                this.Hide();
                GlobalVariables.globalRoomId = roomNum;
                CheckOut checkOutForm = new CheckOut();
                checkOutForm.ShowDialog();
                this.Show();
            }
        }

        private void viewRoom(string roomNumber) //displays the associated room values
        {
            if (GlobalVariables.rooms.avaliable(roomNumber)) //if empty; set values to N/A
            {
                nameTextBox.Text = "N/A";
                roomNumTextBox.Text = "N/A";
                roomTypeTextBox.Text = "N/A";
                numOfGuestsTextBox.Text = "N/A";
                dailyRateTextBox.Text = "0.00";
                totalTextBox.Text = "0.00";
            }
            else                                //set the values
            {
                Customer temp = GlobalVariables.rooms.getRoomNumber(roomNumber);
                nameTextBox.Text = temp.CustomerName;
                roomNumTextBox.Text = temp.RoomNumber;
                roomTypeTextBox.Text = temp.roomType;
                numOfGuestsTextBox.Text = temp.NumOfGuests.ToString();
                dailyRateTextBox.Text = temp.DailyRate.ToString();
                totalTextBox.Text = temp.TotalSale.ToString();
            }
        }

        


        /*
         * all buttons to view rooms 101-115
        */
        private void room101button_Click(object sender, EventArgs e)
        {
            viewRoom("101");
        }
        
        private void room102button_Click(object sender, EventArgs e)
        {
            viewRoom("102");
        }
        
        private void room103button_Click(object sender, EventArgs e)
        {
            viewRoom("103");
        }
        
        private void room104button_Click_1(object sender, EventArgs e)
        {
            viewRoom("104");
        }

        private void room105button_Click(object sender, EventArgs e)
        {
            viewRoom("105");
        }

        private void room106button_Click(object sender, EventArgs e)
        {
            viewRoom("106");
        }

        private void room107button_Click(object sender, EventArgs e)
        {
            viewRoom("107");
        }

        private void room108button_Click(object sender, EventArgs e)
        {
            viewRoom("108");
        }

        private void room109button_Click(object sender, EventArgs e)
        {
            viewRoom("109");
        }

        private void room110button_Click(object sender, EventArgs e)
        {
            viewRoom("110");
        }

        private void room111button_Click(object sender, EventArgs e)
        {
            viewRoom("111");
        }

        private void room112button_Click(object sender, EventArgs e)
        {
            viewRoom("112");
        }

        private void room113button_Click(object sender, EventArgs e)
        {
            viewRoom("113");
        }

        private void room114button_Click(object sender, EventArgs e)
        {
            viewRoom("114");
        }

        private void room115button_Click(object sender, EventArgs e)
        {
            viewRoom("115");
        }


        /*
         * //View Rooms 201-215
        */
        private void room201button_Click(object sender, EventArgs e)
        {
            viewRoom("201");
        }

        private void room202button_Click(object sender, EventArgs e)
        {
            viewRoom("202");
        }

        private void room203button_Click(object sender, EventArgs e)
        {
            viewRoom("203");
        }

        private void room204button_Click(object sender, EventArgs e)
        {
            viewRoom("204");
        }

        private void room205button_Click(object sender, EventArgs e)
        {
            viewRoom("205");
        }

        private void room206button_Click(object sender, EventArgs e)
        {
            viewRoom("206");
        }

        private void room207button_Click(object sender, EventArgs e)
        {
            viewRoom("207");
        }

        private void room208button_Click(object sender, EventArgs e)
        {
            viewRoom("208");
        }

        private void room209button_Click(object sender, EventArgs e)
        {
            viewRoom("209");
        }

        private void room210button_Click(object sender, EventArgs e)
        {
            viewRoom("210");
        }

        private void room211button_Click(object sender, EventArgs e)
        {
            viewRoom("211");
        }

        private void room212button_Click(object sender, EventArgs e)
        {
            viewRoom("212");
        }

        private void room213button_Click(object sender, EventArgs e)
        {
            viewRoom("213");
        }

        private void room214button_Click(object sender, EventArgs e)
        {
            viewRoom("214");
        }

        private void room215button_Click(object sender, EventArgs e)
        {
            viewRoom("215");
        }

        /*
         * //View Rooms 301-315
        */ 
        private void room301button_Click(object sender, EventArgs e)
        {
            viewRoom("301");
        }

        private void room302button_Click(object sender, EventArgs e)
        {
            viewRoom("302");
        }

        private void room303button_Click(object sender, EventArgs e)
        {
            viewRoom("303");
        }

        private void room304button_Click(object sender, EventArgs e)
        {
            viewRoom("304");
        }

        private void room305button_Click(object sender, EventArgs e)
        {
            viewRoom("305");
        }

        private void room306button_Click(object sender, EventArgs e)
        {
            viewRoom("306");
        }

        private void room307button_Click(object sender, EventArgs e)
        {
            viewRoom("307");
        }

        private void room308button_Click(object sender, EventArgs e)
        {
            viewRoom("308");
        }

        private void room309button_Click(object sender, EventArgs e)
        {
            viewRoom("309");
        }

        private void room310button_Click(object sender, EventArgs e)
        {
            viewRoom("310");
        }

        private void room311button_Click(object sender, EventArgs e)
        {
            viewRoom("311");
        }

        private void room312button_Click(object sender, EventArgs e)
        {
            viewRoom("312");
        }

        private void room313button_Click(object sender, EventArgs e)
        {
            viewRoom("313");
        }

        private void room314button_Click(object sender, EventArgs e)
        {
            viewRoom("314");
        }

        private void room315button_Click(object sender, EventArgs e)
        {
            viewRoom("315");
        }
    }
}
