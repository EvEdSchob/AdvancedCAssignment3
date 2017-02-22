using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        //Adds a new droid to the array
        public void AddItem(Droid[] DroidInventory)
        {
            //Variables used by all classes
            //Type specific variables called within cases
            string material = null;
            string color = null;

            //Utility Specific properties
            bool toolbox = false;
            bool computerConnection = false;
            bool arm = false;

            //Boolean for loop, will run back through droid input
            //if the droid information is incorrect.
            //Assumed incorrect on first time through becasue no information is present.
            bool correct = false;
            Console.WriteLine("Adding a new droid. Please enter information.");
            Console.WriteLine();
            while (!correct)
            {
                switch (typeSelect())
                {
                    //Protocol
                    case 1:
                        int numberLanguages = 1;
                        Console.WriteLine("Protocol Droid");
                        Console.WriteLine();
                        correct = VerifyDroid();
                        DroidCollection.Add(material, "Protocol", color, numberLanguages, DroidInventory);
                        break;
                    //Janitorial
                    case 2:
                        Console.WriteLine("Utility Droid");
                        Console.WriteLine();
                        correct = VerifyDroid();
                        DroidCollection.Add(material, "Utility", color, toolbox, computerConnection, arm, DroidInventory);
                        break;
                    //Janitorial
                    case 3:
                        //Janitorial specific properties
                        bool trashCompactor = false;
                        bool vacuum = false;
                        Console.WriteLine("Janitorial Droid");
                        Console.WriteLine();
                        correct = VerifyDroid();
                        DroidCollection.Add(material, "Janitorial", color, toolbox, computerConnection, arm, trashCompactor, vacuum, DroidInventory);
                        break;
                    //Astromech
                    case 4:
                        bool fireExtinguisher = false;
                        int numberOfShips = 1;
                        //Astromech specific properties
                        Console.WriteLine("Astromech Droid");
                        Console.WriteLine();
                        correct = VerifyDroid();
                        DroidCollection.Add(material, "Astromech", color, toolbox, computerConnection, arm, fireExtinguisher, numberOfShips, DroidInventory);
                        break;
                }
                
            }

        }

        //Accept string input and output to screen
        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        //Display menu, read from console and parse input
        public int UserInput()
        {
            displayMenu();

            string input = Console.ReadLine();

            try
            {
                return Int32.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
                return 0;
            }
        }

        //Display menu options
        private void displayMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print droid list");
            Console.WriteLine("2. Add a new droid");
            Console.WriteLine("3. Exit" + Environment.NewLine);
            Console.Write("Make a selection: ");
        }

        //Select 
        private int typeSelect()
        {
            Console.WriteLine("What type of droid would you like to add?");
            Console.WriteLine("1. Protocol");
            Console.WriteLine("2. Utility");
            Console.WriteLine("3. Janitorial");
            Console.WriteLine("4. Astromech");
            Console.Write("Make A Selection: ");
            //Accept console input
            string input = Console.ReadLine();

            Console.WriteLine();

            //Parse user input, throw error for invalid input
            //Error is more verbose if input is not numeric
            int inputValid = 0;
            try
            {
                inputValid = Int32.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
            }

            while (inputValid != 1 && inputValid != 2 && inputValid != 3 && inputValid != 4)
            {
                Console.WriteLine("Invalid input, please select a droid type.");
                Console.WriteLine();
                typeSelect();
            }
            return inputValid;
        }

        private bool VerifyDroid()
        {
            Console.WriteLine("Is the information for this droid correct?");
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.KeyChar == 'y')
                return true;
            else
                return false;
        }
    }
}
