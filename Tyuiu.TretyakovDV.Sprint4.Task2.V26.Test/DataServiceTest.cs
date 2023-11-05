using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint4.Task2.V26.Lib;
namespace Tyuiu.TretyakovDV.Sprint4.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 1, 2, 1, 2 };
            int res = ds.Calculate(array);
            int wait = 105;
            Assert.AreEqual(res, wait);
        }
    }
}