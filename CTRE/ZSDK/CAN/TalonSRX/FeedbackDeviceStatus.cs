using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX
{
    public enum FeedbackDeviceStatus
    {
        FeedbackStatusUnknown = 0,      //!< Sensor status could not be determined.  Not all sensors can do this.
        FeedbackStatusPresent = 1,      //!< Sensor is present and working okay.
        FeedbackStatusNotPresent = 2,   //!< Sensor is not present, not plugged in, not powered, etc...
    }
}
