using Tyuiu.SyrtsovaSA.Sprint6.Task6.V2.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Linn\Documents\InPutDataFileTask6V2.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "daijiHMupBSzreYGVyY";
        }
    }
}