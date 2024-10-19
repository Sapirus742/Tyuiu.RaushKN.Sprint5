using Tyuiu.RaushKN.Sprint5.Task5.V6.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #5                                                               #");
            Console.WriteLine("# Тема: Чтение набора данных из текстового файла                          #");
            Console.WriteLine("# Задание #5                                                              #");
            Console.WriteLine("# Вариант #6                                                              #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Найти среднее значение всех вещественных чисел в файле. Полученный      #");
            Console.WriteLine("# результат вывести на консоль. У вещественных значений округлить до трёх #");
            Console.WriteLine("# знаков после запятой.                                                   #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            string path = @"C:\DataSprint5\InPutDataFileTask5V6.txt";
            Console.WriteLine("Данные находятся в файле: "+ path);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Среднее значение всех вещественных = " + res);
            Console.ReadKey();
        }
    }
}
