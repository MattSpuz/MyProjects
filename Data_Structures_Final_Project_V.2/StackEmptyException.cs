using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_Final_Project_V
{
    public class StackEmptyException: Exception
    {
        public override string Message
        {
            get
            {
                return "Stack is Empty";
            }
        }
    }
}
