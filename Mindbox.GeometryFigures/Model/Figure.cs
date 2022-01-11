using System;

namespace Mindbox.GeometryFigures.Model
{
    public abstract class Figure
    {
        /// <summary>
        /// Расчитывает и возвращает площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double GetSquare();

        /// <summary>
        /// Вычисление площади фигуры без знания типа фигуры в compile-time,
        /// благодаря абстрактной реализации метода GetSquare.
        /// Надеюсь, правильно понял данный пункт.
        /// </summary>
        /// <param name="f">Неизвестная фигура</param>
        /// <returns>Площадь неизвестной фигуры</returns>
        public static double GetSquare(Figure f) =>
            f?.GetSquare() ?? throw new NullReferenceException();
    }
}
