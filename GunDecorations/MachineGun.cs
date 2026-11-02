using System;

namespace GunDecorations
{
    public class MachineGun : Gun
    {
        public override int AmmoCapacity => 100;

        public override float NoiseLevel => 80.0f;
    }
}