using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SabarovDA.Sprint3.Task6.V6.Lib
{
    public class DataService : ISprint3Task6V6
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int i = startValue; i != stopValue + 1; i++)
            {
                for (int j = 1; j != i; j++)
                {
                    if (i % j == 0 && j > 10)
                    {
                        res++;
                    }
                }
            }
            return res;
        }
    }
}
