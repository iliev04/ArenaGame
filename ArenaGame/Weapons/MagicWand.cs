using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class MagicWand : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }
        private Random random = new Random();
        public MagicWand(string name) 
        {
            Name = name;
            AttackDamage = 15;
            BlockingPower = 15;
        }
        public double ThrowFireBall()
        {
            double probability = random.NextDouble();
            if (probability < 0.3)
            {
                return 20;
            }
            else return 12;
        }
    }
}