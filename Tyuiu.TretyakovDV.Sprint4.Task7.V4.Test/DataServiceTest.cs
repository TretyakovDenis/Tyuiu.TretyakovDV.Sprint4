using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint4.Task7.V4.Lib;
namespace Tyuiu.TretyakovDV.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            
            int n = 3;
            int m = 4;
            int[,] matrix = new int[n, m];
            string value = "382976421897";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 36;
            Assert.AreEqual(res, wait);
        }
    }
}