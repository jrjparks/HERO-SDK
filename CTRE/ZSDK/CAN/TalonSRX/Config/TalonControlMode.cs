namespace CTRE.ZSDK.CAN.TalonSRX.Config
{
    internal enum TalonControlMode
    {
        Throttle = 0,
        Position = 1,
        Speed = 2,
        Current = 3,
        Voltage = 4,
        Follower = 5,
        MotionProfile = 6,
        MotionMagic = 7,
        Disabled = 15
    }
}
