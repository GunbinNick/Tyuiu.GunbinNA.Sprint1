using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint1.Task3.V1.Lib;
namespace Tyuiu.GunbinNA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double r = 4;
            double h = 7;
            var result = ds.CylinderVolume(r, h);
            Assert.AreEqual(351.792, result);
        }
    }
}
