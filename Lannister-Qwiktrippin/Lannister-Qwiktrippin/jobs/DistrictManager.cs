using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lannister_Qwiktrippin.jobs
{
    public class DistrictManager : Employee
    {
        public string DistrictName { get; set; }

        public DistrictManager(string _name, string _districtName, JobTitle _position = JobTitle.DistrictManager) : base(_name, _position)
        {
            DistrictName = _districtName;
        }
    }
}
