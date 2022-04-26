using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_Final_Project_V
{
    public class StackFullException : Exception
    {
        public override string Message
        {
            get
            {
                return "Stack is Full";
            }
        }
    }
}
