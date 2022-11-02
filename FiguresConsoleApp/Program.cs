using FiguresClassLibrary;
using System;

namespace FiguresConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure fTriangle = new Triangle(3, 4, 5);
            Console.WriteLine("Площадь фигуры {0} равна {1}",
                fTriangle.ToString(), fTriangle.Square());

            Figure fTriangle1 = new Triangle(5, 6, 7);
            Console.WriteLine("Площадь фигуры {0} равна {1}",
                fTriangle1.ToString(), fTriangle1.Square());

            Figure fCircle = new Circle(1);
            Console.WriteLine("Площадь фигуры {0} равна {1}",
                fCircle.ToString(), fCircle.Square());

            Figure fRectangle = new Rectangle(4, 5);
            Console.WriteLine("Площадь фигуры {0} равна {1}",
                fRectangle.ToString(), fRectangle.Square());


            Console.ReadKey();
        }
    }
}
