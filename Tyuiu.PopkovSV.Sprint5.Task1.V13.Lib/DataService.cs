using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.PopkovSV.Sprint5.Task1.V13.Lib
{
    public class DataService : ISprint5Task1V13
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExits = fileInfo.Exists;

            if (fileExits)
            {
                File.Delete(path);
            }

            double y;
            string str;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((2 * x - 3) / (Math.Cos(x) + x) + 5, 2);

                if (double.IsInfinity(y) || double.IsNaN(y))
                {
                    y = 0;
                }

                str = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }

            return path;
        }
    }
}