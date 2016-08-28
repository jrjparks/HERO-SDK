namespace CTRE.ZSDK.CAN.TalonSRX.Config
{
    public enum FeedbackDevice
    {
        QuadEncoder = 0,
        AnalogPot = 2,
        AnalogEncoder = 3,
        EncRising = 4,
        EncFalling = 5,
        /// <summary>
        /// Cross The Road Electronics Magnetic Encoder in Relative/Quadrature Mode.
        /// </summary>
        CtreMagEncoder_Relative = 6,
        /// <summary>
        /// Cross The Road Electronics Magnetic Encoder in Absolute/PulseWidth Mode
        /// </summary>
        CtreMagEncoder_Absolute = 7,
        PulseWidth = 8,
    }
}
