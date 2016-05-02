using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ShipFactory
    {
        public Ship CreateShip(ShipType st)
        {
            Ship ship;
            switch (st)
            {
                case ShipType.UFOShip:
                    ship = new UFOShip();
                    break;
                case ShipType.RocketShip:
                    ship = new RocketShip();
                    break;
                default:
                    ship = new RocketShip();
                    break;
            }
            return ship;
        }
    }
}
