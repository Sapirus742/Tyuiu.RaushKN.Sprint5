﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RaushKN.Sprint5.Task0.V23.Lib
{
    public class DataService : ISprint5Task0V23
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = Math.Round((1 + Math.Pow(x, 3)) / Math.Pow(x, 2),2);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
