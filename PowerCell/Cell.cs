using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerCell
{
    public class Cell
    {
        private readonly string name;
        private float charge;
        private readonly int level;
        public string Name {get;}
        public float Charge
        {
            get;
            set
            {
                charge = value;
                if (charge > 200) {charge = 200;}
                if (charge < 0) {charge = 0;}
            }
        }
        public int Level {get;}
        public Cell (string name)
        {
            this.name = name;
            charge = 200;
            level = 1 + (int.Parse(charge)/40);
        }
        public void Consume(float amount)
        {
            if ((charge -= amount) < 0)
            {
                charge = 0;
            }
            else
            {
                charge -= amount;
            }
        }
        public void Restore()
        {
                charge = 200;
        }

    }
}