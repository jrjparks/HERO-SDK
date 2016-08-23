using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX
{
    internal enum TalonControlMode
    {
        Throttle = 0,
        FollowerMode = 5,
        VoltageMode = 4,
        PositionMode = 1,
        SpeedMode = 2,
        CurrentMode = 3,
        MotionProfileMode = 6,
        MotionMagic = 7,
        Disabled = 15
    }
}
