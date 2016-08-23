using System;

namespace CTRE.ZSDK.HID
{
    public class VendorSpec : ICloneable
    {
        public Int32[] Integers { get; internal set; }
        public Single[] Floats { get; internal set; }

        public VendorSpec()
        {
            Integers = null;
            Floats = null;
        }
        public VendorSpec(VendorSpec spec)
        {
            Array.Copy(spec.Integers, Integers, spec.Integers.Length);
            Array.Copy(spec.Floats, Floats, spec.Floats.Length);
        }
        
        internal void Zero()
        {
            Integers = null;
            Floats = null;
        }

        public VendorSpec Clone()
        { return new VendorSpec(this); }

        object ICloneable.Clone()
        { return Clone(); }
    }
}
