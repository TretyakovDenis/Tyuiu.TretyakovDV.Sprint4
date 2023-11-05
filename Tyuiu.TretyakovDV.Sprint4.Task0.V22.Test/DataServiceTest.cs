using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint4.Task0.V22.Lib;
namespace Tyuiu.TretyakovDV.Sprint4.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.GetSumOddArrEl(array);
            int wait = 46;
            Assert.AreEqual(res, wait);
        }
    }
}