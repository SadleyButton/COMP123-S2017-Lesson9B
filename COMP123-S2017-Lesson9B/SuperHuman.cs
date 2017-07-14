using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bradley Sutton
 * Date: July 13, 2017
 * Description: This is the SuperHuman class that extends the Human Abstract Class
 * Version: 0.2 - Added _initialize method
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
    }
}