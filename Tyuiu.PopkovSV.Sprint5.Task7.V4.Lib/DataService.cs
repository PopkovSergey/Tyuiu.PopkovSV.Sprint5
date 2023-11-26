using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.PopkovSV.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string res = File.ReadAllText(path);
            char[] result = new char[res.Length];

            for (int i = 0; i < res.Length; i++)
            {
                char c = res[i];
                if ((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'))
                {
                    result[i] = '#';
                }
                else
                {
                    result[i] = c;
                }
            }
            using (StreamWriter writer = new StreamWriter(res))
            {
                writer.Write(result);
            }
            return path;
        }
    }
}