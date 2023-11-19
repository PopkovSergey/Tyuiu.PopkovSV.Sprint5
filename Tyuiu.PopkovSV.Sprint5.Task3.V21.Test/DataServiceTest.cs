using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint5.Task3.V21.Lib;
using System.IO;

namespace Tyuiu.PopkovSV.Sprint5.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = $@"C:\Users\Zverek\source\repos\Tyuiu.PopkovSV.Sprint5\Tyuiu.PopkovSV.Sprint5.Task3.V21\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
