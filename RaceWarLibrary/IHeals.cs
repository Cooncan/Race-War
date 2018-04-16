using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceWarLibrary
{
    public interface IHeals
    {
        float HealthRestored { get; set; }
        void RestoreHealth(PlayerModel target);
    }
}
