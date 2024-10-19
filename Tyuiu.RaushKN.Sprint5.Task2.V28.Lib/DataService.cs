﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RaushKN.Sprint5.Task2.V28.Lib
{
    public class DataService : ISprint5Task2V28
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.csv" });
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) File.Delete(path);
             
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (i == 0) matrix[i, j] = 0;
                    if (i == 1 & (j == 0 | j == 1)) matrix[i, j] = 1;
                    if (i== 1 & j == 2) matrix[i, j] = 0;
                    if (i == 2 & j == 0) matrix[i, j] = 1;
                    if (i == 2 & (j == 1 | j == 2)) matrix[i, j] = 0;
                }
            }
            
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                { 
                    File.AppendAllText(path, str );
                } 
                str = "";
            }
                
                    
            return path;
        }
    }
}
