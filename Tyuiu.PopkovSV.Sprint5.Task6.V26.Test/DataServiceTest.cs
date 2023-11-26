using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint5.Task6.V26.Lib;
using System.IO;

namespace Tyuiu.PopkovSV.Sprint5.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V26.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V26.txt";

            DataService ds = new DataService();
            var res = ds.LoadFromDataFile(path);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}