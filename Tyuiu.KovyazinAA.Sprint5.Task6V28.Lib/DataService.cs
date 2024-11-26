using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KovyazinAA.Sprint5.Task6V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                int countnum = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        if (char.IsLetter(c))
                        {
                            countnum = 0;
                            continue;
                        }
                        else if (char.IsDigit(c))
                        {
                            if (countnum < 4) 
                            {
                                countnum++;
                                continue;
                            }
                            else if (countnum == 4)
                            {
                                count++;
                                countnum = 0;
                                continue;
                            }
                        }
                    }
                }
                return count;
            }
        }
    }
}
