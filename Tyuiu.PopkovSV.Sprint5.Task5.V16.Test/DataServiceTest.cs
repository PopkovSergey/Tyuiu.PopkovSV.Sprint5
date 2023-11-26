using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint5.Task5.V16.Lib;
using System.IO;

namespace Tyuiu.PopkovSV.Sprint5.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V16.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}