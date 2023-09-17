using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алина";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Алина", res);
        }
    }
}
