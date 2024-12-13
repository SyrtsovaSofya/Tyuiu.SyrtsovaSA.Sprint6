using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task4.V25.Lib
{
    public class DataService : ISprint6Task4V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Cos(x) + 4*x/2 - Math.Sin(x) * 3 * x, 2);
                valueArray[count++] = y;
            }
            return valueArray;
        }
    }
}
