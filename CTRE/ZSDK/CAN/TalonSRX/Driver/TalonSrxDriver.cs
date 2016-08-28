using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX.Driver
{
    public class TalonSrxDriver : CANBusDevice
    {
        protected const UInt32 STATUS_1 = 0x02041400;
        protected const UInt32 STATUS_2 = 0x02041440;
        protected const UInt32 STATUS_3 = 0x02041480;
        protected const UInt32 STATUS_4 = 0x020414C0;
        protected const UInt32 STATUS_5 = 0x02041500;
        protected const UInt32 STATUS_6 = 0x02041540;
        protected const UInt32 STATUS_7 = 0x02041580;
        protected const UInt32 STATUS_8 = 0x020415C0;
        protected const UInt32 STATUS_9 = 0x02041600;
        protected const UInt32 STATUS_10 = 0x02041640;

        protected const UInt32 CONTROL_1 = 0x02040000;
        protected const UInt32 CONTROL_2 = 0x02040040;
        protected const UInt32 CONTROL_3 = 0x02040080;
        protected const UInt32 CONTROL_5 = 0x02040100;
        protected const UInt32 CONTROL_6 = 0x02040140;

        protected const UInt32 PARAM_REQUEST = 0x02041800;
        protected const UInt32 PARAM_RESPONSE = 0x02041840;
        protected const UInt32 PARAM_SET = 0x02041880;

        protected const UInt32 kParamArbIdValue = PARAM_RESPONSE;
        protected const UInt32 kParamArbIdMask = 0xFFFFFFFF;

        protected const float FLOAT_TO_FXP_10_22 = (float)0x400000;
        protected const float FXP_TO_FLOAT_10_22 = 0.0000002384185791015625f;

        protected const float FLOAT_TO_FXP_0_8 = (float)0x100;
        protected const float FXP_TO_FLOAT_0_8 = 0.00390625f;

        public TalonSrxDriver(UInt16 DeviceID, Boolean ExternalEnable)
            : base(DeviceID)
        {
            if(!ExternalEnable)
            { CTRE.Native.CAN.Send(CONTROL_1 | DeviceID, 0x00, 2, 50); }
            CTRE.Native.CAN.Send(CONTROL_5 | DeviceID, 0x00, 8, 10);
        }
    }
}
