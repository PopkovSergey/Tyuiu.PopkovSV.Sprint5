using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PopkovSV.Sprint5.Task1.V13.Lib;

namespace Tyuiu.PopkovSV.Sprint5.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Попков С. В. | ИСТНб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Класс File. Запись данных в текстовый файл                                   *");
            Console.WriteLine("* Задание #1                                                                   *");
            Console.WriteLine("* Вариант #13                                                                  *");
            Console.WriteLine("* Выполнил: Попков Сергей Вадимович | ИСТНб-23-1                               *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дана функция f(x) = 2x - 3/cos(x) + x + 5  (произвести                       *");
            Console.WriteLine("* табулирование) f(x) на заданном диапозоне [-5;5] с шагом 1. Произвести       *");
            Console.WriteLine("* проверку деления на ноль. При делении на ноль вернуть значение 0.            *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на        *");
            Console.WriteLine("* консоль в таблицу. Значения округлить до двух знаков после запятой.          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Стартовое значение = " + startValue);
            Console.WriteLine("Конечное значение = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                valueArray[count] = Math.Round((2 * x - 3) / (Math.Cos(x) + x) + 5, 2);
                count++;
            }

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1,6:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadLine();
        }
    }
}