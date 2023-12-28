using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint1.Task4.V5.Lib;
namespace Tyuiu.GunbinNA.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -3;
            double y = 4;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(1, result);
        }
    }
}
