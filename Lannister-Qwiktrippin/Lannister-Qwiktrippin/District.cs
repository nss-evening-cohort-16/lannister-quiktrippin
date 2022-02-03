using System;
using System.Collections.Generic;
using System.Linq;
using Lannister_Qwiktrippin.jobs;
using Lannister_Qwiktrippin.prompts;

namespace Lannister_Qwiktrippin
{
    public class District
    {
        public string Name { get; private set; }
        public DistrictManager Manager { get; private set; }
        public List<Store> Stores;
        public District(string _name, string _managerName)
        {
            Name = _name;
            Manager = new DistrictManager(_managerName, _name);
            Stores = new List<Store>();
        }

        public static District CreateNewDistrict()
        {
            string newDistrictName = EnterDistrictName.Prompt();
            string newManagerName = EnterEmployeeName.Prompt();

            Console.WriteLine("Successfully created district.");

            return new District(newDistrictName, newManagerName);
        }
    }
}
