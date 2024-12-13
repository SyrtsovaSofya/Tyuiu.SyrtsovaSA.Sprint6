using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SyrtsovaSA.Sprint6.Task5.V21.Lib.Old;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Linn\source\repos\Tyuiu.SyrtsovaSA.Sprint6\Tyuiu.SyrtsovaSA.Sprint6.Task5.V21\bin\Debug\InPutDataFileTask5V21.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 12, -9 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
