using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SyrtsovaSA.Sprint6.Task0.V11.Lib
{
    public class DataService : ISprint6Task0V11
    {
        public double Calculate(int x)
        {
            return Math.Round(1.6 * x * x * x - 2.1 * x * x + 7 * x, 3);
        }
    }
}
