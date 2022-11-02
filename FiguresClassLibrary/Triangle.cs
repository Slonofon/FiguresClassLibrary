using System;

namespace FiguresClassLibrary
{
    public class Triangle : Figure
    {
        public double AB { get; private set; }

        public double BC { get; private set; }

        public double CA { get; private set; }

        public bool IsRight
        {
            get
            {
                return (
                    Math.Pow(AB, 2) == (Math.Pow(BC, 2) + Math.Pow(CA, 2)) ||
                    Math.Pow(BC, 2) == (Math.Pow(CA, 2) + Math.Pow(AB, 2)) ||
                    Math.Pow(CA, 2) == (Math.Pow(AB, 2) + Math.Pow(BC, 2)));
            }
        }

        public Triangle(double ab, double bc, double ca)
        {
            if ((ab <= 0) || (bc <= 0) || (ca <= 0))
                throw new ArgumentException();

            AB = ab;
            BC = bc;
            CA = ca;
        }

        private double GetPerimeter()
        {
            return AB + BC + CA;
        }

        public override double Square()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - AB) * (halfPerimeter - BC) * (halfPerimeter - CA));
        }

        public override string ToString()
        {
            var triangleType = (IsRight) ? "Равнобедренный" : "Неравнобедренный";
            return String.Format("{0} треугольник со сторонами {1}, {2}, {3}",
                triangleType, AB, BC, CA);
        }
    }
}

