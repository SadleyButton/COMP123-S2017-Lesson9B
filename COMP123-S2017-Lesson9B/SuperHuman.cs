using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bradley Sutton
 * Date: July 13, 2017
 * Description: This is the SuperHuman class that extends the Human Abstract Class
 * Version: 0.6 - Added Stub Method DisplaySkills to conform to Human Abstract SuperClass
 */

namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the SuperHuman class
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE INSTANCE VARIABLES
        private List<Power> _powers;

        // PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers; // this returns a reference
            }
        }
        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperHuman class.
        /// It takes one parameter - name (string)
        /// </summary>
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }

        // PRIVATE METHODS

        /// <summary>
        /// This method initalizies, instantiates and assigns values to class properties.
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>(); // creates and empty list
        }

        // PUBLIC METHODS
        /// <summary>
        /// This method adds a power to the power list.
        /// It takes two parameters - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        /// <summary>
        /// This method displays each of the Powers stored in the Powers List
        /// </summary>
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + " Rank: " + power.Rank);
            }
        }

        /// <summary>
        /// Overridden the built-in ToString method
        /// </summary>
        /// <returns>
        /// string
        /// </returns>

        // PUBLIC OVERRIDDEN METHODS

        public override string ToString()
        {
            string outputString = "";
            outputString += "==================================\n";
            outputString += "SuperHuman Name: " + this.Name + "\n";
            outputString += "==================================\n";

            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " Rank: " + power.Rank + "\n";
            }

            outputString += "==================================\n";

            return outputString;
        }

        /// <summary>
        /// This method needs implimentation
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }
    }
}