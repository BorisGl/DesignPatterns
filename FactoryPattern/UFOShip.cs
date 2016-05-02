using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class UFOShip : Ship
    {
        public UFOShip()
        {
            Name = "UFO Ship";
            Damage = 20;
        }
    }
}
