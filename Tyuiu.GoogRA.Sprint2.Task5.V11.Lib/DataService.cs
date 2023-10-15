using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GoogRA.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {

            switch(n)
            {
                case 30:
                    switch (m)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            n = 1;
                            m++;
                            break;
                        default:
                            n++;
                            break;
                    }
                    break;
                case 28:
                    switch (m)
                    {
                        case 2:
                            n = 1;
                            m++;
                            break;
                    }
                    break;
                case 31:
                    switch (m)
                    {
                        case 12:
                            n = 1;
                            m = 1;
                            g++;
                            break;
                        default:
                            n = 1;
                            m++;
                            break;
                    }
                    break;
                default:
                    n++;
                    break;
            }
            return Convert.ToString(n) + "." + Convert.ToString(m) + "." + Convert.ToString(g);
        }
    }
}
