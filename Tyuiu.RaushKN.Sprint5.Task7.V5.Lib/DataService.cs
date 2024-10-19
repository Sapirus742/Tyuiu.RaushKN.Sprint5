using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RaushKN.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            int count = 0;
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.ToUpper();
                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        if ((c >= 'A') && (c <= 'Z')) count++;
                        else res = res + c;
                    }
                    res = res.ToLower();
                }
            }

            using (StreamWriter writer = new StreamWriter(@"C:\DataSprint5\OutPutDataFileTask7V5.txt."))
            {
                writer.WriteLine(res);
            }

            return res;
        }
    }
}
