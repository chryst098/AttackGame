using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Forms a wrapper around the IOtherCritter interface to ensure that brains can only call the methods
// we want them to call.

namespace CritterBrains
{
    public class OtherCritter
    {
        IOtherCritter _otherCritter;
        ICritter _me;

        public OtherCritter(IOtherCritter otherCritter, ICritter me)
        {
            _otherCritter = otherCritter;
            _me = me;
        }

        /// <summary>
        /// Returns the strength of the other critter
        /// </summary>
        public Strength Strength
        {
            get
            {
                return _me.GetStrengthOf(_otherCritter);

            }
        }

        /// <summary>
        /// Attack the other critter
        /// </summary>
        public void Attack()
        {
            _me.Attack(_otherCritter);
        }
        
        /// <summary>
        /// Return the direction to the other critter
        /// </summary>
        public int DirectionTo
        {
            get
            {
                return _me.GetDirectionTo(_otherCritter);
            }
        }

        /// <summary>
        /// Is terrain blocking the direct route to the other critter?
        /// </summary>
        public bool IsTerrainBlockingRouteTo
        {
            get
            {
                return _me.IsTerrainBlockingRouteTo((IWorldObject)_otherCritter);
            }
        }

    }
}
