using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX.MotionProfile
{
    public struct Status
    {
        public UInt32 TopBufferRem { get; set; }
        public UInt32 TopBufferCount { get; set; }
        public UInt32 BottomBufferCount { get; set; }

        public Boolean HasUnderrun { get; set; }
        public Boolean IsUnderrun { get; set; }
        public Boolean ActivePointValid { get; set; }

        public TrajectoryPoint ActivePoint { get; set; }
        public SetValue OutputEnabled { get; set; }
    }
}
