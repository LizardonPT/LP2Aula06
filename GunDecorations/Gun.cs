using System;

namespace GunDecorations
{
    public abstract class Gun
    {
        public abstract int AmmoCapacity { get; }
        public abstract float NoiseLevel { get; }

        public void Fire()
        {
            Console.WriteLine($"Firing the gun with noise level: {NoiseLevel:f2}");
            Console.WriteLine($"Ammo capacity remaining: {AmmoCapacity}");
        }
    }
}