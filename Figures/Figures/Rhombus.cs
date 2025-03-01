﻿namespace Geometry
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;
        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        public double D1 { get => _d1; set => _d1 = ValidateD1(value); }
        public double D2 { get => _d2; set => _d2 = ValidateD2(value); }

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
            if(d1 <= 0)
            {
                throw new Exception($"The diagonal 1: {d1}, is not valid.");
            }
            return d1;
        }

        private double ValidateD2(double d2)
        {
            if(d2 <= 0)
            {
                throw new Exception($"The diagonal 2: {d2}, is not valid.");
            }
            return d2;
        }
    }
}
