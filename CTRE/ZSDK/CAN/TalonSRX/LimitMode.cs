using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX
{
    public enum LimitMode
    {
        /* Only use switches for limits */
        SwitchInputsOnly = 0,
        /* Use both switches and soft limits */
        SoftPositionLimits = 1,
        /* SRX extensions */
        /* Disable switches and disable soft limits */
        SrxDisableSwitchInputs = 2,
    }
}
