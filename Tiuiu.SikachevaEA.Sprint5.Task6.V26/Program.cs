using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tiuiu.SikachevaEA.Sprint5.Task6.V26.Lib;

namespace Tiuiu.SikachevaEA.Sprint5.Task6.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V26.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
