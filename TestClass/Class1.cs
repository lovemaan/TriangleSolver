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
        [Test]
        public void TestScaleneTriangle_Valid1_ReturnsScalene()
        {
            // Arrange
            int firstSide = 2;
            int secondSide = 4;
            int thirdSide = 5;

            string expected = ("A scalene triangle is formed");
            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestScaleneTriangle_Valid2_ReturnsScalene()
        {
            // Arrange
            int firstSide = 8;
            int secondSide = 11;
            int thirdSide = 13;

            string expected = ("A scalene triangle is formed");

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestScaleneTriangle_Valid3_ReturnsScalene()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 14;
            int thirdSide = 16;

            string expected = ("A scalene triangle is formed");

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void  TestScaleneTriangle_Valid4_ReturnsScalene()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 10;
            int thirdSide = 12;

            string expected = ("A scalene triangle is formed");

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestScaleneTriangle_Valid5_ReturnsScalene()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 8;
            int thirdSide = 10;

            string expected = ("A scalene triangle is formed");

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestZeroLengthSide1_ReturnsError()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 3;
            int thirdSide = 6;

            string expected = ("At least one side entered had a zero - invalid triangle");

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestZeroLengthSide2_ReturnsError()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 0;
            int thirdSide = 8;

            string expected = ("At least one side entered had a zero - invalid triangle");

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestZeroLengthSide3_ReturnsError()
        {
            // Arrange
            int firstSide = 4;
            int secondSide = 7;
            int thirdSide = 0;

            string expected = ("At least one side entered had a zero - invalid triangle");

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
