using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Тестирование сложения
        /// </summary>
        [TestCase(5, 5, 10)]
        [TestCase(0, 5, 5)]
        [TestCase(5, 0, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, 5, 0)]
        [TestCase(5, -5, 0)]
        [TestCase(-5, -5, -10)]
        public void AdditionalMustReturnExpectedValue(int num1, int num2, int expected)
        {
            var calculator = new Calculator();

            Assert.That(calculator.Additional(num1, num2), Is.EqualTo(expected));
        }

        /// <summary>
        /// Тестирование вычитания
        /// </summary>
        [TestCase(5, 5, 0)]
        [TestCase(0, 5, -5)]
        [TestCase(0, -5, 5)]
        [TestCase(5, 0, 5)]
        [TestCase(-5, 0, -5)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, 5, -10)]
        [TestCase(5, -5, 10)]
        [TestCase(-5, -5, 0)]
        public void SubtractionMustReturnExpectedValue(int num1, int num2, int expected)
        {
            var calculator = new Calculator();

            Assert.That(calculator.Subtraction(num1, num2), Is.EqualTo(expected));
        }

        /// <summary>
        /// Тестирование умножения
        /// </summary>
        [TestCase(5, 5, 25)]
        [TestCase(0, 5, 0)]
        [TestCase(5, 0, 0)]
        [TestCase(5, 1, 5)]
        [TestCase(1, 5, 5)]
        public void MiltiplicationMustReturnExpectedValue(int num1, int num2, int expected)
        {
            var calculator = new Calculator();

            Assert.That(calculator.Miltiplication(num1, num2), Is.EqualTo(expected));
        }

        /// <summary>
        /// Тестирование деления, если делитель не равен 0
        /// </summary>
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 1)]
        [TestCase(0, 2, 0)]
        public void DivisionMustReturnExpectedValueIfDividerIsNotZeroAndExpectedValueIsInteger(int num1, int num2, double expected)
        {
            var calculator = new Calculator();

            Assert.That(calculator.Division(num1, num2), Is.EqualTo(expected));
        }

        /// <summary>
        /// Тестирование деления, если результирующее число - дробное
        /// </summary>
        [TestCase(1, 2, 0.5)]
        public void DivisionMustReturnIntegerValueIfExpectedValueIsFloat(int num1, int num2, double expected)
        {
            var calculator = new Calculator();

            Assert.False(calculator.Division(num1, num2) == expected);
        }

        /// <summary>
        /// Тестирование деления, если делитель равен 0
        /// </summary>
        [Test]
        public void DivisionMustThrowExceptionIfDividerIsZero()
        {
            var calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(5, 0));
        }
    }
}