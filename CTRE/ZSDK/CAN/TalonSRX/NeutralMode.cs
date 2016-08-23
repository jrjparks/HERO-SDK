using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX
{
    public enum NeutralMode
    {
        /* Use the NeutralMode that is set by the jumper wire on the CAN device */
        Jumper = 0,
        /* Stop the motor's rotation by applying a force. */
        Brake = 1,
        /* Do not attempt to stop the motor. Instead allow it to coast to a stop
           without applying resistance. */
        Coast = 2
    }
}
