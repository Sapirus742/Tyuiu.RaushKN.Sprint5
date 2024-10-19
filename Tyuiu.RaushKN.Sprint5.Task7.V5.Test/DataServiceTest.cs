using Tyuiu.RaushKN.Sprint5.Task7.V5.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }

        [TestMethod]

        public void LoadDataAndSave()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V5.txt";
            var res = ds.LoadDataAndSave(path);
            string wait = ", Мир! Это.";

            Assert.AreEqual(wait, res);
        }
    }
}