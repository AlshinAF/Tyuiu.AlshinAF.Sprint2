using Tyuiu.AlshinAF.Sprint2.Task6.V5.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Альшин А. Ф. | РППб-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема:  Логические операции                                              *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
        Console.WriteLine("* вычисляет требуемое значение и возвращает результат. Условие:           *");
        Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера          *");
        Console.WriteLine("* в зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — *");
        Console.WriteLine("* 13, «тузу» — 14. По заданному номеру карты k (6 <=k <= 14)              *");
        Console.WriteLine("* определить достоинство соответствующей карты.                           *");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите номер карты:");
        int v = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.FindCardValue(v);
        Console.WriteLine("Достоинство карты - " + res);

        Console.ReadKey();
    }
}