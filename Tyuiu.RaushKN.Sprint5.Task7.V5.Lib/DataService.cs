using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RaushKN.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
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
                using (StreamWriter writer = new StreamWriter(Path.Combine(new string[] {Path.GetTempPath(), "OutPutDataFileTask7V5.txt" })))
                {
                    writer.WriteLine(res);
                }
            return res;
        }
    }
}
