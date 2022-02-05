using System;
using System.Collections.Generic;

namespace Lannister_Qwiktrippin.prompts
{
    public class EnterDistrictName
    {
        public static string Prompt()
        {
            Console.WriteLine(@"
Enter District Name");

            string? input = Console.ReadLine();
            while (input == null)
            {
                Console.WriteLine(@"
Enter a Valid District Name");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
