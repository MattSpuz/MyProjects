using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
* Name        : BinarySearchTree
* Author      : Matthew Spuzello
* Created     : 3/22/2022
***************************************************************/


namespace Inventory_Management_Systems
{
    public class InventoryTree
    {
        public class Node
        {
            public String sData; //represents the name
            public int iData; // represents quantity of item
            public LinkedList<Node> nData = new LinkedList<Node>(); //next data
        }
        Node head;
        int size; //number of unique items

        //constructor which creates an empty tree
        public InventoryTree()
        {
            this.head = new Node();
            this.size = -1;
        }

        //determine if the tree is empty
        public bool isEmpty()
        {
            if (head.nData.Count == 0)
            {
                return true;
            }
            return false;
        }

        //inserts an item
        /*
         * This will automatically create a new product if 
         * it doesn't already exist.
         */
        public void Insert(String name, String category, int quantity)
        {
            //create tempuary node for the product
            Node iTemp = new Node();
            iTemp.sData = name;
            iTemp.iData = quantity;
            //store head data
            Node newNode = head;

            //find the right category
            int i = 0;
            while (i < newNode.nData.Count())
            {
                if (newNode.nData.ElementAt(i).sData == category)
                {
                    newNode = newNode.nData.ElementAt(i);

                    //finnish the previus loop
                    i = newNode.nData.Count();

                    //see if the item already exists
                    int j = 0;
                    while (j < newNode.nData.Count + 1)
                    {
                        //if the linkedlist is empty than create it
                        if (newNode.nData.Count() == 0)
                        {
                            //add the item
                            newNode.nData.AddLast(iTemp);

                            //finnish the previus loop
                            j = newNode.nData.Count + 1;

                            size++;
                        }
                        //if it already exists than add to the quantity
                        else if (newNode.nData.ElementAt(j).sData == name)
                        {
                            //add the quantity
                            newNode.nData.ElementAt(j).iData += quantity;

                            //finnish the previus loop
                            j = newNode.nData.Count + 1;
                        }
                        //otherwise create a new item
                        else if (j + 1 == newNode.nData.Count)
                        {
                            //add the item
                            newNode.nData.AddLast(iTemp);

                            //finnish the previus loop
                            j = newNode.nData.Count + 1;

                            size++;
                        }
                        j++;
                    }
                }
                i++;
            }





        }

        //create a new category
        public void CreateCategory(String category)
        {
            // create tempuary node for category
            Node cTemp = new Node();
            cTemp.sData = category;

            Node newNode = head;

            //add the category to the end
            newNode.nData.AddLast(cTemp);
        }

        //remove a quantity of products
        public string RemoveQuantity(String name, int quantity)
        {
            Node newNode = head;

            Node temp = new Node();

            //check if its empty
            if (isEmpty() == true)
            {
                return "nothingToRemove";
            }

            //find the category
            for (int i = 0; i < newNode.nData.Count(); i++)
            {
                //find the product
                for (int j = 0; j < newNode.nData.ElementAt(i).nData.Count; j++)
                {
                    //check if it matches
                    if (newNode.nData.ElementAt(i).nData.ElementAt(j).sData == name)
                    {
                        temp = newNode.nData.ElementAt(i).nData.ElementAt(j);
                        //remove the value
                        temp.iData -= quantity;
                        if (temp.iData < 0)
                            temp.iData = 0;
                    }
                    if (i == newNode.nData.Count())
                    {
                        //couldn't find it
                        return "NotFound";
                    }
                }
            }
            return name;
        }

        //remove a product from the list
        public String RemoveProduct(String name, String category)
        {

            Node newNode = head;

            Node temp = new Node();
            temp.sData = name;

            //check if its empty
            if (isEmpty() == true)
            {
                return "NotFound";
            }

            //find the category
            for (int i = 0; i < newNode.nData.Count(); i++)
            {
                //check if it matches
                if (newNode.nData.ElementAt(i).sData == category)
                {
                    newNode = newNode.nData.ElementAt(i);
                    //find the product
                    for (int j = 0; j < newNode.nData.Count(); j++)
                    {
                        //check if it matches
                        if (newNode.nData.ElementAt(i).sData == name)
                        {
                            //remove the value
                            newNode.nData.Remove(newNode.nData.ElementAt(j));
                        }
                        else if (j == newNode.nData.Count())
                        {
                            //couldn't find it
                            return "NotFound";
                        }
                    }
                }
                else if (i == newNode.nData.Count())
                {
                    //couldn't find it
                    return "NotFound";
                }
            }
            size--;
            return name;
        }

        //remove a whole category alltogeather
        public string RemoveCategory(String category)
        {
            Node newNode = head;

            Node temp = new Node();
            temp.sData = category;

            //check if its empty
            if (isEmpty() == true)
            {
                return "(category doesn't exist)";
            }

            for (int i = 0; i < newNode.nData.Count(); i++)
            {
                if (newNode.nData.ElementAt(i).sData == category)
                {
                    size -= newNode.nData.Count();
                    //remove the value
                    newNode.nData.Remove(newNode.nData.ElementAt(i));
                }
                else if (i == newNode.nData.Count())
                {
                    return "(category doesn't exist)";
                }
            }
            return category;
        }

        public int Size()
        {
            return size;
        }

        //returns quantity of the product
        public int ItemQuantity(string name)
        {
            Node newNode = head;

            //check if its empty
            if (isEmpty() == true)
            {
                return 0;
            }

            //find the category
            for (int i = 0; i < newNode.nData.Count(); i++)
            {
                //find the product
                for (int j = 0; j < newNode.nData.ElementAt(i).nData.Count; j++)
                {
                    //check if it matches
                    if (newNode.nData.ElementAt(i).nData.ElementAt(j).sData == name)
                    {
                        return newNode.nData.ElementAt(i).nData.ElementAt(j).iData;
                    }
                }
            }
            return 0;
        }

        //check if product exists
        public string Search(string name)
        {
            Node newNode = head;

            //check if its empty
            if (isEmpty() == true)
            {
                return "(items do not exist)";
            }

            //find the category
            for (int i = 0; i < newNode.nData.Count(); i++)
            {
                //find the product
                for (int j = 0; j < newNode.nData.ElementAt(i).nData.Count; j++)
                {
                    //check if it matches
                    if (newNode.nData.ElementAt(i).nData.ElementAt(j).sData == name)
                    {
                        return name;
                    }
                }
            }
            return "(items do not exist)";
        }

        //return true if category exists
        public bool CategoryExists(string category)
        {
            Node newNode = head;

            if (isEmpty() == true)
            {
                return false;
            }

            //find the category
            for (int i = 0; i < newNode.nData.Count(); i++)
            {
                if (newNode.nData.ElementAt(i).sData == category)
                    return true;
            }
            return false;
        }

        //print everything
        public string printProducts()
        {
            string output = "";
            Node newNode = head;


            //check if its empty
            if (isEmpty() == true)
            {
                return "(items do not exist)";
            }

            //Cycle Through the categorys
            for (int i = 0; i < newNode.nData.Count(); i++)
            {
                //Cycle Through the products
                for (int j = 0; j < newNode.nData.ElementAt(i).nData.Count; j++)
                {
                    output += newNode.nData.ElementAt(i).sData + ": " + newNode.nData.ElementAt(i).nData.ElementAt(j).sData + "\r\nQuantity: " + newNode.nData.ElementAt(i).nData.ElementAt(j).iData + "\r\n";
                }
            }
            return output;
        }
    }
}
