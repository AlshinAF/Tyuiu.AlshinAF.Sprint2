using Tyuiu.AlshinAF.Sprint2.Task5.V9.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Альшин А. Ф. | РППб-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема:  Логические операции                                              *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
        Console.WriteLine("* вычисляет требуемое значение и возвращает результат. Условие:           *");
        Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
        Console.WriteLine("* m(порядковый номер месяца) и n(число). По заданным n и m определить дату*");
        Console.WriteLine("* следующего дня (принять, что n и m не характеризуют 31 декабря).        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите номер месяца:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.FindDateOfNextDay(m, n);
        Console.WriteLine("Дата следующего дня " + res);

        Console.ReadKey();
    }
}