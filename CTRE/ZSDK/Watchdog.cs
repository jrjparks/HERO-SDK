using System;

namespace CTRE.ZSDK
{
    public static class Watchdog
    {
        /// <summary>
        /// Function bits
        /// </summary>
        public enum EnableBit
        {
            None = 0,
            Api = 1 << 0,
            Cc = 1 << 1,
            UsbGamepad = 1 << 2,
        }

        /// <summary>
        /// Check if Watchdog is enabled.
        /// </summary>
        public static Boolean IsEnabled
        { get { return GetEnableBits(EnableBit.None); } }

        /// <summary>
        /// Check if function is enabled.
        /// </summary>
        /// <param name="enableBits">Bits to check</param>
        /// <returns>Boolean</returns>
        public static Boolean GetEnableBits(EnableBit enableBit)
        {
            uint bits = (uint)enableBit;
            return CTRE.Native.Watchdog.GetEnableBits(ref bits) == 0;
        }

        /// <summary>
        /// Feed the watchdog.
        /// </summary>
        /// <param name="timeout">Timeout in MS for feed. Defaults to 100ms.</param>
        /// <returns></returns>
        public static Int32 Feed(UInt32 timeout = 100)
        { return CTRE.Native.Watchdog.Feed(timeout); }
    }
}
