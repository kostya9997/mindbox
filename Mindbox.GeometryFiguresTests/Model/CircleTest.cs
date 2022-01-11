using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox.GeometryFigures.Model;
using System;

namespace Mindbox.GeometryFiguresTests.Model
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void GetSquareTest()
        {
            double radius = -1;

            Circle circle;

            //Проверка, действительно ли будет ошибка при некорректном радиусе.
            Assert.ThrowsException<ArgumentException>(() => circle = new Circle(radius));

            radius = 2; //Целочисленный радиус
            circle = new Circle(radius);
            //Фактически 25.128, по мат. округлению 25.13
            Assert.AreEqual(25.13, circle.GetSquare());

            radius = 4.894d; //Радиус с плавающей точкой
            circle = new Circle(radius);
            Assert.AreEqual(150.49, circle.GetSquare());
        }
    }
}