using System;
using System.Runtime.CompilerServices;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }
        public abstract float Cost  { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
        public void Move()
        {
            Console.WriteLine($"This unit moved {movement} tiles.");
        }
    }
}