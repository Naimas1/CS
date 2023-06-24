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

        //конструктори

        public override double GetSquare()
        {
            return LittleSide * BigSide;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        //конструктори

        public override double GetSquare()
        {
            // пі * радіус квадрат
        }
    }

    public class RectangularTriangle : Shape
    {
        //конструктори

        // поля класу: катет1 катет2
        // GetSquare: 0.5 * катет1 * катет2
    }

    public class Trapezium : Shape
    {
        //конструктори

        // поля класу: менша основа, більша основа, висота
        // GetSquare: (менша основа + більша основа) / 2 * висоту
    }
}
