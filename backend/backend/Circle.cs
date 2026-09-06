using System;
using System.Collections.Generic;
using System.Text;

namespace backend
{


    public class Circle : GeometricFigure
    {
        private double r;

        public double R
        {
            get => r;
            set => r = ValidateR(value);
        }

        public Circle(string name, double r)
        {
            Name = name;
            R = r;
        }

        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        private double ValidateR(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException($"The radius: {r} is not valid.");
            }
            return radius;
        }





    }
}
