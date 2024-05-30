using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Wizard : Hero
    {
        private double magicCurse;
        private double shieldBubble;
        public Wizard(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon) 
        {
            magicCurse = 0.5;
            shieldBubble = 0.1;
        }
        public override double Attack()
        {
            double damage = base.Attack();
            double realDamage = damage * magicCurse;
            if(Weapon is MagicWand magicwand)
            {
                realDamage = realDamage + magicwand.ThrowFireBall();
            }
            return realDamage;
        }
        public override double Defend(double damage)
        {
            if(shieldBubble > 1)
            {
                shieldBubble = 0.1;
                return 0;
            }
            shieldBubble += 0.1;
            return base.Defend(damage);
        }
    }
}