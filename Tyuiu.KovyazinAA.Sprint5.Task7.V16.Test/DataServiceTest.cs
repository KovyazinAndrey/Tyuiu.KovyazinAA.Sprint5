using System.IO;
using Tyuiu.KovyazinAA.Sprint5.Task7.V16.Lib;
namespace Tyuiu.KovyazinAA.Sprint5.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V16.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool file = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, file);
        }
    }
}