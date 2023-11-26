using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BorisovaDS.Sprint5.Task6.V3.Lib;


namespace Tyuiu.BorisovaDS.Sprint5.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Борисова Д.С. | ИСТН-б-23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                           *");
            Console.WriteLine("* Задание #6                                                                 *");
            Console.WriteLine("* Вариант #3                                                                 *");
            Console.WriteLine("* Выполнила: Борисова Диана Сергеевна | ИСТН-б-23-1                          *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask6V3.txt в котором есть набор      *");
            Console.WriteLine("* символьных данных. Найти количество латинских букв в заданной строке.      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask6V3.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Количество латинских букв в заданной строке: {res}");
            Console.ReadKey();
        }
    }
}
