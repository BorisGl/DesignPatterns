using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface Burst
    {
        string BurstMode();
    }
    class CanBurst : Burst
    {
        public string BurstMode()
        {
            return ("Burst fire mode. ta ta ta");
        }
    }

    class CantBurst : Burst
    {
        public string BurstMode()
        {
            return ("Can't fire Burst mode.");
        }
    }

}
