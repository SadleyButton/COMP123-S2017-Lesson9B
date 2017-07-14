using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bradley Sutton
 * Date: July 14, 2017
 * Description: Interface to define Malice Property that must be implimented in any class that subscribes
 * Version: 0.1 - Created Interface (IHasMalice)
 */

namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the IHasKarama Interface
    /// </summary>
    public interface IHasMalice
    {
        // PUBLIC PROPERTIES
        int Malice { get; set; }
    }
}