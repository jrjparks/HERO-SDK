using System;

namespace CTRE.ZSDK.HID
{
    public enum GamepadPov
    {
        None = 0,
        Up = 1 << 0,
        Right = 1 << 1,
        Down = 1 << 2,
        Left = 1 << 3
    }

    public class GamepadValues : ICloneable
    {
        public Single[] Axes { get; internal set; }
        public Boolean[] Buttons { get; internal set; }
        public GamepadPov Pov { get; internal set; }

        public UInt32 VID { get; internal set; }
        public UInt32 PID { get; internal set; }
        public VendorSpec VendorSpec { get; internal set; }

        public GamepadValues()
        {
            Axes = new Single[6];
            Buttons = new Boolean[32];
            Pov = GamepadPov.None;

            VID = 0;
            PID = 0;
            VendorSpec = new VendorSpec();
        }

        public GamepadValues(GamepadValues value)
        {
            Array.Copy(value.Axes, Axes, Axes.Length);
            Array.Copy(value.Buttons, Buttons, Buttons.Length);
            Pov = value.Pov;

            VID = value.VID;
            PID = value.PID;
            VendorSpec = value.VendorSpec.Clone();
        }

        internal static readonly Single[] ZeroAxes = new Single[6];
        internal static readonly Boolean[] ZeroButtons = new Boolean[32];
        internal void Zero()
        {
            Array.Copy(Axes, ZeroAxes, ZeroAxes.Length);
            Array.Copy(Buttons, ZeroButtons, ZeroButtons.Length);
            Pov = 0;

            VID = 0;
            PID = 0;
            VendorSpec.Zero();
        }

        public GamepadValues Clone()
        { return new GamepadValues(this); }

        object ICloneable.Clone()
        { return Clone(); }
    }
}
