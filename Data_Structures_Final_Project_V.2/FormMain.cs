using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures_Final_Project_V._2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            //Inventory = new InventoryTree();
            InitializeComponent();
        }

        //Close the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //open the inventory management form
        private void inventoryManagementButton_Click(object sender, EventArgs e)
        {
            outputBoxLabel form = new outputBoxLabel();
            form.ShowDialog();
        }

        //open the view inventory form
        private void viewInventoryButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
