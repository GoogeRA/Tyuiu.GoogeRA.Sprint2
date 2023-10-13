using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

// (True, False, True, False, False, False), при a = 15, b = 16, c = 14, d = 335
// и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться).

namespace Tyuiu.GoogeRA.Sprint2.Task1.V8.Lib
{
    public class DataService : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d); // true  a = 15 b =  16   C = 14 d = 335 
            res[1] = (a + 3 > b) & (c + 400 < d);  //false
            res[2] = (a > b) || (c < d); //true
            res[3] = (a - 6 > b) && (c + 1000 < d); //false
            res[4] = !(!res[1]); //false 
            res[5] = (a > b) ^ (c < d - 325); // false

            return res;

        }
    }
}
