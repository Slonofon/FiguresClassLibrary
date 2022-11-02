using FiguresClassLibrary;
using System;

namespace FiguresConsoleApp
{
    // Класс наследуемый от класса библиотеки из внешнего проекта
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

        // Реализация родительского абстрактного метода
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
