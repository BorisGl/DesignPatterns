using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class Ship
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public void FollowShip()
        {
            Console.WriteLine(Name +" Following Ship");
        }

        public void ShipShoots()
        {
            Console.WriteLine(Name + " Ship is shooting " + Damage + " Danmage done");
        }
    }
}
