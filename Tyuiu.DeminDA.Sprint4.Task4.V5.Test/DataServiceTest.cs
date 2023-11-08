using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DeminDA.Sprint4.Task4.V5.Lib;

namespace Tyuiu.DeminDA.Sprint4.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]
            {
                { 6, 3, 6, 6, 7 },

                { 9, 8, 9, 7, 9 },

                { 5, 6, 8, 7, 5 },

                { 8, 5, 6, 5, 3 },

                { 3, 9, 9, 8, 8 }
            };
            int res = ds.Calculate(mas2);
            int wait = 70;
            Assert.AreEqual(wait, res);
        }

    }
}
