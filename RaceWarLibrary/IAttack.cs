using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceWarLibrary
{
    public interface IAttack
    {
        string Dialog { get; set; }
        float Damage { get; set; }
        float Accuracy { get; set; }
        int StunDuration { get; set; }
        int PoisonDuration { get; set; }
        float PoisonStrength { get; set; }
        bool ChemicalAttack { get; set; }
        bool SpecialAttack { get; set; }
        int StrikeNumber { get; set; }
        void Attack(PlayerModel target, PlayerModel attacker);
        bool TargetDodge(PlayerModel target);
    }
}
