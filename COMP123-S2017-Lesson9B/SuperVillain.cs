using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bradley Sutton
 * Date: July 14, 2017
 * Description: SuperVillain class which inherits from the SuperHuman class
 * Version: 0.1 - Created the SuperVillain class
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
        /// Takes one arugement - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperVillain(string name)
            :base(name)
        {
            
        }

        // PRIVATE METHODS

        // PUBLIC METHODS

    }
}