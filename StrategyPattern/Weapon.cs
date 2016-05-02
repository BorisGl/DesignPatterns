using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Weapon
    {
        public Burst BurstMode { get; set; }

        public void FireBurst()
        {
            Console.WriteLine(BurstMode.BurstMode());
        }
    }
}
