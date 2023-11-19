using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint5.Task0.V14.Lib;
using System.IO;

namespace Tyuiu.PopkovSV.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Zverek\source\repos\Tyuiu.PopkovSV.Sprint5\Tyuiu.PopkovSV.Sprint5.Task0.V14\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileI = new FileInfo(path);
            bool fileE = fileI.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileE);
        }
    }
}
