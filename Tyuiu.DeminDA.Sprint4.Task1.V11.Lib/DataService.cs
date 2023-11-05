using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DeminDA.Sprint4.Task1.V11.Lib
{
    public class DataService : ISprint4Task1V11
    {
        public int Calculate(int[] array)
        {
            
                int sum = 0;
                foreach (int num in array)
                {
                    if (num % 2 == 0) // проверка на четность
                    {
                        sum += num; // добавление четного элемента к сумме
                    }
                }
                return sum;
        }
    }
}
