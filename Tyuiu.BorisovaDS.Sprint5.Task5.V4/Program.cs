using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BorisovaDS.Sprint5.Task5.V4.Lib;

namespace Tyuiu.BorisovaDS.Sprint5.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Борисова Д.С. | ИСТН-б-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Борисова Диана Сергеевна | ИСТН-б-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\source\repos\\Tyuiu.BorisovaDS.Sprint5\\InPutDataFileTask5V4.txt Найти произведение   *");
            Console.WriteLine("* всех вещественных чисел в файле. Округлить до трёх знаков после запятой *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\source\repos\Tyuiu.BorisovaDS.Sprint5\InPutDataFileTask5V4.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.LoadFromDataFile(path));
            Console.ReadKey();
        }
    }
}
