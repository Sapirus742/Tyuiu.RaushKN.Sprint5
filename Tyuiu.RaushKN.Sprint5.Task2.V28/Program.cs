using Tyuiu.RaushKN.Sprint5.Task2.V28.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task2.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #5                                                               #");
            Console.WriteLine("# Тема: Класс File. Запись структурированных данных в текстовый файл      #");
            Console.WriteLine("# Задание #2                                                              #");
            Console.WriteLine("# Вариант #28                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        #");
            Console.WriteLine("# значениями с клавиатуры. Заменить положительные элементы массива на 1,  #");
            Console.WriteLine("# отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и    #");
            Console.WriteLine("# вывести на консоль.                                                     #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            /*Console.WriteLine("Введите матрицу 3x3: ");
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++) 
                for (int j = 0; j < 3; j++)
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            */
            int[,] matrix = new int[,] { { -5, -2, -5 }, { 3, 1, -3 }, { 9, -2, -9 } };
            int rows =  matrix.GetUpperBound(0)+1;
            int colums = matrix.Length / rows;

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            string res = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Итоговая матрица: ");
            using (var reader = new StreamReader(res))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    Console.WriteLine(values[0]);
                }
            }

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
