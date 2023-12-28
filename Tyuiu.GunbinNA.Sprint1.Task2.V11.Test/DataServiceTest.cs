using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint1.Task2.V11.Lib;
namespace Tyuiu.GunbinNA.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 3;
            int valueTwo = 23;
            var wait = 12180;
            var res = ds.ConvertHoursMinutesToSeconds(value, valueTwo);
            Assert.AreEqual(wait, res);
        }
    }
}
