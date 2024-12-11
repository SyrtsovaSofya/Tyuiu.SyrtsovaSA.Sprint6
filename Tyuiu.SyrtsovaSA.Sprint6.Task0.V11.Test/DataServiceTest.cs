using Tyuiu.SyrtsovaSA.Sprint6.Task0.V11.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            Assert.AreEqual(6.5, res);
        }
    }
}