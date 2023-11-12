using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.TretyakovDV.Sprint4.Task6.V1.Lib
{
    public class DataService : ISprint4Task6V1
    {
        public int Calculate(string[] array)
        {
            
            string[] mas = Array.FindAll(array, count => count.Length > 6);
            return mas.Length;
        }
    }
}