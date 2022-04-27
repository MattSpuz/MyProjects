using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_Systems._2
{
    public static class Program
    {
        public static InventoryTree Inventory = new InventoryTree();
        public static stack Shelved = new stack();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Inventory.CreateCategory("Bread");
            Inventory.CreateCategory("Candy");
            Inventory.Insert("m&m's", "Candy", 44);
            Inventory.Insert("snickers", "Candy", 23);
            Inventory.Insert("white bread", "Bread", 54);
            Inventory.Insert("brown bread", "Bread", 18);

            Shelved.AddShelf(15);
            Shelved.AddShelf(32);
            Shelved.AddShelf(12);
            Shelved.push(0, "m&m's", 4);
            Shelved.push(1, "snickers", 5);
            Shelved.push(2, "white bread", 2);
            Shelved.push(2, "brown bread", 4);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
