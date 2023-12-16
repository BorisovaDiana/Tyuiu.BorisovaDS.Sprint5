using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BorisovaDS.Sprint5.Task4.V3.Lib
{
    public class DataService : ISprint5Task4V3
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round(((Math.Sin(Convert.ToDouble(strX)) + 4) / (Convert.ToDouble(strX))) - 1.25 * Convert.ToDouble(strX), 3);
            return res;
        }
    }
}
