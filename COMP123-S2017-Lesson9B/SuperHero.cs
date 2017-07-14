using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bradley Sutton
 * Date: July 14, 2017
 * Description: SuperHero class which inherits from the SuperHuman class and impliments IHasKarma interface
 * Version: 0.2 - Modified constructor to take karma value
 */

namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the SuperHero class
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private int _karma;
        
        // PUBLIC PROPERTIES
        public int Karma
        {
            get { return this._karma; }
            set { this._karma = value; }
        }

        // CONSTRUCTORS

        /// <summary>
        /// Main constructor for the SuperHero classes
        /// Takes one arugement - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHero(string name, int karma)
            :base(name)
        {
            this.Karma = karma;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS

    }
}