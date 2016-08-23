using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX.MotionProfile
{
    public enum StatusBits
    {
        ActiveTrajectoryIsValid = 0x1,
        HasUnderrun = 0x2,
        IsUnderrun = 0x4,
        ActiveTrajectoryIsLast = 0x8,
        ActiveTrajectoryVelocityOnly = 0x10
    }
}
