using System;

namespace GunDecorations
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Gun shotgun = new ShotGun();
            Console.WriteLine("=== Shotgun without decorations ===");
            shotgun.Fire();
            Console.WriteLine();

            Gun shotgunWithClip = new GunClip(shotgun);
            Console.WriteLine("\n=== Shotgun with clip decoration ===");
            shotgunWithClip.Fire();
            Console.WriteLine();

            Gun shotgunWithSilencer = new GunSilencer(shotgun);
            Console.WriteLine("\n=== Shotgun with silencer decoration ===");
            shotgunWithSilencer.Fire();
            Console.WriteLine();

            Gun machineGun = new MachineGun();
            Console.WriteLine("\n=== Machine Gun without decorations ===");
            machineGun.Fire();
            Console.WriteLine();

            Gun machineGunWithClip = new GunClip(machineGun);
            Console.WriteLine("\n=== Machine Gun with clip decoration ===");
            machineGunWithClip.Fire();
            Console.WriteLine();

            Gun machineGunWithClipAndSilencer = new GunSilencer(machineGunWithClip);
            Console.WriteLine("\n=== Machine Gun with clip and silencer decorations ===");
            machineGunWithClipAndSilencer.Fire();
            Console.WriteLine();
        }
    }
}
