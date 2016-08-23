using System;

namespace CTRE.ZSDK.HID
{
    public enum UsbHostDeviceMode
    {
        Auto = 0,
        Device = 1 << 0,
        Host = 1 << 1,
    }

    public class UsbHostDevice : IGamepadProvider
    {
        protected static UsbHostDevice _instance;
        /// <summary>
        /// Get the UsbHostDevice Instance
        /// </summary>
        public UsbHostDevice Instance
        {
            get
            {
                if (_instance == null) _instance = new UsbHostDevice();
                return _instance;
            }
        }

        /// <summary>
        /// Protected constructor.
        /// </summary>
        protected UsbHostDevice()
        {
            UpdateCount = 0;
            RawIntegers = new Int32[20];
            RawFloats = new Single[6];
        }

        protected Int32[] RawIntegers { get; set; }
        protected Single[] RawFloats { get; set; }

        protected Int32 _UpdateCount = 0;
        protected Int32 UpdateCount
        {
            get { return _UpdateCount; }
            set { _UpdateCount = value; }
        }

        /// <summary>
        /// Protected method to set Usb mode.
        /// </summary>
        /// <param name="mode">UsbHostDeviceMode</param>
        protected static void SetUsbMode(UsbHostDeviceMode mode)
        { CTRE.Native.HDU.SetMode((uint)mode); }

        /// <summary>
        /// Protected method to get Usb mode.
        /// </summary>
        /// <returns>UsbHostDeviceMode</returns>
        protected static UsbHostDeviceMode GetUsbMode()
        { return (UsbHostDeviceMode)CTRE.Native.HDU.GetMode(); }

        /// <summary>
        /// Public property to get Usb mode.
        /// </summary>
        public UsbHostDeviceMode UsbMode
        {
            get { return UsbHostDevice.GetUsbMode(); }
            protected set { UsbHostDevice.SetUsbMode(value); }
        }

        public Int32 Get(ref GamepadValues value)
        {
            Int32 status = CTRE.Native.HDU.GetJoy(ref _UpdateCount,
                RawIntegers, (UInt32)RawIntegers.Length,
                RawFloats, (UInt32)RawFloats.Length);

            if (status < 0)
            {
                // Unreliable data. Zero values.
                value.Zero();
                // Get latest on next poll.
                UpdateCount = 0;
            }
            else if (status == 0) { /* No changes */}
            else
            {
                /* New data, update value */
                Array.Copy(RawFloats, value.Axes, value.Axes.Length);
                for (UInt16 bIdx = 0; bIdx < value.Buttons.Length; ++bIdx)
                    value.Buttons[bIdx] = (RawIntegers[0] >> bIdx & 1) == 1;
                value.Pov = Utilities.PovAngleToGamepadPov(RawIntegers[1]);

                value.VID = (UInt32)RawIntegers[6];
                value.PID = (UInt32)RawIntegers[7];
                value.VendorSpec.Integers = RawIntegers;
                value.VendorSpec.Floats = RawFloats;
            }

            return status;
        }

        public int Set()
        { throw new NotImplementedException(); }
    }
}
