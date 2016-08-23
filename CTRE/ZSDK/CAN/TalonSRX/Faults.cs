namespace CTRE.ZSDK.CAN.TalonSRX
{
    public enum Faults
    {
        Current = 1 << 0,
        Temperature = 1 << 1,
        BusVoltage = 1 << 2,
        GateDriver = 1 << 3,
        /* SRX Extentions */
        FwdLimitSwitch = 0x10,
        RevLimitSwitch = 0x20,
        FwdSoftLimit = 0x40,
        RevSoftLimit = 0x80,
    }
}
