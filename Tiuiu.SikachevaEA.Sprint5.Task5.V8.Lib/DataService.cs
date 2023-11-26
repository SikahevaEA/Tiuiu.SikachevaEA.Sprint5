using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tiuiu.SikachevaEA.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                double res = int.MaxValue;
                double min = int.MaxValue;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double temp = Convert.ToDouble(line);
                    if ((temp <= min) && (temp % 2 != 0))
                    {
                        min = double.Parse(line);
                        res = double.Parse(line);
                    }
                }
                return res;
            }
        }
    }
}
