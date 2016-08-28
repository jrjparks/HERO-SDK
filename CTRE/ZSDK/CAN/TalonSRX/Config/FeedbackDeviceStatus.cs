namespace CTRE.ZSDK.CAN.TalonSRX.Config
{
    public enum FeedbackDeviceStatus
    {
        /// <summary>
        /// Sensor status could not be determined.
        /// Not all sensors can do this.
        /// </summary>
        FeedbackStatusUnknown = 0,
        /// <summary>
        /// Sensor is present and working okay.
        /// </summary>
        FeedbackStatusPresent = 1,
        /// <summary>
        /// Sensor is not present, not plugged in, not powered, etc...
        /// </summary>
        FeedbackStatusNotPresent = 2,
    }
}
