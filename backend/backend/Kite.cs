using System;
using System.Collections.Generic;
using System.Text;

namespace backend
{
    public class Kite : Rombhus
    {
        private double b;

        public Kite(string name, double a, double d1, double d2, double b = 0) : base(name, a, d1, d2)
        {
            B = b;
        }

        public double B
        {
            get { return b; }
            set { b = ValidateB(value); }
        }

        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }

        private double ValidateB(double b)
        {
            if (b <= 0)
            {
                throw new ArgumentException("Side B must be greater than zero.");
            }
            return b;
        }
    }
        
}
