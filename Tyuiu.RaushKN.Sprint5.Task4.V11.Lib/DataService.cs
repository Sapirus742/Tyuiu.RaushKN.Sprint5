using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.RaushKN.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(@"/app/data/AssesmentData/C#/Sprint5Task4/InPutDataFileTask4V11.txt");
            double x = Convert.ToDouble(strX); 
            double res = Math.Round(Math.Sin(x) + Math.Pow(x, 2) / 2, 3);
            return res;
        }
    }
}
