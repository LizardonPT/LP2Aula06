using System;

namespace GunDecorations
{
    public abstract class GunDecorator : Gun
    {
        private readonly Gun _decoratedGun;
        public GunDecorator(Gun gun)
        {
            _decoratedGun = gun;
        }

        public override int AmmoCapacity => _decoratedGun.AmmoCapacity;

        public override float NoiseLevel => _decoratedGun.NoiseLevel;
    }
}