﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lannister_Qwiktrippin
{
    class Store
    {
        public List<Employee> employees;
        public int storeNumber;
        public float GasSale { get; set; }
        public float RetailSale { get; set; }
        public Store(int _storeNumber, float _gasSale = 0, float _retailSale = 0)
        {
            GasSale = _gasSale;
            RetailSale = _retailSale;
            employees = new List<Employee>();

        }

        public void AddStoreSale(float _increase)
        {
            GasSale += _increase;
            RetailSale += _increase;

        }
    }
}
