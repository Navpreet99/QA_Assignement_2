using Assignment02;
using NUnit.Framework;

namespace CircleTests
{


    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void GetRadius_Input11_Valid()
        {
            // Arrange
            var expected = 11;
            var circle = new Circle(expected);

            // Act
            var result = circle.GetRadius();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetRadius_Input15_Valid()
        {
            // Arrange
            var expected = 23;
            var circle = new Circle(expected);

            // Act
            var result = circle.GetRadius();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetRadius_Input23_Valid()
        {
            // Arrange
            var expected = 23;
            var circle = new Circle(expected);

            // Act
            var result = circle.GetRadius();

            // Assert
            Assert.AreEqual(expected, result);
        }

    }

}
