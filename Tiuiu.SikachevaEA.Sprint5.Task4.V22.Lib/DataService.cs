using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tiuiu.SikachevaEA.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double res = Math.Round(Math.Pow(Convert.ToDouble(strx), 3) * Math.Sin(Convert.ToDouble(strx)) - 4 * Convert.ToDouble(strx), 3);
            return res;
        }
    }
}
