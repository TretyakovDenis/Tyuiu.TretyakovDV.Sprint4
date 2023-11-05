﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.TretyakovDV.Sprint4.Task1.V3.Lib
{
    public class DataService : ISprint4Task1V3
    {

        public int Calculate(int[] array)
        {
            
            int p = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    p *= array[i];
            }
            return p;
        }
    }
}