using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint4.Task5.V9.Lib;
namespace Tyuiu.TretyakovDV.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 3, -4, 1, -4, -3 },
                                           { -2, -3, 3, -1, -1 },
                                           { 1, -2, 3, -2, -1 },
                                           { -3, -1, -2, -1, -2 },
                                           { -3, -4, -4, -1, -2 } };
            int res = ds.Calculate(matrix);
            int wait = 5;
            Assert.AreEqual(res, wait);
        }
    }
}