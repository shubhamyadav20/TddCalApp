using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddCalApp.Library;

namespace TddCalApp.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ShouldReturnPositiveonPassingTwoPositiveNumber()
        {
            Calculator TestCalculator = new Calculator();
            int num1 = 2;
            int num2 = 3;
           int result = TestCalculator.Add(num1, num2);
            Assert.AreEqual(5, result, "Testing  two Integer 3 and 2");

        }
    }
}
