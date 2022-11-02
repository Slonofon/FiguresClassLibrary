using System;

namespace FiguresClassLibrary
{
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException();

            Radius = radius;
        }

        public double Radius { get; private set; }

        public override double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return String.Format("Круг с радиусом {0}", Radius);
        }
    }
}

