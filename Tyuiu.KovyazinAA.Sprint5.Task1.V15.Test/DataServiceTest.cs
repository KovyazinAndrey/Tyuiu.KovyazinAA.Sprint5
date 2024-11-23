using System.IO;
using Tyuiu.KovyazinAA.Sprint5.Task1.V15.Lib;
namespace Tyuiu.KovyazinAA.Sprint5.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Andrey\AppData\Local\Temp\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}