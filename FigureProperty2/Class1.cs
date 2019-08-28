using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProperty2
{
    public abstract class Figure
    {
        public abstract string Area();
        public abstract string Perimeter();
        public virtual string Name() { return "abstract figure"; }
    }
    public class Trangle : Figure
    {
        private readonly double SizeA;
        private readonly double SizeB;
        private readonly double SizeC;
        public Trangle(double triangleSizeA, double triangleSizeB, double triangleSizeC)
        {
            SizeA = triangleSizeA <= 0 ? -triangleSizeA : triangleSizeA;
            SizeB = triangleSizeB <= 0 ? -triangleSizeB : triangleSizeB;
            SizeC = triangleSizeC <= 0 ? -triangleSizeC : triangleSizeC;
        }

        public override string Name()
        {
            return "Trangle";
        }
        private bool CheckValid()
        {
            return !((SizeA > SizeB + SizeC) || (SizeB > SizeA + SizeC) || (SizeC > SizeA + SizeB));
        }
        public override string Area()
        {
            if (!CheckValid())
                return "не существует";

            double p = (SizeA + SizeB + SizeC) / 2;
            return (Math.Sqrt(p * (p - SizeA) * (p - SizeB) * (p - SizeC))).ToString();
        }

        public override string Perimeter()
        {
            if (!CheckValid())
                return "не существует";
            return (SizeA + SizeB + SizeC).ToString();
        }
    }
    public class Circle : Figure
    {
        private readonly double Radius;
        public Circle(double radius)
        {
            Radius = radius <= 0 ? -radius : radius;
        }
        public override string Name()
        {
            return "Circle";
        }
        public override string Area()
        {
            return (Math.PI * Radius * Radius).ToString();

        }

        public override string Perimeter()
        {
            return (2 * Math.PI * Radius).ToString();
        }

    }
    public class Rectangle : Figure
    {
        private double Width;
        private double Height;
        public Rectangle(double width, double height)
        {
            Width = width < 0 ? -width : width;
            Height = height < 0 ? -height : height;
        }

        public override string Area()
        {
            return (Width * Height).ToString();
        }

        public override string Perimeter()
        {
            return (2 * Width + 2 * Height).ToString();
        }

        public override string Name()
        {
            return "Rectangle";
        }





    }
}
