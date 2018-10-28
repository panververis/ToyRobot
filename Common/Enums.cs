using System;
using System.Collections.Generic;
using System.Text;

namespace LittleSpeedyToyRobot.Common
{
    public class Enums
    {
        public enum Direction
        {
            North   =   0,
            East    =   1,
            South   =   2,
            West    =   3
        }

        public enum SpeedysMood
        {
            IsHappyAndHopeful                               = 0,
            IsABitWorried                                   = 1,
            HasSeriousWorriesAboutHisFuture                 = 2,
            IsDamnStraightPissedOff                         = 3,
            SelfDefenceModuleEnabled_SHOOTINGLAZORBEAMS     = 4   
        }

        public enum RotationDirection
        {
            Left    = 0,
            Right   = 1
        }
    }
}
