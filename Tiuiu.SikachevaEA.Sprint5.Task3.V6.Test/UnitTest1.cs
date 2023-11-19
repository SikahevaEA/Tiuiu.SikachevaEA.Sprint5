using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tiuiu.SikachevaEA.Sprint5.Task3.V6.Lib;

namespace Tiuiu.SikachevaEA.Sprint5.Task3.V6.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\lizas\source\repos\Tiuiu.SikachevaEA.Sprint5\Tiuiu.SikachevaEA.Sprint5.Task3.V6\bin\Debug\OutPutFileTask0.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
