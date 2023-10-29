using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint3.Task4.V28.Lib;
namespace Tyuiu.SabarovDA.Sprint3.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int start = -5;
            int end = 5;


            double res = ds.Calculate(start, end);

            double wait = 1.924;

            Assert.AreEqual(wait, res);
        }
    }
}
