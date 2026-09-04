using System;
using System.Collections.Generic;
using System.Text;

namespace backend
{
    
    
        public class Square : GeometricFigure
        {
            private double a; 

            public Square(string name, double a)
            {
                Name = name;
                A= a; 
            }

            public double A
            {
                get => a;
                set => a = ValidateA(value);
            }

            public override double GetArea()
            {
                return A * A;
            }

            public override double GetPerimeter()
            {
                return 4 * A;
            }

            private double ValidateA(double a)
            {
                if (a <= 0)
                {
                    throw new ArgumentException($"The side length: {a} is not valid.");
                }
                return a;
            }
        }
    }


