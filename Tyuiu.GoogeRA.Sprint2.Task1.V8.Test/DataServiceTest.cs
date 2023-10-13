using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint2.Task1.V8.Lib;


// (True, False, True, False, False, False), при a = 15, b = 16, c = 14, d = 335
// и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться).


namespace Tyuiu.GoogeRA.Sprint2.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            int a = 15;
            int b = 16;
            int c = 14;
            int d = 335;

            bool[] res = new bool[6];

            res = ds.GetLogicOperations(a, b, c, d);

            bool[] wait = new bool[6] { true, false, true, false, false, false };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
