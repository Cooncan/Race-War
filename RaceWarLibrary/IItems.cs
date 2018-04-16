using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceWarLibrary
{
    public interface IItems
    {
        string Name { get; set; }
        float Cost { get; set; }

        void Buy(PlayerModel buyer, ShopModel shop);
        void Consume(PlayerModel consumer);
    }
}
