﻿namespace Geometry
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public Circle(string name, double r) 
        {
            Name = name;
            R = r;
        }

        public double R { get => _r; set => _r = ValidateR(value); }

        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        private double ValidateR(double r)
        {
            if(r <= 0)
            {
                throw new Exception($"The radius: {r}, is not valid.");
            }
            return r;
        }
    }
}
