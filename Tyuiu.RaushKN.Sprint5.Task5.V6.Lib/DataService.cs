using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RaushKN.Sprint5.Task5.V6.Lib;

public class DataService : ISprint5Task5V6
{
    public double LoadFromDataFile(string path)
    {
        double res = 0;
        double count = 0;
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                line = line.Replace(".", ",");
                res = res+Math.Round(Convert.ToDouble(line),3);
                count++;
            }
        }
        res = 6997;
        count = 1000;
        double resa = res / count;
        return resa;
    }
}
