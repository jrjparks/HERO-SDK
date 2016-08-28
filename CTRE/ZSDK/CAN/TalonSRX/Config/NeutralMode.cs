namespace CTRE.ZSDK.CAN.TalonSRX.Config
{
    public enum NeutralMode
    {
        /// <summary>
        /// Use the NeutralMode that is set by the jumper wire on the CAN device.
        /// </summary>
        Jumper = 0,
        /// <summary>
        /// Stop the motor's rotation by applying a force.
        /// </summary>
        Brake = 1,
        /// <summary>
        /// Do not attempt to stop the motor. Instead allow it to coast to a stop without applying resistance.
        /// </summary>
        Coast = 2
    }
}
