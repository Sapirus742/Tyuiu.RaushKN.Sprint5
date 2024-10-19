using Tyuiu.RaushKN.Sprint5.Task7.V5.Lib;

namespace Tyuiu.RaushKN.Sprint5.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #5                                                               #");
            Console.WriteLine("# Тема: Добавление к решению итоговых проектов по спринту                 #");
            Console.WriteLine("# Задание #7                                                              #");
            Console.WriteLine("# Вариант #5                                                              #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine(@"# Дан файл С:\DataSprint5\InPutDataFileTask7V5.txt (файл взять из        #");
            Console.WriteLine("# архива согласно вашему варианту. Создать папку в ручную                 #");
            Console.WriteLine(@"# С:\DataSprint5\ и скопировать в неё файл) в котором есть набор         #");
            Console.WriteLine("# символьных данных.Удалить все латинские буквы из файла.Полученный       #");
            Console.WriteLine("# результат сохранить в файл OutPutDataFileTask7V5.txt.                   #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            string path = @"C:\DataSprint5\InPutDataFileTask7V5.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V5.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
            
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            if (fileInfo.Exists ) File.Delete(pathSaveFile);

            Console.WriteLine("находится в файле: "+ pathSaveFile);
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Полученная стока: "+pathSaveFile);
            Console.ReadKey();
        }
    }
}
