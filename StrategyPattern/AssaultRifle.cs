using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class AssaultRifle : Weapon
    {
        public AssaultRifle()
        {
            base.BurstMode = new CanBurst();
        }
    }
}
