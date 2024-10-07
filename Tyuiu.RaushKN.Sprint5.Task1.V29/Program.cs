using Tyuiu.RaushKN.Sprint5.Task1.V29.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #5                                                               #");
            Console.WriteLine("# Тема: Класс File. Запись набора данных в текстовый файл                 #");
            Console.WriteLine("# Задание #1                                                              #");
            Console.WriteLine("# Вариант #29                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Дана функция, произвести табулирование f(x) на диапазоне [-5,5] с шагом #");
            Console.WriteLine("# 1. Произвести проверку деления на ноль. При делении на ноль вернуть     #");
            Console.WriteLine("# значение 0. Результат сохранить в текстовый фойл OutPutFileTask1.txt и  #");
            Console.WriteLine("# вывести на консоль в таблицу. Значения округлить до двух знаков после   #");
            Console.WriteLine("# запятой                                                                 #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начальное значение диапазона = " + startValue);
            Console.WriteLine("Конечное значение диапазона = " + stopValue);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
