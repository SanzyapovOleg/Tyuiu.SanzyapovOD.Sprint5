﻿using Tyuiu.SanzyapovOD.Sprint5.Task1.V25.Lib;
namespace Tyuiu.SanzyapovOD.Sprint5.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Санзяпов О. Д. | ИСТНб-24-1";
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                          *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                                                            *");
            Console.WriteLine("* Задание #1                                                                                                         *");
            Console.WriteLine("* Вариант #25                                                                                                        *");
            Console.WriteLine("* Выполнил: Санзяпов Олег Дмитриевич| ИСТНб-24-1                                                                     *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Дана функция, f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку на ноль вернуть значение 0.        *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль втаблицу.                           * ");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                                                                  * ");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
