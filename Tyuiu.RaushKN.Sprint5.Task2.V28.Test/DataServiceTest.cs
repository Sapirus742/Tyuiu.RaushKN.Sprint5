using Tyuiu.RaushKN.Sprint5.Task2.V28.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,] { { -5, -2, -5 }, { 3, 1, -3 }, { 9, -2, -9 } };
            string res = ds.SaveToFileTextData(matrix);
            string path = @"C:\Users\rausc\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}