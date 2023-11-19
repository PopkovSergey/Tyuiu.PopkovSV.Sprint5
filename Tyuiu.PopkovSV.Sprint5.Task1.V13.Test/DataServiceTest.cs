using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint5.Task1.V13.Lib;
using System.IO;

namespace Tyuiu.PopkovSV.Sprint5.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Zverek\source\repos\Tyuiu.PopkovSV.Sprint5\Tyuiu.PopkovSV.Sprint5.Task1.V13\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
