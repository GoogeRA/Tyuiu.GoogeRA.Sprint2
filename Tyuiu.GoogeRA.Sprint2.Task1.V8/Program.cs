﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint2.Task1.V8.Lib;

namespace Tyuiu.GoogeRA.Sprint2.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Логические операции                                              *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #8                                                             *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,        *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в        *");
            Console.WriteLine("*  выражении) и логических операций (|, &, ||, &&, !, ^,                 *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также             *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность *");
            Console.WriteLine("* (массив): (True, False, True, False, False, False),                    *"); 
            Console.WriteLine("* при a = 15, b = 16, c = 14, d = 335                                    *");

            int a = 15;
            int b = 16;
            int c = 14;
            int d = 335;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
