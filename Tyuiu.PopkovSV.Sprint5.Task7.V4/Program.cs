using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PopkovSV.Sprint5.Task7.V4.Lib;
using System.IO;

namespace Tyuiu.PopkovSV.Sprint5.Task7.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Попков С. В. | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Обработка текстовых файлов                                              *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Попков Сергей Вадимович | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:|DataSprint5|InPutDataFileTask7V4.txt в котором есть набор   *");
            Console.WriteLine("* символьных данных.Заменить все русские буквы на #.Полученный результат  *");
            Console.WriteLine("* сохранить в файл                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask7V4.txt";
            string res = File.ReadAllText(path);
            Console.WriteLine(res); Console.WriteLine("Файл находится тут: " + path);

            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");

            string w = DataService.LoadDataAndSave(path);
            Console.WriteLine("Cоздан!");
            Console.ReadKey();
        }
    }
}