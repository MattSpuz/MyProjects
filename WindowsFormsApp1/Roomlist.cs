using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelAppForm;

namespace HotelAppForm
{
    class Roomlist
    {
        //attributes
        int sizeOf;
        int maxSize;
        Customer[] linkedArray;

        //constructors
        Roomlist()
        {

        }
        public Roomlist(int maxSize)
        {
            this.sizeOf = 0;
            this.maxSize = maxSize;
            this.linkedArray = new Customer[maxSize];
        }

        //methods
        public bool isFull() //returns true if full
        {
            return sizeOf == maxSize;
        }

        public bool isEmpty() //returns true if empty
        {
            return sizeOf == 0;
        }

        public void insert(Customer placeholder) //adds given value to list
        {
            if(!isFull())
            {
                linkedArray[sizeOf] = placeholder;
                sizeOf++;
            }
        }

        public void remove(Customer placeholder) //removes given value from list
        {
            if(!isEmpty())
            {
                sizeOf--;
                for (int i = find(placeholder); i < sizeOf; i++)
                {
                    linkedArray[i] = linkedArray[i + 1];
                }
            }
        }

        public int size() //returns max size
        {
            return sizeOf + 1;
        }

        public int find(Customer placeholder) //find and returns the location of a value within linkedArray 
        {
            for (int i = 0; i < linkedArray.Length; i++)
            {
                if (linkedArray[i] == placeholder)
                {
                    return i;
                }
            }
            return -1;
        }

        public Customer getRoomNumber(string roomNum) //returns room information using the room number
        {
            for (int i = 0; i < sizeOf; i++)
            {
                if (linkedArray[i].RoomNumber == roomNum)
                {
                    return linkedArray[i];
                }
            }
            return null;
        }

        public bool avaliable(string roomNum) //returns true if room is avaliable 
        {
            for(int i = 0; i < sizeOf;i++)
            {
                if (linkedArray[i].RoomNumber == roomNum) //find specific room
                {
                    return false; 
                }
            }
            return true; //default
        }

        public string print() //return all values in linked list
        {
            string print = "";
            for(int i = 0; i < sizeOf; i++)
            {
                print += linkedArray[i].ToString();
            }
            return print; 
        }
    }
}
