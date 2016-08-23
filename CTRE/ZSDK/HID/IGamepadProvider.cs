using System;

namespace CTRE.ZSDK.HID
{
    public interface IGamepadProvider
    {
        Int32 Get(ref GamepadValues value);
        Int32 Set();
    }
}
