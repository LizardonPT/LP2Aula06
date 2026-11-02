using System;

namespace GunDecorations
{
    public class GunClip : GunDecorator
    {
        public GunClip(Gun gun) : base(gun)
        {
        }

        public override int AmmoCapacity => base.AmmoCapacity + 30;
    }
}