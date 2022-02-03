using System;
using System.Collections.Generic;

namespace Lannister_Qwiktrippin
{
    public enum JobTitle
    {
        Associate,
        AssistantManager,
        StoreManager,
        DistrictManager
    }

    public class Employee
    {
        public string Name { get; private set; }
        public JobTitle Position { get; private set; }

        public Employee(string _name, JobTitle _position)
        {
            Name = _name;
            Position = _position;
        }
    }
}
