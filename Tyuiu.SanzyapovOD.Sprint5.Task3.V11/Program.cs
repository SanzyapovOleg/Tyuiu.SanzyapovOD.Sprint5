using Tyuiu.SanzyapovOD.Sprint5.Task3.V11.Lib;
namespace Tyuiu.SanzyapovOD.Sprint5.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Санзяпов О. Д. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнилa: Санзяпов Олег Дмитриевич| ИСТНб-24-1                         *");
            Console.WriteLine("* Дано выражение y = 4-x^3/ x^2, вычислить его значение при x = 3,        *");
            Console.WriteLine("* результат сохранить в бинарный файл OutPutFileTask3.bin и               *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            Console.WriteLine("X = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            double y = Math.Round((4 - Math.Pow(x, 3)) / (Math.Pow(x, 2)), 3);
            Console.WriteLine("y = " + y);
            Console.ReadLine();
        }
    }
}
