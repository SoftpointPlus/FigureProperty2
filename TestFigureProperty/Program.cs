using FigureProperty2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFigureProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            figures.Add(new Trangle(10, 20, 10));
            figures.Add(new Trangle(1, 20, 10));
            figures.Add(new Circle(10));
            figures.Add(new Circle(5));
            figures.Add(new Rectangle(10, 20));

            Console.WriteLine("{0, 20} {1, 20} {2, 20}", "Фигура", "Площадь", "Периметр\n");
            foreach (var item in figures)
            {
                Console.WriteLine("{0, 20} {1, 20} {2, 20}", item.Name() ,item.Area() ,item.Perimeter());
            }
            
            Console.ReadLine();
        }
    }
}
