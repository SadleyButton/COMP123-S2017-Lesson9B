using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Bradley Sutton
 * Date: July 13, 2017
 * Description: Lesson 9
 * Version: 0.8 - Create and display the SuperVillain with related Malice value
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

            Console.WriteLine("\n==========================================================\n");

            SuperVillain superVillain = new SuperVillain("SuperVillain Dude", 55);
            superVillain.AddPower("Transform", 45);
            superVillain.AddPower("Telepathy", 25);
            superVillain.AddPower("Manipulation", 30);
            Console.WriteLine(superVillain.ToString());
            Console.WriteLine("Malice: " + superVillain.Malice);
        }
    }
}
