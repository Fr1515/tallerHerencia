using System;
using System.Collections.Generic;
using System.Text;

namespace backend
{
    public class Rectangle : Square
    {
        private double b;

        public Rectangle(string name, double a, double b = 0)
            : base(name, a)
        {
            B = b;
        }

        public double B
        {
            get => b;
            set => b = ValidateB(value);

        }
        public override double GetArea()
        {
            return A * B;
        }
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
        private double ValidateB(double b)
        {
            if (b <= 0)
            {
                throw new ArgumentException($"The side length: {b} is not valid.");
            }
            return b;
        }
    }
}
