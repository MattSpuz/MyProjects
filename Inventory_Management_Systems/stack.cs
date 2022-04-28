using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

/**************************************************************
* Name        : stack
* Author      : Matthew Spuzello
* Created     : 1/27/2022
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows XX
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : use tests to work with stacks
*               Input:  n/a
*               Output: n/a
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

namespace Inventory_Management_Systems
{
    public class stack
    {

        public class Node {
            public int top;  //represents the top value of the array
            public int maxSize; //represents the size of the array
            public string[] shelf = new string[] { }; 
            /*this items specifies a portion of a shelf that holds items.
             *the shelf/Item array can have many different items or it can
             *have many duplicate items depending on how the store stocks 
             *the shelf.*/
        }
        List<Node> counter = new List<Node>();

        //returns true if stack is full
        public bool isFull(int position)
        {
            return  size(position) == counter.ElementAt(position).maxSize; 
        }

        public bool isEmpty()
        {
            return counter == null;
        }

        //return the size of the list
        public int size()
        {
            return counter.Count();  
        }
        //return the number of items within the stack
        public int size(int position)
        {
            Node temp = counter.ElementAt(position);
            return temp.top;
        }

        //returns the max size
        public int maxSize(int position)
        {
            return counter.ElementAt(position).maxSize;
        }
        //returns the number of avaliable spots
        /*public int freeSpace(int position)
        {
            Node temp = counter.ElementAt(position);
            return temp.maxSize - (temp.top + 1);
        }*/

        //returns the name of item at the end of the stack
        public string peek(int position)
        {
            Node temp = counter.ElementAt(position);
            if (!this.isEmpty()) //the if statement is required because the method can't work if there is nothing in stackItems[]
                return temp.shelf[temp.top];
            throw new StackEmptyException(); 
        }


        //add a new shelf
        public void AddShelf(int max)
        {
            Node newNode = new Node();
            
            newNode.top = -1;
            newNode.maxSize = max - 1;
            Array.Resize<string>(ref newNode.shelf, max);
            counter.Add(newNode);
        }
        //remove a shelf
        public void RemoveShelf(int position)
        {
            if(!isEmpty())
            {
                Node temp = counter.ElementAt(position);
                counter.Remove(temp);
            }
        }


        //remove item from top
        public string pop(int position)
        {
            Node temp = counter.ElementAt(position);
            if (!this.isEmpty())
            {
                string item = temp.shelf[temp.top];
                temp.shelf[temp.top] = null;
                temp.top--;
                return item;
            }
            throw new StackEmptyException();
        }

        //add item to the top
        public void push(int position, string item)
        {
            
            Node temp = counter.ElementAt(position);
            if (!this.isFull(position)) //the if statement is to check if stackItems is already full and can't take in any more
            {
                temp.top++;                  //I add a value to top
                temp.shelf[temp.top] = item; //I add to the stack by adding to top and using top to determine the placement of the value
            }
            else
                throw new StackFullException(); //the exception is needed in case it dosen't work
        }

        //add multiple items to the top
        public void push(int position, string item, int quantity)
        {
            Node temp = counter.ElementAt(position);
            if (size(position) + quantity <= temp.maxSize) //the if statement is to check if stackItems is already full and can't take in any more
            {
                for (int i = 0; i < quantity; i++)
                {
                    temp.top++;                  //I add a value to top
                    temp.shelf[temp.top] = item; //I add to the stack by adding to top and using top to determine the placement of the value
                }
            }
            else
                throw new StackFullException(); //the exception is needed in case it dosen't work
        }

        //print everthing
        public string print()
        {
            
            Node temp;
            string output = "";
            //loop through the shelves
            for (int i = 0; i != counter.Count(); i++)
            {
                temp = counter.ElementAt(i);
                output += "position " + i + ": \r\nMax Size: " + (counter.ElementAt(i).maxSize + 1) + "\r\nUsed space: " + (counter.ElementAt(i).top + 1) + "\r\n";
                //loop through the shelves contents
                for (int j = 0; j < temp.top + 1; j++)
                {
                    output += (j + 1) + "." + temp.shelf[j] + "\r\n";
                }
                
            }
            if (!this.isEmpty())
                return output;
            throw new StackEmptyException();
        }

        //print a single stack
        public string printStackUp(int position)
        {
            Node temp = counter.ElementAt(position);
            string stackString = "";
            for(int i = 0; i != temp.top + 1; i++)
            {
                stackString += temp.shelf[i] + "\r\n";
            }
            if (!this.isEmpty())
                return stackString;
            throw new StackEmptyException();
        }


        //sort the items in alphebetical order
        public void InsertionSort() //sort everything
        {
            List<Node> temp = counter;
            //sort the array
            for (int n = 0; n < size(); n++) 
            {
                //rather than retyping code I will be reusing the below InsertionSort();
                InsertionSort(n);
            }
        }

        public void InsertionSort(int position) //sort one shelf
        {
            string[] temp = counter.ElementAt(position).shelf;
            int size = counter.ElementAt(position).maxSize + 1;
            //sort the array
            Array.Sort(temp);
            
            /*
             * the array's values have been sent to the back
             * so we have to move them forword for the print 
             * to work.
             */
            //cycle through the array
            for(int i = 0; i < size; i++)
            {
                if(temp[i] == null)
                {
                    //find the next non-null variable
                    for(int j = i; j < size; j++)
                    {
                        if(temp[j] != null)
                        {
                            temp[i] = temp[j];
                            temp[j] = null;
                            j = size;
                        }
                    }
                }
            }

            counter.ElementAt(position).shelf = temp;
        }
    }
}
