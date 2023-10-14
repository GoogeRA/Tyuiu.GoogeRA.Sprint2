using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint2.Task4.V3.Lib;

namespace Tyuiu.GoogeRA.Sprint2.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValideCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 11.667;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValideCondition2()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 10.529;
            Assert.AreEqual(wait, res);
        }
    }
}
