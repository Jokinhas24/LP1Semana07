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
        private readonly int level;
        public Cell (string name)
        {
            this.name = name;
            charge = 200;
        }
        public void Charge(float value)
        {
            if ((charge += value) > 200)
            {
                charge = 200;
            }
            else
            {
                charge += value;
            }
        }

    }
}