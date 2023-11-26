using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tiuiu.SikachevaEA.Sprint5.Task6.V26.Lib;

namespace Tiuiu.SikachevaEA.Sprint5.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V26.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V26.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
