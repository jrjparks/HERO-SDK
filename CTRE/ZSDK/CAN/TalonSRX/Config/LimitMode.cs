namespace CTRE.ZSDK.CAN.TalonSRX.Config
{
    public enum LimitMode
    {
        /// <summary>
        /// Only use switches for limits.
        /// </summary>
        SwitchInputsOnly = 0,
        /// <summary>
        /// Use both switches and soft limits.
        /// </summary>
        SoftPositionLimits = 1,
        /// <summary>
        /// SRX extensions.
        /// Disable switches and disable soft limits.
        /// </summary>
        SrxDisableSwitchInputs = 2,
    }
}
