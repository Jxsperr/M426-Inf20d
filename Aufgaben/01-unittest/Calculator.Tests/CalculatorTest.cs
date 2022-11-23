using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddTenToSixtyIs70()
        {
            // Arrange
            double a = 10;
            double b = 60;
            double expected = 70;
            Calculator calculator = new Calculator();

            // When
            double actual = calculator.Add(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractTwoFromEightIsSix()
        {
            // Given
            double a = 8;
            double b = 2;
            double expected = 6;
            Calculator calculator = new Calculator();

            // When
            double actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplySevenAndNineIsSeventySeven()
        {
            // Given
            double a = 7;
            double b = 11;
            double expected = 77;
            Calculator calculator = new Calculator();

            // When
            double actual = calculator.Multiply(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideOneHundretByTwoIsFifty()
        {
            // Given
            double a = 100;
            double b = 2;
            double expected = 50;
            Calculator calculator = new Calculator();

            // When
            double actual = calculator.Divide(a, b);

            // Then
            Assert.Equal(expected, actual);
        }
    }
}
