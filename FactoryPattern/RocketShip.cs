using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class RocketShip : Ship
    {
        public RocketShip()
        {
            Name = "Rocket Ship";
            Damage = 100;
        }
    }
}
