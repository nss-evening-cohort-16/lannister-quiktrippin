using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lannister_Qwiktrippin
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

        public static string MenuSelection()
        {
            string[] choices = { "1", "2", "3", "4", "5" };
            string? input = Console.ReadLine();
            while (input == null || !choices.Contains(input))
            {
                Console.WriteLine("Enter a Valid Selection");
                input = Console.ReadLine();
            }

            return input;
        }
    }
}