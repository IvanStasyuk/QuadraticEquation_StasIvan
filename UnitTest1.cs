using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QuadraticTest
{
    [TestClass]
    public class UnitQuadratic
    {
        [TestMethod]
        public void TestMathPow()
        {
            double a = 1;
            double b = 4;
            double c = 3;


            double result1 = 4;
            double result2 = 2;
            double result3 = 6;
            double expected1 = Math.Pow(b, 2) - 4 * a * c;
            double expected2 = b - Math.Sqrt(4) / 1 * 1;
            double expected3 = b + Math.Sqrt(4) / 1 * 1;


            Assert.AreEqual(result1, expected1);
            Assert.AreEqual(result2, expected2);
            Assert.AreEqual(result3, expected3);
        }
    }
}
