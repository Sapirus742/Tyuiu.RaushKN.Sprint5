using Tyuiu.RaushKN.Sprint5.Task3.V22.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;
            string res = ds.SaveToFileTextData(x);
            string path = @"C:\Users\rausc\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}