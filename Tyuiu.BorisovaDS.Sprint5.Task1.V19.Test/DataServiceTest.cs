using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BorisovaDS.Sprint5.Task1.V19.Lib;

namespace Tyuiu.BorisovaDS.Sprint5.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = $@"C:\Users\User\source\repos\Tyuiu.BorisovaDS.Sprint5\Tyuiu.BorisovaDS.Sprint5.Task1.V19\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
