using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TestClass
{
    public class TestTriangle
    {
        [Test]
        public void TestEquilateralTriangle_Valid_ReturnsEquilateral()
        {
            // Arrange
            int firstSide = 9;
            int secondSide = 9;
            int thirdSide = 9;
            string expected = ("An equilateral triangle is formed");

            // Act

            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestIsoscelesTriangle_Valid1_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 9;
            int secondSide = 9;
            int thirdSide = 6;
            string expected = "An isosceles triangle is formed";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestIsoscelesTriangle_Valid2_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 9;
            int thirdSide = 9;
            string expected = ("An isosceles triangle is formed");

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestIsoscelesTriangle_Valid3_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 9;
            int secondSide = 6;
            int thirdSide = 9;

            string expected = ("An isosceles triangle is formed");

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
