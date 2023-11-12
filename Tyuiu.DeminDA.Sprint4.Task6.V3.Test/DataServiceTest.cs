using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DeminDA.Sprint4.Task6.V3.Lib;

namespace Tyuiu.DeminDA.Sprint4.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            var months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август",  "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int res = ds.Calculate(months);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
