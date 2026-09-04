using System;
using System.Collections.Generic;
using System.Text;

namespace backend
{
    public class Trapeze : Triangle
    {
        private double d;

        public Trapeze(string name, double a, double b = 0, double c = 0, double h = 0, double d = 0) 
            : base(name, a, b, c, h)
        {
            D = d;
        }

        public double D
        {
            get => d;
            set => d = ValidateD(value);
        }

        public override double GetArea()
        {
            return ((B + D) * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }

        private double ValidateD(double d)
        {
            if (d <= 0)
            {
                throw new ArgumentException($"The side length: {d} is not valid.");
            }
            return d;
        }




    }


}
