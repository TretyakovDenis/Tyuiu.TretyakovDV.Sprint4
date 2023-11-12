﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint4.Task4.V28.Lib;
namespace Tyuiu.TretyakovDV.Sprint4.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 3, 3, 1, 1, 4 },
                                           { 2, 4, 2, 1, 5 },
                                           { 2, 2, 2, 2, 2 },
                                           { 1, 5, 4, 5, 4 },
                                           { 1, 2, 3, 2, 4 } }; 


            int res = ds.Calculate(array);
            int[,] wait = new int[5,5] { { 3, 3, 1, 1, 1 },
                                         { 1, 1, 1, 1, 5 },
                                         { 1, 1, 1, 1, 1 },
                                         { 1, 5, 1, 5, 1 },
                                         { 1, 1, 3, 1, 1 } };
            Assert.AreEqual(res, wait);
        }
    }
}