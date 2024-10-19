using Tyuiu.RaushKN.Sprint5.Task6.V2.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #5                                                               #");
            Console.WriteLine("# Тема: Обработка текстовых файлов                                        #");
            Console.WriteLine("# Задание #6                                                              #");
            Console.WriteLine("# Вариант #2                                                              #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine(@"# Дан файл С:\DataSprint5\InPutDataFileTask6V2.txt (файл взять из        #");
            Console.WriteLine("# архива согласно вашему варианту. Создать папку в ручную                 #");
            Console.WriteLine(@"# С:\DataSprint5\ и скопировать в неё файл) в котором есть набор         #");
            Console.WriteLine("# символьных данных. Найти количество русских букв в заданной строке.     #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            string path = @"C:\DataSprint5\InPutDataFileTask6V2.txt";
            Console.WriteLine("Данные находятся в файле: "+ path);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество русских букв = " + res);
            Console.ReadKey();
        }
    }
}
