using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SabarovDA.Sprint3.Task4.V28.Lib
{
    public class DataService : ISprint3Task4V28
    {
        public double Calculate(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                throw new ArgumentException("Начальное значение не может быть больше конечного значения.");
            }

            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != 0)
                {
                    double functionValue = (Math.Cos(x) + Math.Sin(x)) / x;
                    sum += functionValue;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}
