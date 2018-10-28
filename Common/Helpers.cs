using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    /// <summary>
    /// Public static STRICTLY STATELESS "helper" class, providing some helper public static functions
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Public static helper method checking whether the provided position is a valid one
        /// (namely, if it falls within the range of the valid positions, or if it describes a position that will lead Little Speedy off the surface)
        /// </summary>
        /// <returns></returns>
        public static bool IsPositionValid(int proposedXPosition, int proposedYPosition)
        {
            bool isValid = true;
            if (        proposedXPosition < 0 
                     || proposedXPosition > InitialParams.TableWidth - 1
                     || proposedYPosition < 0
                     || proposedXPosition > InitialParams.TableLength - 1)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
