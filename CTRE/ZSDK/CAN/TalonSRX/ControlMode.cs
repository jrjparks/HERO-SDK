using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX
{
    public enum ControlMode
    {
        PercentVbus = 0,
        Current = 1,
        Speed = 2,
        Position = 3,
        Voltage = 4,
        Follower = 5,
        MotionProfile = 6,
        MotionMagic = 7
    }
}
