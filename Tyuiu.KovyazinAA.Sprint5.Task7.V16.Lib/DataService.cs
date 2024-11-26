using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KovyazinAA.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), @"OutPutDataFileTask7V16.txt");
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileEx = fileInfo.Exists;
            if (fileEx)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                int countChar = 0;
                string wordmore4letters = "";
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        wordmore4letters = wordmore4letters + c;
                        if (char.IsLetter(c))  
                        {
                            countChar++;
                            continue;
                        }
                        else if (char.IsWhiteSpace(c) && countChar == 2)
                        {
                            strLine = strLine + "XY ";
                            countChar = 0;
                            wordmore4letters = "";
                            continue;
                        }
                        else if (countChar > 2)
                        {
                            strLine = strLine + wordmore4letters;
                            countChar = 0;
                            wordmore4letters = "";
                            continue;
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
