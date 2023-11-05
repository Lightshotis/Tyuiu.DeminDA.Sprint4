using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DeminDA.Sprint4.Task3.V6.Lib
{
    public class DataService : ISprint4Task3V6

    {
        public int Calculate(int[,] array)
        {   
            int maxElement = array[1, 0];
            
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[1, j] > maxElement)
                {
                    maxElement =array[1, j];
                }
            }
            return maxElement;
        }
    }
}
