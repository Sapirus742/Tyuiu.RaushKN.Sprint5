using Tyuiu.RaushKN.Sprint5.Task1.V29.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\rausc\source\repos\Tyuiu.RaushKN.Sprint5\Tyuiu.RaushKN.Sprint5.Task1.V29\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}