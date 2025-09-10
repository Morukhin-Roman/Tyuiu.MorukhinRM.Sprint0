using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MorukhinRM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MorukhinRM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            
            var name = "Рома";
            var res = DataService.GetMessage(name);


            Assert.AreEqual("Привет..., Рома", res);
        }
    }
}
