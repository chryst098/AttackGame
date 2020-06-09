using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CritterBrains
{
    /// <summary>
    /// Data about an object in the world.
    /// </summary>
    public interface IWorldObject
    {
        string Type { get; }
        int X { get; }
        int Y { get; }
        int BoundingRadius { get; }
    }
}
