using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MorukhinRM.Sprint0.Task4.V0.Lib;
namespace Tyuiu.MorukhinRM.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSubstractionInvalid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));

        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]
         public void CheckedDivisionInvalid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }

    }
}
