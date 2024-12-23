﻿using Tyuiu.AlshinAF.Sprint2.Task7.V12.Lib;
Console.Title = "Спринт #2 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #12                                                              *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на C#,которая запрашивает исходные данные(вещественные*");
Console.WriteLine("* значения) и вычисляет, находится ли точка с координатами X,Y            *");
Console.WriteLine("* в заштрихованной области.                                               *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(" Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Введите значение переменной Y: ");
double y = Convert.ToDouble(Console.ReadLine());
DataService ds = new DataService();
bool res = ds.CheckDotInShadedArea(x, y);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(res);
Console.ReadLine();