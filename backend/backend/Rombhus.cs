using System;
using System.Collections.Generic;
using System.Text;

namespace backend
{
    public class Rombhus : Square
    {
        private double d1;
        private double d2;

        public Rombhus(string name, double a, double d1, double d2)
            : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        public double D1
        {
            get => d1;
            set => d1 = ValidateD1(value);
        }


        public double D2
        {
            get => d2;
            set => d2 = ValidateD2(value);
        }
        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }
        private double ValidateD1(double d1)
        {
            if (d1 <= 0)
            {
                throw new ArgumentException($"The diagonal: {d1} is not valid.");
            }
            return d1;
        
        }
        private double ValidateD2(double d2)
        {
            if (d2 <= 0)
            {
                throw new ArgumentException($"The diagonal: {d2} is not valid.");
            }
            return d2;

        }








        }
} 

