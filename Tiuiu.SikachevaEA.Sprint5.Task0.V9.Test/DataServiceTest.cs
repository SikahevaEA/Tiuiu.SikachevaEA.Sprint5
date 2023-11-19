using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tiuiu.SikachevaEA.Sprint5.Task0.V9.Lib;

namespace Tiuiu.SikachevaEA.Sprint5.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckdeExistsFile()
        {
            string path = @"C:\Users\lizas\source\repos\Tiuiu.SikachevaEA.Sprint5\Tiuiu.SikachevaEA.Sprint5.Task0.V9\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
