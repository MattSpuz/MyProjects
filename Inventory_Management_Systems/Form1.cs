using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_Systems._2
{
    public partial class outputBoxLabel : Form
    {
        public outputBoxLabel()
        {
            //sends the data from Form1 to formMain

            InitializeComponent();
        }

        //closes the form
        private void backToMainButton_Click(object sender, EventArgs e)
         {
            this.Close();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            string categoryName = addCategoryNameInput.Text;
            Program.Inventory.CreateCategory(categoryName);

            //clear all the boxes
            AllClear();
        }

        private void removeCategoryButton_Click(object sender, EventArgs e)
        {
            string categoryName = removeCategoryNameInput.Text;
            if (!Program.Inventory.CategoryExists(categoryName))
            {
                AllClear();
                OutputLabelBox.Text = "Category your looking for doesn't exist";
            }
            else
            {
                AllClear();
                Program.Inventory.RemoveCategory(categoryName);
            }
        }

        private void AllClear()
        {
            //clear all inputs
            addShelfSizeInput.Text = "";
            removeShelfInput.Text = "";
            addCategoryNameInput.Text = "";
            removeCategoryNameInput.Text = "";
            addItemName.Text = "";
            addItemCategory.Text = "";
            AddItemQuantity.Text = "";
            removeItemName.Text = "";
            removeItemQuantity.Text = "";
            OutputLabelBox.Text = "";
            transferName.Text = "";
            transferQuantity.Text = "";
            TransferPosition.Text = "";
            sellItemBox.Text = "";
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            string name = addItemName.Text;
            string category = addItemCategory.Text;
            int quantity;

            //check if inputs are the right variabels
            if (!Program.Inventory.CategoryExists(category))
            {
                AllClear();
                OutputLabelBox.Text = "Category must exist";
                return;
            }
            if (name == "" || category == "")
            {
                AllClear();
                OutputLabelBox.Text = "Must enter values for all entries";
                return;
            }
            try
            {
                quantity = Convert.ToInt32(AddItemQuantity.Text);
            }
            catch (FormatException)
            {
                AllClear();
                OutputLabelBox.Text = "Must enter a number value for quantity";
                return;
            }


            //add the item
            AllClear();
            Program.Inventory.Insert(name, category, quantity);
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            string name = removeItemName.Text;
            string category = removeItemCategory.Text;
            int quantity;

            //check if inputs are the right variabels
            if (name == "")
            {
                AllClear();
                OutputLabelBox.Text = "Must enter values for all entries";
                return;
            }
            try
            {
                quantity = Convert.ToInt32(removeItemQuantity.Text);
            }
            catch (FormatException)
            {
                AllClear();
                OutputLabelBox.Text = "Must enter a number value for quantity";
                return;
            }

            //remove the item
            AllClear();
            Program.Inventory.RemoveProduct(name, category);
        }

        private void addShelfButton_Click(object sender, EventArgs e)
        {
            int shelfSize;

            //check if shelfSize is an integer
            try
            {
                shelfSize = Convert.ToInt32(addShelfSizeInput.Text);
            }
            catch (FormatException)
            {
                AllClear();
                OutputLabelBox.Text = "Must enter a number value for size";
                return;
            }

            //add shelf
            AllClear();
            Program.Shelved.AddShelf(shelfSize);
        }

        private void removeShelfButton_Click(object sender, EventArgs e)
        {
            int position;

            //check if position is an integer
            if (Program.Shelved.isEmpty())
            {
                AllClear();
                OutputLabelBox.Text = "Must enter a value";
            }
            try
            {
                position = Convert.ToInt32(removeShelfInput.Text);
            }
            catch (FormatException)
            {
                AllClear();
                OutputLabelBox.Text = "Must enter a number value for position";
                return;
            }
            AllClear();
            Program.Shelved.RemoveShelf(position);
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            string itemName = transferName.Text;
            int itemPosition;
            int numOfItems;

            //check if numOfItems is an integer
            try
            {
                numOfItems = Convert.ToInt32(transferQuantity.Text);
                itemPosition = Convert.ToInt32(TransferPosition.Text);
            }
            catch (FormatException)
            {
                AllClear();
                OutputLabelBox.Text = "Must enter an integer for quantity and/or position";
                return;
            }
            AllClear();

            //check if the items exist and remove them
            if (Program.Inventory.Search(itemName) == "(items do not exist)")
            {
                OutputLabelBox.Text = "The item must exist within the inventory";
                return;
            }
            //check for too many items
            if (Program.Shelved.maxSize(itemPosition) - Program.Shelved.size(itemPosition) < numOfItems)
            {
                OutputLabelBox.Text = "Too many Items trying to remove";
                return;
            }
            
            //remove the product from inventory
            Program.Inventory.RemoveQuantity(itemName, numOfItems);

            //add the product to the shelfs
            Program.Shelved.push(itemPosition, itemName, numOfItems);
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            int position;

            //check if position is an integer
            try
            {
                position = Convert.ToInt32(sellItemBox.Text);
            }
            catch (FormatException)
            {
                AllClear();
                OutputLabelBox.Text = "Must enter an integer for position";
                return;
            }
            
            //check if the shelves are empty
            if (Program.Shelved.isEmpty() == true)
            {
                OutputLabelBox.Text = "The Shelves are currently empty";
                return;
            }

            AllClear();
            Program.Shelved.pop(position);
        }
    }
}
