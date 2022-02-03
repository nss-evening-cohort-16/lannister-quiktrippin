using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lannister_Qwiktrippin.repositories
{
    public class DistrictRepository
    {
        public static List<District> Districts = new List<District>();

        public static List<District> GetDistricts()
        {
            foreach (District district in Districts)
            {
                Console.WriteLine(district.Name);
            }
            return Districts;
        }

        public static void SaveNewDistrict(District _district)
        {
            Districts.Add(_district);
        }
    }
}
