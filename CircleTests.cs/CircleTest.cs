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

        [Test]
        public void SetRadius_Input17_Valid()
        {
            // Arrange
            var expected = 17;
            var circle = new Circle();

            // Act
            circle.SetRadius(expected);

            // Assert
            Assert.AreEqual(expected, circle.GetRadius());
        }

        [Test]
        public void SetRadius_Input19_Valid()
        {
            // Arrange
            var expected = 19;
            var circle = new Circle();

            // Act
            circle.SetRadius(expected);

            // Assert
            Assert.AreEqual(expected, circle.GetRadius());
        }

        [Test]
        public void SetRadius_InputNegative1_Valid()
        {
            // Arrange
            var expected = -1;
            var circle = new Circle();

            // Act
            circle.SetRadius(expected);

            // Assert
            Assert.AreEqual(expected, circle.GetRadius());
        }

        [Test]
        public void GetCircumference_Input15_Valid()
        {
            // Arrange
            var radius = 15;
            var expected = 2 * System.Math.PI * 15;
            var circle = new Circle(radius);

            // Act
            var result = circle.GetCircumference();

            // Assert
            Assert.AreEqual(expected, result, 0.01);
        }

        [Test]
        public void GetCircumference_InputNegative45_Valid()
        {
            // Arrange
            var radius = -45;
            var expected = 2 * System.Math.PI * radius;
            var circle = new Circle(radius);

            // Act
            var result = circle.GetCircumference();

            // Assert
            Assert.AreEqual(expected, result, 0.01);
        }

        [Test]
        public void GetCircumference_Input16_Valid()
        {
            // Arrange
            var radius = 16;
            var expected = 2 * System.Math.PI * radius;
            var circle = new Circle(radius);

            // Act
            var result = circle.GetCircumference();

            // Assert
            Assert.AreEqual(expected, result, 0.01);
        }

        [Test]
        public void GetArea_Input45_Valid()
        {
            // Arrange
            var radius = 45;
            var expected = System.Math.PI * System.Math.Pow(radius, 2);
            var circle = new Circle(radius);

            // Act
            var result = circle.GetArea();

            // Assert
            Assert.AreEqual(expected, result, 0.01);
        }

        [Test]
        public void GetArea_Input23_Valid()
        {
            // Arrange
            var radius = 23;
            var expected = System.Math.PI * System.Math.Pow(radius, 2);
            var circle = new Circle(radius);

            // Act
            var result = circle.GetArea();

            // Assert
            Assert.AreEqual(expected, result, 0.01);
        }

        [Test]
        public void GetArea_Input27_Valid()
        {
            // Arrange
            var radius = 27;
            var expected = System.Math.PI * System.Math.Pow(radius, 2);
            var circle = new Circle(radius);

            // Act
            var result = circle.GetArea();

            // Assert
            Assert.AreEqual(expected, result, 0.01);
        }
    }

}
