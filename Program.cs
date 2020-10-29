using System;
using System.Collections.Generic;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShap> shaps = new List<IShap>();
            shaps.Add(new Squar(3));
            shaps.Add(new Cube(3,3));

            foreach (var shap in shaps)
            {
                shap.CalculateArea();
            }

            Cube cube = new Cube(3, 3);
            cube.CalculateArea();
            cube.CalculateVolume();

            Console.ReadLine();
        }
    }
}
