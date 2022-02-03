using System;
using System.Collections.Generic;
using System.Linq;

namespace Lannister_Qwiktrippin.jobs
{
    public class StoreManager : AssistantManager
    {
        public StoreManager(string _name, JobTitle _position, int _storeNumber, float _sales = 0) : base(_name, _position, _storeNumber, _sales)
        {
        }
    }
}
