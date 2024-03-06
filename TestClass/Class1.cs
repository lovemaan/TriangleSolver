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
            // Arrange a Test
            int firstSide = 9;
            int secondSide = 9;
            int thirdSide = 9;

            string excepted = ("An equilateral triangle is formed");

            // Perform a Test

            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert a Test
            Assert.That(actual, Is.EqualTo(excepted));
        }
    }
}
