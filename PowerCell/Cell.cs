using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerCell
{
    public class Cell
    {
        private float charge;
        private readonly string name;
        public string Name {get; set;}
        private readonly int level;
        public int Level
        {
            get
            {
                return level;
            }
            private set
            {
                1 + (int.Parse(charge)/40);
            }
        }
        public Cell (string name)
        {
            this.name = name;
            charge = 200;
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