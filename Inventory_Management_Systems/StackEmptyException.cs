using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Management_Systems
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
