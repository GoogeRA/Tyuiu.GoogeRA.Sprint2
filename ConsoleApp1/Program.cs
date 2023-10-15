using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, g;
            Console.WriteLine("Введите день");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год");
            g = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1:
                            n = 31;
                            m = 12;
                            g--;
                            break;
                        default:
                            m--;
                            switch (m)
                            {
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10:
                                    n = 31;
                                    break;
                                case 2:
                                    n = 28;
                                    break;
                                default:
                                    n = 30;
                                    break;
                            }
                            break;
                    }
                    break;
                default:
                    n--;
                    break;
            }

            Console.WriteLine("{0}.{1}.{2}", n, m, g);
            Console.ReadLine();
        }
    }
}
