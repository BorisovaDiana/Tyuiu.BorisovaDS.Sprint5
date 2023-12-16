using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BorisovaDS.Sprint5.Task4.V3.Lib;

namespace Tyuiu.BorisovaDS.Sprint5.Task4.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Борисова Д.С.  | ИСТН-б-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Борисова Диана Сергеевна | ИСТН-б-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить до трёх    *");
            Console.WriteLine("* знаков после запятой) и вернуть полученный результат на консоль.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.BorisovaDS.Sprint5\Tyuiu.BorisovaDS.Sprint5.Task4.V3\InPutDataFileTask4V3.txt";
            Console.WriteLine("Данные находятся в файле " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
