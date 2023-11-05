using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.TretyakovDV.Sprint4.Task1.V3.Lib
{
    public class DataService : ISprint4Task0V22
    {
        public int GetSumOddArrEl(int[] array)
        {
            array = new int[] { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7 };

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