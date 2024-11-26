using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KovyazinAA.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace(".", ",");
            double x = Convert.ToDouble(strX);
            double y = x / (2 * x) + Math.Sin(Math.Pow(x, 2));
            y = Math.Round(y,3);
            return y;
        }
    }
}
