using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color red = new Color (255, 0, 0);

            Sphere redsphere = new Sphere (red, 5);

            redsphere.Pop();

            Console.WriteLine(redsphere.GetRay());
        }
    }
}
