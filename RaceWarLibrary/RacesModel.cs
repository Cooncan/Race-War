using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceWarLibrary
{
    public class RacesModel:CharacterModel
    {
        private string race;
        public RacesModel(string race)
        {
            this.race = race;
            if(race == "Cuban")
            {
                health = 250000;
                baseHealth = 250000;
                attackPower = 1.4F;
                specialAttackPower = 1.4F;
                chemicalAttackPower = 1.4F;
                defensePower = 0.69F;
                specialDefensePower = 1;
                chemicalDefensePower = 0.95F;
                dodgeChance = 0.4F;
                accuracy = 0.7F;
                specialAttacks.Add(new SpecialAttackModel("Venom Machete", "The Cuban strikes with his venomous Machete.", 30000, 0.8F, 0, 2, 0.2F,1, 10));
                specialAttacks.Add(new SpecialAttackModel("Neurotoxin Machete", "The Cuban strikes with his WMD Machete", 50000, 0.75F,3,2,0.1F,1, 15));
                specialAttacks.Add(new SpecialAttackModel("Botox Machete", "How the fuck did he get botulinum toxin?", 1, 0.1F, 0, 1, 1, 1, 30));
            }
            else if(race == "Mexican")
            {
                health = 330000;
                baseHealth = 330000;
                attackPower = 1.7F;
                specialAttackPower = 1.7F;
                chemicalAttackPower = 1.7F;
                defensePower = 0.7F;
                specialDefensePower = 2;
                chemicalDefensePower = 0.95F;
                dodgeChance = 0.1F;
                accuracy = 0.6F;
            }

        }
        public string Race
        {
            get { return race; }
            set { race = value; }
        }
    }
}
