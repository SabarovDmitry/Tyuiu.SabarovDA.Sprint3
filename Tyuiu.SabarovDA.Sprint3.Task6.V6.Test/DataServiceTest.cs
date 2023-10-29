using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint3.Task6.V6.Lib;
namespace Tyuiu.SabarovDA.Sprint3.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res = ds.GetSumTheDivisors(16, 24);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}

