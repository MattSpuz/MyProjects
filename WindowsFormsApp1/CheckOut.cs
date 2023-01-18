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

namespace HotelAppForm
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e) //load-time script
        {
            string roomNum = GlobalVariables.globalRoomId;
            nameTextBox.Text = GlobalVariables.rooms.getRoomNumber(roomNum).CustomerName;
            roomNumTextBox.Text = GlobalVariables.rooms.getRoomNumber(roomNum).RoomNumber;
            roomTypeTextBox.Text = GlobalVariables.rooms.getRoomNumber(roomNum).roomType;
            numOfGuestsTextBox.Text = GlobalVariables.rooms.getRoomNumber(roomNum).NumOfGuests.ToString();
            dailyRateTextBox.Text = GlobalVariables.rooms.getRoomNumber(roomNum).DailyRate.ToString();
            totalTextBox.Text = GlobalVariables.rooms.getRoomNumber(roomNum).TotalSale.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e) //returns user to main menu
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e) //removes specified value
        {
            Customer temp = GlobalVariables.rooms.getRoomNumber(GlobalVariables.globalRoomId);
            GlobalVariables.rooms.remove(temp);
            this.Close();
        }
    }
}
