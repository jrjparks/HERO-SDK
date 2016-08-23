using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX
{
    public enum FeedbackDevice
    {
        QuadEncoder = 0,
        AnalogPot = 2,
        AnalogEncoder = 3,
        EncRising = 4,
        EncFalling = 5,
        CtreMagEncoder_Relative = 6, //!< Cross The Road Electronics Magnetic Encoder in Relative/Quadrature Mode
        CtreMagEncoder_Absolute = 7, //!< Cross The Road Electronics Magnetic Encoder in Absolute/PulseWidth Mode
        PulseWidth = 8,
    }
}
