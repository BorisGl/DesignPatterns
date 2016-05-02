using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new UFOShip();
            Console.WriteLine("What type of ship? U or R");
            string res = Console.ReadLine();
            // Very bad //
            ShipType st;
            if (res == "u")
                 st = ShipType.UFOShip;
            else
                 st = ShipType.RocketShip;
            ShipFactory sf = new ShipFactory();
            ship = sf.CreateShip(st);
            DoStuff(ship);
            Console.ReadLine();
        }

        public static void DoStuff(Ship ship)
        {
            Console.WriteLine(ship.Name);
            ship.FollowShip();
            ship.ShipShoots();
        }

    }
}
