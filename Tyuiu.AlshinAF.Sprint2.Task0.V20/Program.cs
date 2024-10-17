using Tyuiu.AlshinAF.Sprint2.Task0.V20.Lib;
namespace Tyuiu.AlshinAF.Sprint2.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1075;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 | Выполнил: Альшин А. Ф. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:  Операции сравнения                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность операций не должна нарушаться)                       *");
            Console.WriteLine("* и арифметических выражений,которая вернет логическую последовательность:*");
            Console.WriteLine("* (True,False,True,False,True,False), при x = 1075, y = 275               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}