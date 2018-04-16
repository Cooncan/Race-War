using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceWarLibrary
{
    public class CharacterModel
    {
        protected float health;
        protected float baseHealth;
        protected float attackPower;
        protected float specialAttackPower;
        protected float chemicalAttackPower;
        protected float defensePower;
        protected float specialDefensePower;
        protected float chemicalDefensePower;
        protected float dodgeChance;
        protected float accuracy;
        protected List<SpecialAttackModel> specialAttacks = new List<SpecialAttackModel>();

        public float Health
        {
            get { return health; }
            set { health = value; }
        }
        public float BaseHealth
        {
            get { return baseHealth; }
            set { baseHealth = value; }
        }
        public float AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }
        public float SpecialAttackPower
        {
            get { return specialAttackPower; }
            set { specialAttackPower = value; }
        }
        public float ChemicalAttackPower
        {
            get { return chemicalAttackPower; }
            set { chemicalAttackPower = value; }
        }
        public float DefensePower
        {
            get { return defensePower; }
            set { defensePower = value; }
        }
        public float SpecialDefensePower
        {
            get { return specialDefensePower; }
            set { specialDefensePower = value; }
        }
        public float ChemicalDefensePower
        {
            get { return chemicalDefensePower; }
            set { chemicalDefensePower = value; }
        }
        public float DodgeChance
        {
            get { return dodgeChance; }
            set { dodgeChance = value; }
        }
        public float Accuracy
        {
            get { return accuracy; }
            set { accuracy = value; }
        }
        public List<SpecialAttackModel> SpecialAttacks
        {
            get { return specialAttacks; }
            set { specialAttacks = value; }
        }
    }
}
