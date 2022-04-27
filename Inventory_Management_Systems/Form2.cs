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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            postInventory();
            postShelves();
        }

        private void backFromView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void postInventory()
        {
            InventoryPrint.Text = Program.Inventory.printProducts();
        }

        private void postShelves()
        {
            ShelfPrint.Text = Program.Shelved.print();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            Program.Shelved.InsertionSort(0);
            ShelfPrint.Text = Program.Shelved.print();
        }
    }
}
