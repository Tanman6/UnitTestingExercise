using System;
using UnitTestingExercise;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void Subtract(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1,num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1,num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Greet()
        {
            //Arrange
            var expected = new UnitTestMethods();
            //Act
            string actual = expected.Greet();
            //Assert
            Assert.Equal("Hello", actual);
        }

        [Fact]
        public void Goodbye()
        {
            //Arrange
            var expected = new UnitTestMethods();
            //Act
            var actual = expected.Goodbye();
            //Assert
            Assert.Equal("Goodbye", actual);
        }
    }
}
