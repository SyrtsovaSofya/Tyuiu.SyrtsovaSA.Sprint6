using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SyrtsovaSA.Sprint6.Task2.V4.Lib.NewVersion
{
    public class DataService : ISprint6Task1V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[(stopValue - startValue) + 1];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) + 2) == 0)
                    valueArray[count++] = 0;
                else
                {
                    y = (5 * x + 2.5) / (Math.Sin(x) + 2) + 2 * x + 2;
                    valueArray[count++] = Math.Round(y, 2);
                }
            }
            return valueArray;
        }
    }
}
