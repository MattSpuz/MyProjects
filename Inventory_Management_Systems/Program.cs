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
            Inventory.CreateCategory("gray");
            Inventory.CreateCategory("health");
            Inventory.Insert("grate", "gray", 44);
            Inventory.Insert("grat", "gray", 23);
            Inventory.Insert("food", "nom", 54);
            Inventory.Insert("medicine", "health", 18);

            Shelved.AddShelf(15);
            Shelved.AddShelf(32);
            Shelved.AddShelf(12);
            Shelved.push(0, "mon", 4);
            Shelved.push(0, "ase", 5);
            Shelved.push(0, "drom", 2);
            Shelved.push(0, "cas", 4);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
