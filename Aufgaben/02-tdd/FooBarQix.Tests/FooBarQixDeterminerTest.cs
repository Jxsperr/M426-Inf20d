using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void TestDetermineFoo()
        {
            // Arrange
            int a = 6;
            string expected = "Foo";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            // Act
            string actual = fooBarQixDeterminer.Determine(a);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDetermineBar()
        {
            // Arrange
            int a = 10;
            string expected = "Bar";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            // Act
            string actual = fooBarQixDeterminer.Determine(a);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDetermineQix()
        {
            // Arrange
            int a = 7;
            string expected = "Qix";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            // Act
            string actual = fooBarQixDeterminer.Determine(a);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDetermineFooBarQix()
        {
            // Arrange
            int a = 210;
            string expected = "FooBarQix";
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            // Act
            string actual = fooBarQixDeterminer.Determine(a);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}