using System;
using System.Collections.Generic;
using System.Linq;
using Lannister_Qwiktrippin;

namespace Lannister_Qwiktrippin.prompts
{
    public class Menu
    {
        public static void MainMenu()
        {

            Console.WriteLine(@"
QuikTrip Management Systems

1. Enter District Sales
2. Generate District Report
3. Add New Employee
4. Add a District/Store
5. Exit
");
        }

        public static int MenuSelection(int _choices)
        {
            int selection;
            int[] choices = Enumerable.Range(1, _choices).ToArray();

            string? input = Console.ReadLine();
            while (input == null || !int.TryParse(input, out selection) || !choices.Contains(selection))
            {
                Console.WriteLine("Enter a Valid Selection");
                input = Console.ReadLine();
            }

            return selection;
        }

        public static void MainMenuLoop()
        {
            MainMenu();
            int selection = MenuSelection(5);
            switch (selection)
            {
                case 1: /* Enter Sales */ break;
                case 2: /*Generate District Report */ break;
                case 3: Employee.CreateNewEmployee();  break;
                case 4: AddDistrictOrStore(); break;
                case 5: Environment.Exit(0); break; // Exit program
            }
        }

        public static void AddDistrictOrStore()
        {
            Console.WriteLine(@"
Add New District or Store
1. District
2. Store
");

            int selection = MenuSelection(2);
            switch (selection)
            {
                case 1: District.CreateNewDistrict(); break;
                case 2: /* Create Store */ break;
            }

            MainMenuLoop();
        }
    }
}