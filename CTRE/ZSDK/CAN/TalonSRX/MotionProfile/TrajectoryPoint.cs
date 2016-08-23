using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX.MotionProfile
{
    public struct TrajectoryPoint
    {
        public Single Position { get; set; }
        public Single Velocity { get; set; }

        public UInt32 TimeDurationMS { get; set; }
        public UInt32 ProfileSlot { get; set; }

        public Boolean VelocityOnly { get; set; }
        public Boolean IsLastPoint { get; set; }
        public Boolean ZeroPos { get; set; }
    }
}
