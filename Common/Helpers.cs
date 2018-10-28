using System;
using static LittleSpeedyToyRobot.Common.Enums;

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
                     || proposedYPosition > InitialParams.TableLength - 1)
            {
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// Public static method returning a Value tuple holding the future position, after the provided as input movement forward was applied.
        /// Takes as input the current X and Y positions, as well as the direction in which the object is facing.
        /// Optional parameter denoting the number of steps taken towards given direction.
        /// </summary>
        public static (int, int) FuturePosition(int xPosition, int yPosition, Direction direction, int? steps = 1) {
            //  Guard clause, checking for invalid input
            if (!IsPositionValid(xPosition, yPosition)) {
                throw (new Exception("Unable to figure out future position after movement is applied, invalid starting position"));
            }

            //  Initializing the two variables that will hold the future position, and be returned as a Value Tuple
            int futureXPosition = xPosition;
            int futureYPosition = yPosition;

            //  Calculate future postion according to number of steps and the direction the object about to move is facing
            switch (direction) {
                case Direction.North:
                    futureYPosition += steps.Value;
                    break;
                case Direction.East:
                    futureXPosition += steps.Value;
                    break;
                case Direction.South:
                    futureYPosition -= steps.Value;
                    break;
                case Direction.West:
                    futureXPosition -= steps.Value;
                    break;
                default:
                    throw new Exception("That is weird, so this must be a new unhandled Direction the object is facing. How about the developer handling this one?");
            }

            return (futureXPosition, futureYPosition);
        }
    }
}
