﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

// (==, !=, <, >, <=, >=)

namespace Tyuiu.GoogeRA.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 620 == y;
            res[1] = x != y + 620;
            res[2] = x - 670 < y;
            res[3] = x > y + 800;
            res[4] = x <= y + 620;
            res[5] = x - 999 >= y;

            return res;
        }  
    }
}
