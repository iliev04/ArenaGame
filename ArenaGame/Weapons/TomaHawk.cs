using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class TomaHawk : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }
        private Random random = new Random();
        public TomaHawk(string name) 
        {
            Name = name;
            AttackDamage = 22;
            BlockingPower = 10;
        }
        public double Throw()
        {
            double probability = random.NextDouble();
            if (probability < 0.2)
            {
                return 17;
            }
            else return 5;
        }
    }
}