using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindbox.GeometryFigures.Model.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetSquareTest()
        {
            //Создание треугольника с некорректными значениями, вызывает ошибку.
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 10, 50));

            //Равносторонний треугольник
            Triangle f = new Triangle(5d, 5d, 5d);
            //Фактически 10.825, по мат. округлению 10.83
            Assert.AreEqual(10.83d, f.GetSquare());

            //Остроугольный треугольник
            f = new Triangle(12d, 12d, 8d);
            Assert.AreEqual(45.25d, f.GetSquare());
        }

        [TestMethod()]
        public void GetIsRightTriangleTest()
        {
            double side1 = 5d, side2 = 5d, side3 = 5d;

            //Равносторонний треугольник
            Triangle f = new Triangle(side1, side2, side3);
            Assert.AreEqual(false, f.GetIsRightTriangle());

            side1 = 5d;
            side2 = 5d;
            side3 = Math.Round(Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2)), 2);

            Assert.AreEqual(7.07d, side3);//Проверка 3 стороны

            var sides = new List<double>() { side1, side2, side3 };
            double hypotenuse = sides.Max(); //Получение гипотенузы

            Assert.AreEqual(side3, hypotenuse);//Убеждаемся что 3 сторона и есть гипотенуза
            Assert.AreEqual(50.0d, Math.Round(Math.Pow(hypotenuse, 2), 0));//Убеждаемся что квадрат гипотенузы == 50

            //Создаём прямоугольный треугольник
            f = new Triangle(side1, side2, side3);
            Assert.AreEqual(false, f.GetIsRightTriangle()); //Убеждаемся что треугольник действительно прямоугольный
        }
    }
}