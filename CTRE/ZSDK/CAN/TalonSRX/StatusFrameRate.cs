using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX
{
    public enum StatusFrameRate
    {
        StatusFrameRateGeneral = 0,
        StatusFrameRateFeedback = 1,
        StatusFrameRateQuadEncoder = 2,
        StatusFrameRateAnalogTempVbat = 3,
        StatusFrameRatePulseWidthMeas = 4,
        StatusFrameMotionProfile = 5,
        StatusFrameMotionMagic = 6,
    }
}
