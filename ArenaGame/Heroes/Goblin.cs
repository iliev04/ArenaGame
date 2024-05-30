using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Goblin : Hero
    {
        private double hitRate;
        public Goblin(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon) 
        {
            hitRate = 0.1;
        }
        public override double Attack()
        {
            double damage = base.Attack();
            double realDamage = damage;
            if (hitRate > 1)
            {
                realDamage = damage * 0.6;
                hitRate = 0.1;
            }
            hitRate += 0.3;
            if (Weapon is Bow bow)
            {
                realDamage = realDamage + bow.GetFireArrow();
            }
            if(Weapon is TomaHawk tomahawk)
            {
                realDamage = realDamage + tomahawk.Throw();
            }
            return realDamage;
        }
    }
}