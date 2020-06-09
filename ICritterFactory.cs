using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CritterBrains;

namespace CritterBrains
{
    /// <summary>
    /// You must implement this class to identify your critter brains to the CritterWorld system.
    /// </summary>
    public interface ICritterFactory
    {
        IEnumerable<CritterBrain> GetCritterBrains();
    }
}
