using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BorisovaDS.Sprint5.Task7.V5.Lib;

namespace Tyuiu.BorisovaDS.Sprint5.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Борисова Д.С. | ИСТН-б-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #7                                                                    *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                            *");
            Console.WriteLine("* Задание #7                                                                   *");
            Console.WriteLine("* Вариант #5                                                                   *");
            Console.WriteLine("* Выполнила: Борисова Диана Сергеевна | ИСТН-б-23-1                            *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V5.txt (файл взять из архива     *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\   и       *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.Удалить все   *");
            Console.WriteLine("* латинские буквы из файла.Полученный результат                                *");
            Console.WriteLine("* сохранить в файл OutPutDataFileTask7V5.txt.                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V5.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V5.txt";

            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Все латинские буквы из файла были удалены = " + pathSaveFile);
            Console.ReadKey();
        }
    }
}
