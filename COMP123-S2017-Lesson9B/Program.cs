using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Bradley Sutton
 * Date: July 13, 2017
 * Description: Lesson 9
 * Version: 0.7 - Display the SuperHero Karma value
 */

namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero Dude", 20);
            //SuperHero.Powers.Add(new Power("Spider Climbing", 50));
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            superHero.AddPower("Spider Sense", 75);
            //SuperHero.DisplayPowers();
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma: " + superHero.Karma);
        }
    }
}
