using System;

namespace GitSecondProject
{
    public class MachineGun : Weapon
    {
        public MachineGun()
        {
            DamagePower = 200;
        }
        public override void Fire()
        {
            Console.WriteLine($"MachineGun was fired with {DamagePower} damagePower");
        }
    }
}
