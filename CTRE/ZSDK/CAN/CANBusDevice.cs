using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN
{
    public abstract class CANBusDevice
    {
        public UInt32 DeviceID { get; protected set; }
        public const UInt32 FullMessageIdMask = 0x1fffffff;

        public CANBusDevice(UInt32 deviceID)
        { DeviceID = deviceID; }
    }
}
