using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CritterBrains
{
    public interface ICritter
    {
        /// <summary>
        /// Stop the critter
        /// </summary>
        void Stop();

        /// <summary>
        /// Get/Set critter speed
        /// </summary>
        int Speed { set; get; }

        /// <summary>
        /// Get/Set the critter's direction
        /// </summary>
        int Direction { set; get; }

        /// <summary>
        /// Get the critter's energy level
        /// </summary>
        int Energy { get; }

        /// <summary>
        /// Get the critter's age
        /// </summary>
        int Age { get; }

        /// <summary>
        /// Obtain the direction needed to head toward a specified object.
        /// </summary>
        /// <param name="other">Other object</param>
        /// <returns>Direction in degrees</returns>
        int GetDirectionTo(IWorldObject other);

        /// <summary>
        /// Get the direction needed to head toward a specified coordinate.
        /// </summary>
        /// <param name="x">Horizontal coordinate</param>
        /// <param name="y">Vertical coordinate</param>
        /// <returns>Direction in degrees</returns>
        int GetDirectionTo(int x, int y);

        /// <summary>
        /// Get the coordinates of the destination.
        /// </summary>
        /// <returns></returns>
        Rectangle GetDestination();

        /// <summary>
        /// Return true if terrain is blocking line-of-sight to a target coordinate.
        /// </summary>
        /// <param name="x">Horizontal coordinate of target</param>
        /// <param name="y">Vertical coordinate of target</param>
        /// <returns>true or false</returns>
        bool IsTerrainBlockingRouteTo(int x, int y);

        /// <summary>
        /// Return true if terrain is blocking line-of-sight to a target object.
        /// </summary>
        /// <param name="other">Other object</param>
        /// <returns>true or false</returns>
        bool IsTerrainBlockingRouteTo(IWorldObject other);

        /// <summary>
        /// Obtain the strength of a specified critter.
        /// </summary>
        /// <param name="otherCritter">Other critter</param>
        /// <returns>Strength of critter</returns>
        Strength GetStrengthOf(IOtherCritter otherCritter);

        /// <summary>
        /// Launch an attack on a critter.
        /// </summary>
        /// <param name="otherCritter">Target critter</param>
        /// <returns>Result of attack</returns>
        EnumAttackResult Attack(IOtherCritter otherCritter);

        /// <summary>
        /// Obtain my horizontal coordinate
        /// </summary>
        int X { get; }

        /// <summary>
        /// Obtain my vertical coordinate
        /// </summary>
        int Y { get; }

        /// <summary>
        /// Scan for nearby objects.
        /// </summary>
        /// <returns>Array of nearby objects.</returns>
        IWorldObject[] Scan();
    }
}
