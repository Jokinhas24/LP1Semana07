using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private float ray;
        private int timesthrown;
        public Sphere(Color color, float ray)
        {
            this.color = color;
            this.ray = ray;
            timesthrown = 0;
        }
        public float GetRay()
        {
            return ray;
        }
        public void Pop()
        {
            ray = 0;
        }
        public void Throw()
        {
            if (ray > 0)
            {
                timesthrown += 1;
            }
        }
        public int GetTimesThrown()
        {
            return timesthrown;
        }
    }
}