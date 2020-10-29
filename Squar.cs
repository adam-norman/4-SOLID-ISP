using System;

namespace ISP
{
    public class Squar : IShap
    {

        private double _height;
        public Squar(double height)
        {
            _height = height;
        }
        
        public void CalculateArea()
        {
            Console.WriteLine($"The squar Area= {Math.Pow(_height, 2)}");
        }
    }
}
