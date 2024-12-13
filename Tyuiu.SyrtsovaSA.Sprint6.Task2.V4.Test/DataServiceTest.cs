using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SyrtsovaSA.Sprint6.Task4.V25.Lib.Old;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] wait = new double[len];
            wait[0] = -15.6;
            wait[1] = -12.35;
            wait[2] = -10.72;
            wait[3] = -8.88;
            wait[4] = -2.16;
            wait[5] = 3.25;
            wait[6] = 6.64;
            wait[7] = 10.3;
            wait[8] = 16.17;
            wait[9] = 28.1;
            wait[10] = 38.41;
            double[] res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
