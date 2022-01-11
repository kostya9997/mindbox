using System;

namespace Mindbox.GeometryFigures.Model
{
    public sealed class Circle : Figure
    {
        public readonly double Radius;
        public Circle(double radius)
        {
            if(radius <= 0) throw new ArgumentException("Неверный радиус");
            Radius = radius;
        }

        public override sealed double GetSquare() => Math.Round(2 * Math.PI * Math.Pow(Radius, 2), 2);
    }
}
