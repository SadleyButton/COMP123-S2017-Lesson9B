using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bradley Sutton
 * Date: July 13, 2017
 * Description: This is the Abstract Human Class
 * Version: 0.1 - Created Abstract Human Class
 */

namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the Abstract Human Class
    /// </summary>
    public abstract class Human
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _name;

        // PUBLIC PROPERTIES
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        // CONSTRUCTORS --------------------------------------

        /// <summary>
        /// This is the main constructor for the Human Class.
        /// It takes one parameter - name (string)
        /// </summary>
        public Human(string name)
        {
            this.Name = name;
        }


        // PRIVATE METHODS

        // PUBLIC METHODS


    }
}