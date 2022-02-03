using System;
using System.Collections.Generic;
using System.Linq;

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
4. Add a Store/District
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
    }
}