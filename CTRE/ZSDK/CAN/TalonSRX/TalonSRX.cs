using System;
using Microsoft.SPOT;

namespace CTRE.ZSDK.CAN.TalonSRX
{
    public class TalonSRX
    {
        public LowLevel TalonSRX_IMPL { get; protected set; }
        public UInt32 ProfileSlot { get; set; }

        public Boolean IsEnabled { get; set; }
        public ControlMode ControlMode { get; set; }
        internal TalonControlMode SendMode { get; set; }

        public UInt32 EncoderCPR { get; set; }
        public UInt32 PotTurns { get; set; }
        public FeedbackDevice FeedbackDevice { get; set; }
        public Boolean IsInverted { get; set; }

        protected const Int32
            CAN_OK = 0,
            DelayForSolicitedSignalsMS = 4;
        protected const Single
            NativeAdcUnitsPerRotation = 1024.0f,
            NativePwdUnitsPerRotation = 4096.0f,
            MinutesPer100msUnit = 1.0f / 600.0f;

        public TalonSRX(UInt16 DeviceID, Boolean ExternalEnable = false)
        {
            TalonSRX_IMPL = new LowLevel(DeviceID, ExternalEnable);
            // ApplyControlMode(ControlMode);
            // TalonSRX_IMPL.SetProfileSlotSelect(m_profile);
        }
    }
}
