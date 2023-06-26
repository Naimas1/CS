using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public abstract class Shape
    {
        public abstract double GetSquare();
    }

    public class Rectangle : Shape
    {
        public double LittleSide { get; set; }
        public double BigSide { get; set; }

        public Rectangle() 
        { 
            LittleSide = 0;
            BigSide = 0;
        }

        public Rectangle(double littleSide, double bigSide)
        {
            LittleSide = littleSide;
            BigSide = bigSide;
        }

        public override double GetSquare()
        {
            return LittleSide * BigSide;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        
        public Circle()
        {
            Radius = 0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetSquare()
        {
            return 3.14 * Math.Pow(Radius, 2);
        }
    }

    public class RectangularTriangle : Shape
    {
        public double Katet1 { get; set; }
        public double Katet2 { get; set; }
        
        public RectangularTriangle()
        {
            Katet1 = 0;
            Katet2 = 0;
        }

        public RectangularTriangle(double katet1, double katet2)
        {
            Katet1 = katet1;
            Katet2 = katet2;
        }

        public override double GetSquare()
        {
            return 0.5 * Katet1 * Katet2;
        }
    }

    public class Trapezium : Shape
    {
        public double LittleBasis { get; set; }
        public double BigBasis { get; set; }
        public double Height { get; set; }

        public Trapezium(double littleBasis, double bigBasis, double height)
        {
            LittleBasis = littleBasis;
            BigBasis = bigBasis;
            Height = height;
        }
        public Trapezium()
        {
            Height = 0;
            LittleBasis = 0;
            BigBasis= 0;

        }

        public override double GetSquare()
        {
            return (LittleBasis + BigBasis) / 2 * Height;
        }
    }
}
