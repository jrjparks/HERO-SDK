namespace CTRE.ZSDK.CAN.TalonSRX.Config
{
    public enum BrakeOverride
    {
        /* CRASHOVERIDE & ACIDBURN */
        DefaultsFromFlash = 0,
        Coast = 1 << 0,
        Break = 1 << 1,
    }
}
