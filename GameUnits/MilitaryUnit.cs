using System.ComponentModel.Design.Serialization;
using System.Xml.XPath;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit // Heranca!!
    {
        public int AttackPower { get; }
        public override int Health { 
            get
            {
                return base.Health + XP;
            }
            set
            {
                base.Health = value;
            }
            }
        public override float Cost 
        {
            get
            {
                return AttackPower + XP;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $" AP={AttackPower}";
        }
        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
        }

        public void Attack(Unit u)
        {
            XP += 1;
            u.Health -= AttackPower;
        }
    }
}
