using FiguresClassLibrary;
using System;

namespace FiguresConsoleApp
{
    internal class Rectangle : Figure
    {
        public double AB { get; private set; }

        public double BC { get; private set; }

        public Rectangle(double ab, double bc)
        {
            if ((ab <= 0) || (bc <= 0))
                throw new ArgumentException();

            AB = ab;
            BC = bc;
        }

        public override double Square()
        {
            return AB * BC;
        }

        public override string ToString()
        {
            return String.Format("Прямоугольник со сторонами {0}, {1}",
                AB, BC);
        }
    }
}
