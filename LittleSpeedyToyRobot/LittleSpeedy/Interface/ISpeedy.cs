using System;
using System.Collections.Generic;
using System.Text;
using static LittleSpeedyToyRobot.Common.Enums;

namespace LittleSpeedyToyRobot.LittleSpeedy.Interface
{
    public interface ISpeedy
    {
        #region Properties (designed so that they can be publicly visible, but NOT able to be publicly modified)

        /// <summary>
        /// X Position on the table
        /// </summary>
        int?        XPosition   { get; }

        /// <summary>
        /// Y Position on the table
        /// </summary>
        int?        YPosition   { get; }

        /// <summary>
        /// Speedy's direction
        /// </summary>
        Direction?  Direction   { get; }

        /// <summary>
        /// Speedy's mood (he has feelings as well, you know)
        /// </summary>
        SpeedysMood Mood        { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Places Speedy on the table in the provided as input position, facing in the provided as input direction
        /// </summary>
        void Place(int xPosition, int yPosition, Direction direction);

        /// <summary>
        /// Speedy moves towards the direction he is facing. 
        /// Optional parameter with a defaut value of one denotes the number of "steps" he is taking forward
        /// </summary>
        void Move(int? steps = 1);

        /// <summary>
        /// Speedy reports hsi status. If you care about his feelings as well, you will also enquire about his mood.
        /// Default value of that option is set to false.
        /// </summary>
        string Report(bool? addMoodReport = false);

        /// <summary>
        /// Speedy turns right.
        /// Optional parameter with a defaut value of one denotes the number of 90 degree rotations he is performing
        /// </summary>
        void Right(int? times = 1);

        /// <summary>
        /// Speedy turns left.
        /// Optional parameter with a defaut value of one denotes the number of 90 degree rotations he is performing
        /// </summary>
        void Left(int? times = 1);

        #endregion
    }
}
