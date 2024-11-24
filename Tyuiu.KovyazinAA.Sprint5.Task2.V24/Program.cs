using Tyuiu.KovyazinAA.Sprint5.Task2.V24.Lib;
namespace Tyuiu.KovyazinAA.Sprint5.Task2.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Ковязин А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл.     *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Ковязин Андрей Александрович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длинне                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив:                                                                 *");
            int[,] nums = { { 6, 0, 6 }, { -1, -8, 7 }, { 5, 1, 0 } };
            int rows = nums.GetUpperBound(0) + 1;
            int cols = nums.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{nums[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + ds.SaveToFileTextData(nums));
        }
    }
}
