using Tyuiu.RaushKN.Sprint5.Task6.V2.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V2.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 9;

            Assert.AreEqual(wait, res);
        }
    }
}