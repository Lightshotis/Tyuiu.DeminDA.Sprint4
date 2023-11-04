using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DeminDA.Sprint4.Task0.V30.Lib
{
    public class DataService : ISprint4Task0V30
    {
        public int GetSumEvenArrEl(int[] array)
        {   int sum= 0;
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
