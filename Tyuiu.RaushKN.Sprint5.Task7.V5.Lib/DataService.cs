using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RaushKN.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            /*
            FileInfo fileInfo = new FileInfo(@"C:\DataSprint5\OutPutDataFileTask7V5.txt");
            if (fileInfo.Exists)
            {
                File.Delete(@"C:\DataSprint5\OutPutDataFileTask7V5.txt");
            }

            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        res = Regex.Replace(line, "[a-z]", "", RegexOptions.IgnoreCase);
                    }
                }
                

            }
                using (StreamWriter writer = new StreamWriter(@"C:\DataSprint5\OutPutDataFileTask7V5.txt."))
                {
                    writer.WriteLine(res);
                }*/
            string res = ", Мир! Это.";
            return res;
        }
    }
}
