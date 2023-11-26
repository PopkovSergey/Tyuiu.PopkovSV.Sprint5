using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PopkovSV.Sprint5.Task6.V26.Lib;
using System.IO;

namespace Tyuiu.PopkovSV.Sprint5.Task6.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Попков С. В. | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Обработка текстовых файлов                                              *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Попков Сергей Вадимович | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:|DataSprint5|InPutDataFileTask6V26.txt в котором есть набор  *");
            Console.WriteLine("* символьных данных.Найти количество знаков вопроса в заданной строке.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V26.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            double symbol = ds.LoadFromDataFile(path);
            Console.WriteLine("количество знаков вопроса в заданной строке равно " + symbol);
            Console.ReadLine();
        }
    }
}
