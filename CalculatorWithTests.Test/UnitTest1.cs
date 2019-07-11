using System;
using Xunit;

namespace Calculator.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(-3, 5, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, -5, -7)]
        [InlineData(400, 1000, 1400)]
        [InlineData(-5, 5, 0)]
        [InlineData(0, 1, 1)]
        public void AddTogether(int a, int b, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.AddTogether(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(3, 4, -1)]
        [InlineData(432, 31, 401)]
        [InlineData(-4, -30, -34)]
        [InlineData(3, 3, 0)]
        [InlineData(0, 3, -3)]
        [InlineData(3, 0, 3)]
        public void Subtract(int a, int b, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Subtract(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(30, 5, 150)]
        [InlineData(2, 2, 4)]
        [InlineData(1, 5, 5)]
        [InlineData(0, 5, 0)]
        [InlineData(-3, 5, -15)]
        [InlineData(-4, -5, 20)]
        [InlineData(-5, 0, 0)]
        public void Multiply(int a, int b, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Multiply(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(400, 50, 8)]
        [InlineData(5, 1, 5)]
        [InlineData(13, 13, 1)]
        [InlineData(-10, 5, -2)]
        [InlineData(-8, -2, 4)]
        [InlineData(40, 5, 8)]
        [InlineData(0, 5, 0)]
        public void Divide(int a, int b, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Divide(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(40, 3, 1)]
        [InlineData(52, 5, 2)]
        [InlineData(10, 5, 0)]
        [InlineData(500, 3, 2)]
        [InlineData(1, 1, 0)]
        [InlineData(5, 1, 0)]
        public void Factorial(int a, int b, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Factorial(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 100, 1)]
        [InlineData(4, 2, 16)]
        [InlineData(10, 3, 1000)]
        [InlineData(2, 4, 16)]
        [InlineData(13, 5, 371293)]
        [InlineData(3, 6, 729)]
        public void PowerOf(int a, int b, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.PowerOf(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
