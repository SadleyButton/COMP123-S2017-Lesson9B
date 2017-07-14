using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bradley Sutton
 * Date: July 14, 2017
 * Description: SuperVillain class which inherits from the SuperHuman class and impliments IHasKarma interface
 * Version: 0.2 - Modified constructor to take malice value
 */

namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the SuperVillain class
    /// </summary>
    public class SuperVillain : SuperHuman
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private int _malice;
        
        // PUBLIC PROPERTIES
        public int Malice
        {
            get { return this._malice; }
            set { this._malice = value; }
        }

        // CONSTRUCTORS

        /// <summary>
        /// Main constructor for the SuperVillain classes
        /// Takes two arugements - name (string) - malice (int)
        /// </summary>
        /// <param name="name"></param>
        public SuperVillain(string name, int malice)
            :base(name)
        {
            this.Malice = malice;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS

    }
}