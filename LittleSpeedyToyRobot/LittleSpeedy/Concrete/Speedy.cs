using LittleSpeedyToyRobot.LittleSpeedy.Interface;
using System;
using static LittleSpeedyToyRobot.Common.Enums;

namespace LittleSpeedyToyRobot.LittleSpeedy.Concrete
{
    public class Speedy : ISpeedy
    {
        public int?             XPosition   { get; private set; }

        public int?             YPosition   { get; private set; }

        public Direction?       Direction   { get; private set; }

        public SpeedysMood      Mood        { get; private set; }

        public void Place(int xPosition, int yPosition, Direction direction) {
            throw new NotImplementedException();
        }

        public void Move(int? steps = 1) {
            throw new NotImplementedException();
        }

        public string Report(bool? addMoodReport = false) {
            throw new NotImplementedException();
        }

        public void Right(int? times = 1) {
            throw new NotImplementedException();
        }

        public void Left(int? times = 1) {
            throw new NotImplementedException();
        }
    }
}
