using Tyuiu.RaushKN.Sprint5.Task0.V23.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task0.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #5                                                               #");
            Console.WriteLine("# Тема: Класс File. Запись данных в текстовый файл                        #");
            Console.WriteLine("# Задание #0                                                              #");
            Console.WriteLine("# Вариант #23                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Дано выражение, вычислить его значение при x = 3, результат сохранить в #");
            Console.WriteLine("# текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до   #");
            Console.WriteLine("# трёх знаков после запятой.                                              #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int x = 3;
            Console.WriteLine("x = "+ x);
            
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
            
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: "+res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
