using System;

namespace CTRE.ZSDK.HID
{
    public class Gamepad
    {
        protected IGamepadProvider Provider { get; set; }
        public GamepadValues _Values = new GamepadValues();
        /// <summary>
        /// Returns the Gamepad values
        /// </summary>
        public GamepadValues Values
        {
            get { return _Values; }
            protected set { _Values = value; }
        }

        /// <summary>
        /// Returns connection status.
        /// </summary>
        public Boolean IsConnected
        { get { return Provider.Get(ref _Values) >= 0; } }

        /// <summary>
        /// Access a Gamepad.
        /// </summary>
        /// <param name="Provider">The provider for accessing the connected Gamepad.</param>
        public Gamepad(IGamepadProvider Provider)
        { this.Provider = Provider; }

        /// <summary>
        /// Returns the Axes.
        /// </summary>
        public Single[] Axes
        { get { Provider.Get(ref _Values); return Values.Axes; } }

        /// <summary>
        /// Returns the Buttons.
        /// </summary>
        public Boolean[] Buttons
        { get { Provider.Get(ref _Values); return Values.Buttons; } }

        /// <summary>
        /// Returns the POV hat.
        /// </summary>
        public GamepadPov Pov
        { get { Provider.Get(ref _Values); return Values.Pov; } }
    }
}
