using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint3.Task3.V29.Lib;
namespace Tyuiu.SabarovDA.Sprint3.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "chgr vhhtg hnht";
            char chr = 'h';
            string res = ds.DeleteCharInString(value, chr);
            string wait = "cgr vtg nt";
            Assert.AreEqual(wait, res);
        }
    }
}
