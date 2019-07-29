using System;

namespace GitSecondProject
{
    public class Missle : Weapon
    {
        public Missle()
        {
            DamagePower = 250;
        }
        public override void Fire()
        {
            Console.WriteLine($"Missle was fired with {DamagePower} damagePower");
        }
    }
}
