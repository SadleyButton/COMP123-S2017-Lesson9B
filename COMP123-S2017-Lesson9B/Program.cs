﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Bradley Sutton
 * Date: July 13, 2017
 * Description: Lesson 9
 * Version: 0.5 - Used the ToString method of the SuperHuman class
 */

namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            //superHuman.Powers.Add(new Power("Spider Climbing", 50));
            superHuman.AddPower("Spider Climbing", 50);
            superHuman.AddPower("Webcasting", 40);
            superHuman.AddPower("Spider Sense", 75);
            //superHuman.DisplayPowers();
            Console.WriteLine(superHuman.ToString());
        }
    }
}
