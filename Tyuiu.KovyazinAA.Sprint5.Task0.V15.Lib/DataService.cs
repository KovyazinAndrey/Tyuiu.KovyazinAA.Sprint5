using System.IO;
using System.Runtime.InteropServices;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KovyazinAA.Sprint5.Task0.V15.Lib
{
    public class DataService : ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
            string halfpath = Path.GetTempPath();
            string path = Path.Combine(halfpath, "OutPutFileTask0.txt");
            double z = (x) / (Math.Pow(x, 3) + 2);
            z = Math.Round(z,3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
