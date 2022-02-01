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

    internal class Employee
    {
        public string Name { get; private set; }
        public JobTitle Position { get; private set; }
        public int StoreNumber { get; private set; }
        public float Sales { get; private set; }

        public Employee(string _name, JobTitle _position, int _storeNumber, float _sales)
        {
            Name = _name;
            Position = _position;
            StoreNumber = _storeNumber;
            Sales = _sales;
        }

        public void AddSales(float _increase)
        {
            Sales += _increase;
        }
    }
}
