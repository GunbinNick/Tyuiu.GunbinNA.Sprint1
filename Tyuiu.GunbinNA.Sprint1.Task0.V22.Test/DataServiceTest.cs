using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint1.Task0.V22.Lib;
namespace Tyuiu.GunbinNA.Sprint1.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var wait = 10;
            var res = ds.Calculate();
            Assert.AreEqual(wait, res);
        }
    }
}
