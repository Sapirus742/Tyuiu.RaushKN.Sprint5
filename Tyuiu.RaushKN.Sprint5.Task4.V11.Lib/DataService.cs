using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.RaushKN.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            FileInfo fileInfo = new FileInfo(path);
            strX = strX.Replace(".", ",");
            if (fileInfo.Exists)
            {
                double x = Convert.ToDouble(strX);
                double res = Math.Round(Math.Sin(x) + Math.Pow(x, 2) / 2, 3);
                return res;
            }
            else
            {
                double res = 0;
                return res;
            }
                
        }
    }
}
