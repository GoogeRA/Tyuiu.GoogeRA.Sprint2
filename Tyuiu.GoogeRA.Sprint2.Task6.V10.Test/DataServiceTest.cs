using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint2.Task6.V10.Lib;

namespace Tyuiu.GoogeRA.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            Assert.AreEqual("31.12.23", ds.FindDateOfPreviousDay(24, 1, 1));

        }
    }
}
