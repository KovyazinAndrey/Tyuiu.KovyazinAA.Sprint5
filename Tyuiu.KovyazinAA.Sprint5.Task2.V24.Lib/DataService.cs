using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KovyazinAA.Sprint5.Task2.V24.Lib
{
    public class DataService : ISprint5Task2V24
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;
        }
    }
}
