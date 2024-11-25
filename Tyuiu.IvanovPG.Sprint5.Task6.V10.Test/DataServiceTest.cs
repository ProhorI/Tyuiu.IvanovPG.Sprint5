
using Tyuiu.IvanovPG.Sprint5.Task6.V10.Lib;

namespace Tyuiu.IvanovPG.Sprint5.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V10.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}