using System;
using System.Collections.Generic;
using System.Text;

namespace backend
{
    public  class Parallelogram: Rectangle
    {
        private double h;

        public Parallelogram(string name, double a, double b = 0, double h = 0) : base(name, a, b)
        {
            H = h;
        }

        public double H
        {
            get => h;
            set => h = ValidateH(value);
        }

        public override double GetArea()
        {
            return B * H;
        }
         public override double GetPerimeter()
        {
            return 2 * (A + B);
        }

        private double ValidateH(double h)
        {
            if (h <= 0)
            {
                throw new ArgumentException($"The height: {h} is not valid.");
            }
            return h;
        }
    }

}
