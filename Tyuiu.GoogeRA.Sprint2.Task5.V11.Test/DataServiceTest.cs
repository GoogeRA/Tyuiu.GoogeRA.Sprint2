using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogRA.Sprint2.Task5.V11.Lib;

namespace Tyuiu.GoogeRA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g, m, n;
            string res = ds.FindDateOfNextDay(g, m, n);



        }
    }
}
