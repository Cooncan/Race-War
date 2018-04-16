using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceWarLibrary
{
    class HealthPotionModel:IItems,IHeals
    {
        private string name;
        private float cost;
        private float healthRestored;
        public HealthPotionModel(string name, float cost, float healthRestored)
        {
            this.name = name;
            this.cost = cost;
            this.healthRestored = healthRestored;
        }
        public void Consume(PlayerModel consumer)
        {
            consumer.ConsumeItem(this);
        }
        public void Buy(PlayerModel buyer, ShopModel shop)
        {
            buyer.BuyItem(cost, this);
            shop.RemoveItem(this);
        }
        public void RestoreHealth(PlayerModel heal)
        {
            heal.DrinkHealItem(this);
            Consume(heal);
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public float HealthRestored
        {
            get { return healthRestored; }
            set { healthRestored = value; }
        }
    }
}
