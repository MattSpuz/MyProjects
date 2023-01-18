using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppForm
{
    class Customer
    {
        //Properties
        private string _customerName;
        private DateTime _arrivalTime;
        private DateTime _leavingTime;
        private string _roomNumber;
        private string _roomType;
        private int _daysStaying;
        private int _numOfGuests;
        private int _dailyRate;
        private int _totalSale;

        //constructors (empty and input)
        public Customer()
        {
            _customerName = "N/A";
            _arrivalTime = new DateTime(1111, 11, 11);
            _leavingTime = new DateTime(1111, 11, 11);
            _roomNumber = "N/A";
            _roomType = "N/A";
            _daysStaying = 0;
            _numOfGuests = 0;
            _dailyRate = 0;
            _totalSale = 0;
        }

        public Customer(string customerName, DateTime arrivalTime, DateTime leavingTime, string roomNumber, string roomType, int daysStying, int numOfGuests, int dailyRate, int totalSale)
        {
            _customerName = customerName;
            _arrivalTime = arrivalTime;
            _leavingTime = leavingTime;
            _roomNumber = roomNumber;
            _roomType = roomType;
            _daysStaying = daysStying;
            _numOfGuests = numOfGuests;
            _dailyRate = dailyRate;
            _totalSale = totalSale;
        }


        //getter and setters
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public DateTime ArrivalTime { get => _arrivalTime; set => _arrivalTime = value; }
        public DateTime LeavingTime { get => _leavingTime; set => _leavingTime = value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        public string roomType { get => _roomType; set => _roomType = value; }
        public int DaysStaying { get => _daysStaying; set => _daysStaying = value; }
        public int NumOfGuests { get => _numOfGuests; set => _numOfGuests = value; }
        public int DailyRate { get => _dailyRate; set => _dailyRate = value; }
        public int TotalSale { get => _totalSale; set => _totalSale = value; }

        //methods
        public string toString()
        {
            string tostring = "";
            tostring += _customerName + " " + _arrivalTime + " "
                      + _leavingTime + " " + _roomNumber + " "
                      + _roomType + " " + _daysStaying + " "
                      + _numOfGuests + " " + _dailyRate + " "
                      + _totalSale;
            return tostring;
        }
    }
}
