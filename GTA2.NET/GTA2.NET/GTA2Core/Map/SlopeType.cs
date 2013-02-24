﻿//Created: 09.02.2010

namespace Hiale.GTA2NET.Core.Map
{
    public enum GroundType : byte
    {
        Air = 0, Road = 1, Pavement = 2, Field = 3
    }

    public enum SlopeDirection : byte
    {
        None = 0, Up = 1, Down = 2, Left = 3, Right = 4
    }

    public enum SlopeType : byte
    {
        None = 0,
        Up26Low = 1,
        Up26High = 2,
        Down26Low = 3,
        Down26High = 4,
        Left26Low = 5,
        Left26High = 6,
        Right26Low = 7,
        Right26High = 8,
        Up7Low = 9,
        Up7High0 = 10,
        Up7High1 = 11,
        Up7High2 = 12,
        Up7High3 = 13,
        Up7High4 = 14,
        Up7High5 = 15,
        Up7High6 = 16,
        Down7Low = 17,
        Down7High0 = 18,
        Down7High1 = 19,
        Down7High2 = 20,
        Down7High3 = 21,
        Down7High4 = 22,
        Down7High5 = 23,
        Down7High6 = 24,
        Left7Low = 25,
        Left7High0 = 26,
        Left7High1 = 27,
        Left7High2 = 28,
        Left7High3 = 29,
        Left7High4 = 30,
        Left7High5 = 31,
        Left7High6 = 32,
        Right7Low = 33,
        Right7High0 = 34,
        Right7High1 = 35,
        Right7High2 = 36,
        Right7High3 = 37,
        Right7High4 = 38,
        Right7High5 = 39,
        Right7High6 = 40,
        Up45 = 41,
        Down45 = 42,
        Left45 = 43,
        Right45 = 44,
        DiagonalFacingUpLeft = 45,
        DiagonalFacingUpRight = 46,
        DiagonalFacingDownLeft = 47,
        DiagonalFacingDownRight = 48,
        DiagonalSlopeFacingUpLeft = 49, //there 2 versions of these, see documentation, check if they require a different behaviour.
        DiagonalSlopeFacingUpRight = 50, //as above
        DiagonalSlopeFacingDownLeft = 51, //as above
        DiagonalSlopeFacingDownRight = 52, //as above
        PartialBlockLeft = 53,
        PartialBlockRight = 54,
        PartialBlockTop = 55,
        PartialBlockBottom = 56,
        PartialBlockTopLeft = 57,
        PartialBlockTopRight = 58,
        PartialBlockBottomRight = 59,
        PartialBlockBottomLeft = 60,
        PartialCentreBlock = 61
    }
}
