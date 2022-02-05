using System;
using System.Collections.Generic;
using System.Linq;
using Lannister_Qwiktrippin.jobs;
using Lannister_Qwiktrippin.prompts;
using Lannister_Qwiktrippin.repositories;

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

        public static void CreateNewDistrict()
        {
            string newDistrictName = EnterDistrictName.Prompt();
            string newManagerName = EnterEmployeeName.Prompt();

            DistrictRepository.SaveNewDistrict(new District(newDistrictName, newManagerName));

            Console.WriteLine(@$"
Successfully created {newDistrictName} district, managed by {newManagerName}.");
        }
    }
}
