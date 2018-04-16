using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceWarLibrary
{
    public class ShopModel
    {
        private List<IItems> items = new List<IItems>();
        public void GenerateItems(bool firstGeneration)
        {
            items.Clear();
        }
        public void RemoveItem(IItems item)
        {
            items.Remove(item);
        }
    }
}
