using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DeminDA.Sprint4.Task2.V17.Lib;
namespace Tyuiu.DeminDA.Sprint4.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 3,4,5,6,7,8,9,3,4};

            int res = ds.Calculate(numsArray);
            int wait = 2835;

            Assert.AreEqual(wait, res);

        }
    }
}
