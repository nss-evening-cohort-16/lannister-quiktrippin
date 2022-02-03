using System;
using System.Collections.Generic;
using System.Linq;

namespace Lannister_Qwiktrippin.jobs
{
    public class Associate : Employee
    {
        public int StoreNumber { get; private set; }
        public float Sales { get; private set; }

        public Associate(string _name, JobTitle _position, int _storeNumber, float _sales = 0) : base(_name, _position)
        {
            StoreNumber = _storeNumber;
            Sales = _sales;
        }

        public void AddSales(float _increase)
        {
            Sales += _increase;
        }
    }
}
