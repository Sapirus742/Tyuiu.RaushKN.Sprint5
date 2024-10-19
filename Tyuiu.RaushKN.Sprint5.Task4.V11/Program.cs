using Tyuiu.RaushKN.Sprint5.Task4.V11.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #5                                                               #");
            Console.WriteLine("# Тема: Чтение данных из текстового файлаv                                #");
            Console.WriteLine("# Задание #4                                                              #");
            Console.WriteLine("# Вариант #11                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine(@"# Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из       #");
            Console.WriteLine("# архива согласно вашему варианту. Создать папку в ручную                 #");
            Console.WriteLine(@"# С:\\DataSprint5\\ и скопировать в неё файл) в котором есть вещественное #");
            Console.WriteLine("# значение. Прочитать значение из файла и подставить вместо Х в формуле.  #");
            Console.WriteLine("# Вычислить значение по формуле (Полученное значение округлить до трёх    #");
            Console.WriteLine("# знаков после запятой) и вернуть полученный результат на консоль.        #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            string path = @"C:\DataSprint5\InPutDataFileTask4V11.txt";
            Console.WriteLine("Данные находятся в файле: "+path);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
