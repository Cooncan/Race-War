using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RaceWarLibrary
{
    public class WeaponModel:IItems, IAttack
    {
        private string name;
        private string dialog;
        private float damage;
        private float accuracy;
        private int stunDuration;
        private int poisonDuration;
        private float poisonStrength;
        private bool chemicalAttack;
        private bool specialAttack;
        private float cost;
        private int strikeNumber;

        public WeaponModel(string name, string dialog, float damage, float accuracy, int stunDuration, int poisonDuration, float poisonStrength, bool chemicalAttack, float cost, int strikeNumber)
        {
            this.name = name;
            this.dialog = dialog;
            this.damage = damage;
            this.accuracy = accuracy;
            this.stunDuration = stunDuration;
            this.poisonDuration = poisonDuration;
            this.poisonStrength = poisonStrength;
            this.chemicalAttack = chemicalAttack;
            this.cost = cost;
            this.strikeNumber = strikeNumber;
            specialAttack = false;
        }
        public void Consume(PlayerModel consumer)
        {
            consumer.ConsumeItem(this);
        }
        public void Attack(PlayerModel target, PlayerModel attacker)
        {
            for(int i = 0; i < strikeNumber; i++)
            {
                if (!TargetDodge(target))
                {
                    target.TakeDamage(damage, chemicalAttack);
                    target.TakeStun(stunDuration);
                    target.TakePoison(poisonDuration, poisonStrength);
                }
            }
            Consume(attacker);
        }
        public bool TargetDodge(PlayerModel target)
        {
            bool dodge = false;
            return dodge;
        }
        public void Buy(PlayerModel buyer, ShopModel shop)
        {
            buyer.BuyItem(cost,this);
            shop.RemoveItem(this);
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Dialog
        {
            get { return dialog; }
            set { dialog = value; }
        }
        public float Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public float Accuracy
        {
            get { return accuracy; }
            set { accuracy = value; }
        }
        public int StunDuration
        {
            get { return stunDuration; }
            set { stunDuration = value; }
        }
        public int PoisonDuration
        {
            get { return poisonDuration; }
            set { poisonDuration = value; }
        }
        public float PoisonStrength
        {
            get { return poisonStrength; }
            set { poisonStrength = value; }
        }
        public bool ChemicalAttack
        {
            get { return chemicalAttack; }
            set { chemicalAttack = value; }
        }
        public bool SpecialAttack
        {
            get { return specialAttack; }
            set { specialAttack = value; }
        }
        public float Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public int StrikeNumber
        {
            get { return strikeNumber; }
            set { strikeNumber = value; }
        }
    }
}
