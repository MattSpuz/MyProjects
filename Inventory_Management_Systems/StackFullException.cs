using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Management_Systems
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
