using System;
using System.Runtime.CompilerServices;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit Sniper = new MilitaryUnit(2, 2, 10);
            Sniper.Move();
            Console.WriteLine($"Sniper has {Sniper.Health} and costs {Sniper.Cost} gold.");

            Unit Construct = new SettlerUnit();
            Construct.Move();
            Console.WriteLine($"Construct has {Construct.Health} and costs {Construct.Cost} gold.");
        }
    }
}
