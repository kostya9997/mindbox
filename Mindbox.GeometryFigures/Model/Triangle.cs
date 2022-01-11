using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindbox.GeometryFigures.Model
{
    public sealed class Triangle : Figure
    {
        public readonly double Side1;
        public readonly double Side2;
        public readonly double Side3;
        
        public Triangle(double side1, double side2, double side3)
        {
            if (!(side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2))
                throw new ArgumentException("Неверно заданы стороны треугольника");

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override sealed double GetSquare()
        {
            //Полупериметр
            double p = (Side1 + Side2 + Side3) / 2d;
            //Формула площади треугольника
            return Math.Round(Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3)), 2);
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool GetIsRightTriangle()
        {
            List<double> sides = new List<double>() { Side1, Side2, Side3 };
            double hypotenuse = sides.Max(); //Максимально длинная сторона (гипотенуза)

            //Если не 1 сторона равна максимальной, значит остроугольный, либо равносторонний
            if (sides.Count(x => x == hypotenuse) != 1) return false;
            
            //Возврат, равен ли квадрат гипотенузы суммам квадратов катетов
            return Math.Round(Math.Pow(hypotenuse, 2), 2).Equals(Math.Round(sides.Where(x => x != hypotenuse).Select(z => Math.Pow(z, 2)).Sum(), 2));
        }
    }
}
