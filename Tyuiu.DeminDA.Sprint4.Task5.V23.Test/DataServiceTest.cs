using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DeminDA.Sprint4.Task5.V23.Lib;

namespace Tyuiu.DeminDA.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalc()
        {
            DataService ds= new DataService();


            int[,] mas2 = new int[5, 5]
            {
                { -6, 3, 6, 6, 7 },

                { 9, -8, 9, 7, 9 },

                { 5, 6, -8, 7, 5 },

                { 8, 5, 6, -5, 3 },

                { 3, 9, 9, 8, -8 }
            };
            int[,] wait = new int[5, 5]
            {
                { 0, 3, 6, 6, 7 },

                { 9, 0, 9, 7, 9 },

                { 5, 6, 0, 7, 5 },

                { 8, 5, 6, 0, 3 },

                { 3, 9, 9, 8, 0 }
            };

            int[,] res = ds.Calculate(mas2);


            CollectionAssert.AreEqual(wait, res);
        }
    }
}
