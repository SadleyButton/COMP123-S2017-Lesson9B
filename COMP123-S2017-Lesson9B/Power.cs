using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bradley Sutton
 * Date: July 13, 2017
 * Description: This is the power class that names and ranks the powers.
 * Version: 0.2 - Added power constructor
 */

namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the power class which will be used as a Data Type
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        // CONSTRUCTORS -----------------------------------
        /// <summary>
        /// This is the main constructor for the power class
        /// It takes two arguments - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}