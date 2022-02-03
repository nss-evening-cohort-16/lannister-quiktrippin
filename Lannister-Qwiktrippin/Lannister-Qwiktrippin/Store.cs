using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lannister_Qwiktrippin
{
    class Store
    {
        List<string> store = new List<string>();
        public float GasSale { get; set; }
        public float RetailSale { get; set; }
        public Store (float gasSale, float retailSale)
        {
            GasSale = gasSale;
            RetailSale = retailSale;
        }
    }
}
