using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.GunbinNA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double f = 39;
            int h = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(1, h);
        }
    }
}
