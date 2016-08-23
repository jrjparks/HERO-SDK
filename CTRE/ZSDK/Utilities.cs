using System;

namespace CTRE.ZSDK
{
    public static class Utilities
    {
        /// <summary>
        /// Deadband a Single(float) value to 0.
        /// </summary>
        /// <param name="value">Value to deadband.</param>
        /// <param name="min">Minimum value to pass deadband.</param>
        /// <returns>Value or 0</returns>
        public static Single Deadband(this Single value, Single min)
        { return System.Math.Abs(value) >= System.Math.Abs(min) ? value : 0.0f; }

        public static readonly GamepadPov[] PovAngleToGamepadPovArray = {
            GamepadPov.Up,
            GamepadPov.Up | GamepadPov.Right,
            GamepadPov.Right,
            GamepadPov.Right | GamepadPov.Down,
            GamepadPov.Down,
            GamepadPov.Down | GamepadPov.Left,
            GamepadPov.Left,
            GamepadPov.Left | GamepadPov.Up
        };
        public static GamepadPov PovAngleToGamepadPov(Int32 PovAngle)
        {
            if (PovAngle < 0) return GamepadPov.None;
            Int32 idx = (Int32)System.Math.Round(PovAngle / 45f);
            return PovAngleToGamepadPovArray[idx];
        }
    }
}
