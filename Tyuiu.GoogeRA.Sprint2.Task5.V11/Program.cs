using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogRA.Sprint2.Task5.V11.Lib;

namespace Tyuiu.GoogeRA.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема:     Оператор switch                                              *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #11                                                            *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:        *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).                      *");
            Console.WriteLine("* По заданным g, n и m определить дату следующего дня. не високосный     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введте значение переменной N:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введте значение переменной M:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введте значение переменной G:");
            int g = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();

        }
        
    }
}
