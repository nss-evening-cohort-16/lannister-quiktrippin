using System;
using System.Collections.Generic;
using System.Linq;
using Lannister_Qwiktrippin.jobs;

namespace Lannister_Qwiktrippin
{
    public class District
    {
        public string Name { get; private set; }
        public DistrictManager Manager { get; private set; }
        //public List<Store> Stores;
        public District(string _name, string _managerName)
        {
            Name = _name;
            Manager = new DistrictManager(_managerName, _name);
            //Stores = new List<Store>();
        }
    }
}
