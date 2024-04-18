using System.Runtime.CompilerServices;

namespace GameUnits
{
    public class Unit
    {
        private int movement;
        public virtual int Health { get; set; }
        public float Cost  { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
        public void Move()
        {
            Console.WriteLine("", movement);
        }
    }
}
