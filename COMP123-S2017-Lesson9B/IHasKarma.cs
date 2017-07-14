using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bradley Sutton
 * Date: July 14, 2017
 * Description: Interface to define Karma Property that must be implimented in any class that subscribes
 * Version: 0.1 - Created Interface (IHasKarma)
 */

namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the IHasKarama Interface
    /// </summary>
    public interface IHasKarma
    {
        // PUBLIC PROPERTIES
        int Karma { get; set; }
    }
}