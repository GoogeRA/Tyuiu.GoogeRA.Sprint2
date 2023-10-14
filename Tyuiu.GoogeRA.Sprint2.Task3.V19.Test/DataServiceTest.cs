using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint2.Task3.V19.Lib;

namespace Tyuiu.GoogeRA.Sprint2.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.556;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -12;
            double res = ds.Calculate(x);
            double wait = 1.007;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -32;
            double res = ds.Calculate(x);
            double wait = -351.969;
            Assert.AreEqual(wait, res);

        }
    }
}
