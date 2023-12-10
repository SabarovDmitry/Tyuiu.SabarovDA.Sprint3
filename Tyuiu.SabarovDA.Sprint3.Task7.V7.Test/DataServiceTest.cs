using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint3.Task7.V7.Lib;
namespace Tyuiu.SabarovDA.Sprint3.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 17.23;
            valueWaitArray[1] = 13.51;
            valueWaitArray[2] = 10.34;
            valueWaitArray[3] = 7.79;
            valueWaitArray[4] = 5.00;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = 0.08;
            valueWaitArray[7] = -4.62;
            valueWaitArray[8] = -8.32;
            valueWaitArray[9] = -10.82;
            valueWaitArray[10] = -12.66;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
