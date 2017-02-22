using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the user interface.
            UserInterface ui = new UserInterface();

            //Instantiate the droid storage array.
            Droid[] DroidInventory = new Droid[100];

            //Output Program Header
            ui.Output("************************************************************" + Environment.NewLine +
            "******                 Jawa Droid Sales               ******" + Environment.NewLine +
            "*******           Droid Inventory Management         *******" + Environment.NewLine +
            "************************************************************" + Environment.NewLine);

            int choice = ui.UserInput();

            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        //Output the full list of available droids.
                        ui.Output(DroidCollection.GetPrintString(DroidInventory));
                        choice = ui.UserInput();
                        break;
                    case 2:
                        //Add item to DroidInventory
                        ui.AddItem(DroidInventory);
                        choice = ui.UserInput();
                        break;
                    default:
                        //Output the error if there is a numerical input that is not 1-5
                        ui.Output("Error: Please enter valid numeric entry (1-3)");
                        choice = ui.UserInput();
                        break;

                }
            }
            //If UI input = 5 display farewell and close the program
            ui.Output("Goodbye!");
        }
    }
}
