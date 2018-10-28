using Common;
using LittleSpeedyToyRobot.LittleSpeedy.Interface;
using System;
using static LittleSpeedyToyRobot.Common.Enums;

namespace LittleSpeedyToyRobot.LittleSpeedy.Concrete
{
    public class Speedy : ISpeedy
    {
        #region Properties

        public int?             XPosition   { get; private set; }

        public int?             YPosition   { get; private set; }

        public Direction?       Direction   { get; private set; }

        public SpeedysMood      Mood        { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// Places LittleSpeedy if position information is correct, ignores otherwise
        /// </summary>
        public void Place(int xPosition, int yPosition, Direction direction) {
            if (Helpers.IsPositionValid(xPosition, yPosition)) {
                XPosition = xPosition;
                YPosition = yPosition;
                Direction = direction;
            }
        }

        /// <summary>
        /// Moves LittleSpeedy if position information is correct, ignores otherwise
        /// </summary>
        public void Move(int? steps = 1) {
            int futureXPosition = 0;
            int futureYPosition = 0;
            (futureXPosition, futureYPosition) = Helpers.FuturePosition(XPosition.Value, YPosition.Value, Direction.Value);
            if (Helpers.IsPositionValid(futureXPosition, futureYPosition)) {
                switch (Direction.Value) {
                    case Common.Enums.Direction.North:
                        YPosition++;
                        break;
                    case Common.Enums.Direction.East:
                        XPosition++;
                        break;
                    case Common.Enums.Direction.South:
                        YPosition--;
                        break;
                    case Common.Enums.Direction.West:
                        XPosition--;
                        break;
                    default:
                        break;
                }
            }
        }

        public string Report(bool? addMoodReport = false) {
            string reportText = $"Hello! I am at position X:{XPosition} - Y:{YPosition}, and I am facing {Direction.Value.ToString()}";
            return reportText;
        }

        public void Right(int? times = 1) {
            switch (Direction.Value)
            {
                case Common.Enums.Direction.North:
                    Direction = Common.Enums.Direction.East;
                    break;
                case Common.Enums.Direction.East:
                    Direction = Common.Enums.Direction.South;
                    break;
                case Common.Enums.Direction.South:
                    Direction = Common.Enums.Direction.West;
                    break;
                case Common.Enums.Direction.West:
                    Direction = Common.Enums.Direction.North;
                    break;
                default:
                    break;
            }
        }

        public void Left(int? times = 1) {
            switch (Direction.Value)
            {
                case Common.Enums.Direction.North:
                    Direction = Common.Enums.Direction.West;
                    break;
                case Common.Enums.Direction.West:
                    Direction = Common.Enums.Direction.South;
                    break;
                case Common.Enums.Direction.South:
                    Direction = Common.Enums.Direction.East;
                    break;
                case Common.Enums.Direction.East:
                    Direction = Common.Enums.Direction.North;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
