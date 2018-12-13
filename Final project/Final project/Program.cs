using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero("Promeathean", "Commander Zeal", "Android", "Ability Replication", true);
            Hero myOtherHero = new Hero("Flash", "Zoom", "Human", "Speed", true);
            Hero thirdHero = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly");

            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want)
                 - Investigate
                 - FightCrime (at least one must win. at least one must not win)
                 - Fly (at least one superhero should be able to fly)
                 - Climb
            */

            //I decide to make a Display as well!
            myHero.Display2();

            myHero.ChargePower(1);
            myOtherHero.ChargePower(60);
            thirdHero.ChargePower(1000);

            myOtherHero.Investigate();
            myHero.Investigate();
            thirdHero.Investigate();

            myHero.FightCrime("414 Pugwash Circle");
            myOtherHero.FightCrime("New York");
            thirdHero.FightCrime("Somewhere Else");

            myHero.Fly();
            myOtherHero.Fly();
            thirdHero.Fly();

            myHero.Climb(6);
            myOtherHero.Climb(7);
            thirdHero.Climb(100);
            //just for fun!
            myHero.Craft("Iron", 5);

            Console.ReadLine();
        }
    }
}