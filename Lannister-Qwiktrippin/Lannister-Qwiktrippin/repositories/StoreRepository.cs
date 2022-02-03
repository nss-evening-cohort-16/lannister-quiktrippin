using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lannister_Qwiktrippin.repositories
{
    public class StoreRepository
    {
        public static List<Store> Stores = new List<Store>();

        public static List<Store> GetStores()
        {
            foreach (Store store in Stores)
            {
                Console.WriteLine(store.storeNumber);
            }
            return Stores;
        }

        public static void SaveNewStore(Store _store)
        {
            Stores.Add(_store);
        }
    }
}
