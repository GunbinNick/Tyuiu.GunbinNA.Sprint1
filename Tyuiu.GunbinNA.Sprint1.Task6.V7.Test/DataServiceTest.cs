using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint1.Task6.V7.Lib;
namespace Tyuiu.GunbinNA.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string h = "Пука";
            var result = ds.DeleteLastLetter(h);
            Assert.AreEqual("Пук", result);
        }
    }
}
