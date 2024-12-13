using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task3.V3.Lib
{
    public class DataService : ISprint6Task3V3
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            for (int row = 0; row < rows - 1; row++)
            {
                for (int i = 0; i < rows - row - 1; i++)
                {
                    if (matrix[i + 1, 1] < matrix[i,1])
                    {
                        int tmp = matrix[i,1];
                        matrix[i, 1] = matrix[i + 1, 1];
                        matrix[i + 1, 1] = tmp;
                    }
                }
            }
            return matrix;
        }
    }
}
