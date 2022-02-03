using System;
using System.Collections.Generic;

namespace Lannister_Qwiktrippin.prompts
{
    public class EnterStoreNumber
    {
        public static int Prompt()
        {
            int storeNumber;

            Console.WriteLine("Enter Store Number");

            string? input = Console.ReadLine();
            while (input == null || !int.TryParse(input, out storeNumber))
            {
                Console.WriteLine("Enter a Valid Store Number");
                input = Console.ReadLine();
            }
            return storeNumber;
        }
    }
}
