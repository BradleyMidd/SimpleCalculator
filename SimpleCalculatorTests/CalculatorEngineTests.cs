using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Tests
{
    [TestClass()]
    public class CalculatorEngineTests
    {
        private readonly CalculatorEngine _engine = new CalculatorEngine();

        [TestMethod()]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result = _engine.Calculate("add", num1, num2);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result = _engine.Calculate("+", num1, num2);
            Assert.AreEqual(3, result);
        }
    }
}