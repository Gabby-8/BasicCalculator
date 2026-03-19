using BasicCalculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Tests
{
    public class CalculatorServiceTest
    {
        private readonly CalculatorService service;

        public CalculatorServiceTest()
        {
            service = new CalculatorService();
        }

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            //Arrange
            double x = 5;
            double y = 3;

            //Act
            var result = service.Add(x, y);

            //Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            //Arrange
            double x = 5;
            double y = 3;

            //Act
            var result = service.Subtract(x, y);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            //Arrange
            double x = 5;
            double y = 3;

            //Act
            var result = service.Multiply(x, y);

            //Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            //Arrange
            double x = 15;
            double y = 3;

            //Act
            var result = service.Divide(x, y);

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_CannotBeDividedByZero()
        {
            // Arrange
            double x = 15;
            double y = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => service.Divide(x, y));
        }
    }
}
