using FiguresClassLibrary;
using System;

namespace FiguresConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример использования классов библиотеки
            Figure fTriangleRight = new Triangle(3, 4, 5);
            WriteResults(fTriangleRight.ToString(), fTriangleRight.Square());

            Figure fTriangleNotRight = new Triangle(5, 6, 7);
            WriteResults(fTriangleNotRight.ToString(), fTriangleNotRight.Square());

            Figure fCircle = new Circle(1);
            WriteResults(fCircle.ToString(), fCircle.Square());

            // Пример использования "внутреннего" класса наследуемого от класса библиотеки
            Figure fRectangle = new Rectangle(4, 5);
            WriteResults(fRectangle.ToString(), fRectangle.Square());

            Console.ReadKey();
        }

        private static void WriteResults(string sFigure, double dSquare) 
        {
            Console.WriteLine("Площадь фигуры '{0}' равна {1}", sFigure, dSquare);
        }
    }
}
