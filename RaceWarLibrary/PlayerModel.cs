using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceWarLibrary
{
    public class PlayerModel:CharacterModel
    {
        private RacesModel race;
        private float shekels;
        private int mana;
        private int stunDuration;
        private int poisonDuration;
        private float poisonStrength;
        private bool lost;
        private bool turn;
        private bool canUseMove;
        private List<IItems> items = new List<IItems>();
        public PlayerModel(RacesModel race, bool playerOne)
        {
            this.race = race;
            health = race.Health;
            baseHealth = race.BaseHealth;
            attackPower = race.AttackPower;
            specialAttackPower = race.SpecialAttackPower;
            chemicalAttackPower = race.ChemicalAttackPower;
            defensePower = race.DefensePower;
            specialDefensePower = race.SpecialDefensePower;
            chemicalDefensePower = race.ChemicalDefensePower;
            dodgeChance = race.DodgeChance;
            accuracy = race.Accuracy;

            shekels = 0;
            mana = 0;
            stunDuration = 0;
            poisonDuration = 0;
            poisonStrength = 0;
            lost = false;
            if (playerOne)
            {
                turn = true;
            }
            else
            {
                turn = false;
            }
            canUseMove = true;
        }
        public void BuyItem(float cost, IItems item)
        {
            shekels -= cost;
            items.Add(item);

        }
        public void UseMana(SpecialAttackModel specialAttack)
        {
            mana -= specialAttack.ManaCost;
        }
        public void DrinkHealItem(IHeals healthPotion)
        {
            HealSelf(healthPotion.HealthRestored);
        }
        public void ConsumeItem(IItems item)
        {
            items.Remove(item);
        }
        private void HealSelf(float healAmount)
        {
            health += healAmount;
        }
        public void TakeDamage(float damage)
        {
            float damageToTake = damage;
            damageToTake *= defensePower;
            health -= damageToTake;
        }
        public void TakeDamage(float damage, bool chemical)
        {
            float damageToTake = damage;
            if(chemical)
            {
                damageToTake *= chemicalDefensePower;
            }
            else
            {
                damageToTake *= defensePower;
            }
            health -= damageToTake;
        }
        public void TakeDamage(float damage, bool chemical, bool special)
        {
            float damageToTake = damage;
            if (chemical)
            {
                damageToTake *= chemicalDefensePower;
            }
            else if(special)
            {
                damageToTake *= specialDefensePower;
            }
            else
            {
                damageToTake *= defensePower;
            }
            if(health - damageToTake < 0)
            {
                health = 0;
            }
            else
            {
                health -= damageToTake;
            }
        }
        public void TakeStun(int stunDuration)
        {
            this.stunDuration += stunDuration;
        }
        public void TakePoison(int poisonDuration, float poisonStrength)
        {
            this.poisonDuration = poisonDuration;
            if(this.poisonStrength + poisonStrength > 1)
            {
                this.poisonStrength = 1;
            }
            else
            {
                this.poisonStrength += poisonStrength;
            }
        }
        public void TakePoisonDamage()
        {
            float poisonDamage = health * poisonStrength;
            poisonDamage *= chemicalDefensePower;
            TakeDamage(poisonDamage, true);
        }
        public RacesModel Race
        {
            get { return race; }
            set { race = value; }
        }
        public float Shekels
        {
            get { return shekels; }
            set { shekels = value; }
        }
        public int Mana
        {
            get { return mana; }
            set { mana = value; }
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
        public bool Lost
        {
            get { return lost; }
            set { lost = value; }
        }
        public bool Turn
        {
            get { return turn; }
            set { turn = value; }
        }
        public bool CanUseMove
        {
            get { return canUseMove; }
            set { canUseMove = value; }
        }
        public List<IItems> Items
        {
            get { return items; }
            set { items = value; }
        }
    }
}
