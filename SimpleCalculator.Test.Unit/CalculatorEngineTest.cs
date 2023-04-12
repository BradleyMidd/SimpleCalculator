using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double restult = _engine.Calculate("add", number1, number2);
        }
    }
}
