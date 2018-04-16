using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceWarLibrary
{
    public class SpecialAttackModel:IAttack
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
        private int strikeNumber;
        private int manaCost;
        public SpecialAttackModel(string name, string dialog, float damage, float accuracy, int stunDuration, int poisonDuration, float poisonStrength, int strikeNumber, int manaCost)
        {
            this.name = name;
            this.dialog = dialog;
            this.damage = damage;
            this.accuracy = accuracy;
            this.stunDuration = stunDuration;
            this.poisonDuration = poisonDuration;
            this.poisonStrength = poisonStrength;
            this.strikeNumber = strikeNumber;
            this.manaCost = manaCost;
            chemicalAttack = false;
            specialAttack = true;
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
            attacker.UseMana(this);
        }
        public bool TargetDodge(PlayerModel target)
        {
            bool dodge = false;
            return dodge;
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
        public int StrikeNumber
        {
            get { return strikeNumber; }
            set { strikeNumber = value; }
        }
        public int ManaCost
        {
            get { return manaCost; }
            set { manaCost = value; }
        }
    }
}
