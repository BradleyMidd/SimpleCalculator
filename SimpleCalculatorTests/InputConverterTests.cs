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
    public class InputConverterTests
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod()]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }        
        
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
        }
    }
}