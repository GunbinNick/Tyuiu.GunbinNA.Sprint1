using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint1.Task7.V13.Lib;
namespace Tyuiu.GunbinNA.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(0.07, result);
        }
    }
}
