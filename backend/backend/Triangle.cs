using System;
using System.Collections.Generic;
using System.Text;

namespace backend
{
    public  class Triangle: Rectangle
    {
        private double c;

        private double h;

        public Triangle(string name, double a, double b = 0, double c = 0, double h = 0)
            : base(name, a, b)
        {
            C = c;
            H = h;
        }

        public double C
        {
            get => c;
            set => c = ValidateC(value);
        }
        public double H
        {
            get => h;
            set => h = ValidateH(value);
        }

        public override double GetArea()
        {
            return (B * H) / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B); ;
        }
        private double ValidateC(double c)
        {
            if (c <= 0)
            {
                throw new ArgumentException($"The side length: {c} is not valid.");
            }
            return c;
        }
        private double ValidateH(double h)
        {
            if (h <= 0)
            {
                throw new ArgumentException($"The height: {h} is not valid.");
            }
            return h;
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
