using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DeminDA.Sprint4.Task7.V4.Lib;

namespace Tyuiu.DeminDA.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string str = "382976421897";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 36;
            Assert.AreEqual(wait, res);

        }
    }
}
