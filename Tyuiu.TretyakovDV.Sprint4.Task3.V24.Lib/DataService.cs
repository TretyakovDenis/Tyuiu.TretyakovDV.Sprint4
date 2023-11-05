using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.TretyakovDV.Sprint4.Task3.V24.Lib
{
    public class DataService : ISprint4Task3V24
    {

        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int min = array[0,1];
            for (int i = 0; i < rows; i++)
            {
                    if (array[i, 1] < min)
                    {
                        min = array[i, 1];
                    }
            }
            return min;
        }
        
    }
}