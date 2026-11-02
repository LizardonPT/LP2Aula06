using System;

namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {
        public GunSilencer(Gun gun) : base(gun)
        {
        }
        
        public override float NoiseLevel => base.NoiseLevel * 0.5f;
    }
}