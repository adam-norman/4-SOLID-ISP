using System;

namespace ISP
{
    public class Cube : I3DShap
    {

        private double _height;
         
        public Cube(double height,double depth)
        {
            _height = height;
        }
        public void CalculateArea()
        {
            Console.WriteLine($"The cube Area={6 * Math.Pow(_height, 2)}");
        }

        public void CalculateVolume()
        {
            Console.WriteLine($"The cube voulume={Math.Pow(_height, 3)}");
        }
    }


}

