using System;
using System.Collections.Generic;

namespace Lannister_Qwiktrippin.prompts
{
    public class EnterEmployeeName
    {
        public static string Prompt()
        {
            Console.WriteLine(@"
Enter Employee Name");

            string? input = Console.ReadLine();
            while (input == null)
            {
                Console.WriteLine(@"
Enter a Valid Employee Name");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
