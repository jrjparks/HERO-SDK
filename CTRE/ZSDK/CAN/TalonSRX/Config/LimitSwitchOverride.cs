namespace CTRE.ZSDK.CAN.TalonSRX.Config
{
    public enum LimitSwitchOverride
    {
        DefaultsFromFlash = 1,
        DisableAll = 1 << 2,
        EnableFwd = DisableAll | 1 << 1,
        EnableRev = DisableAll | 1,
        EnableAll = EnableFwd | EnableRev
    }
}
