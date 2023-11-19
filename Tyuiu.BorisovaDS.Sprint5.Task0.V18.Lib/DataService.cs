using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BorisovaDS.Sprint5.Task0.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double y = x / (Math.Sqrt(Math.Pow(x, 2) + x));

            y = Math.Round(y, 3, MidpointRounding.AwayFromZero);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
