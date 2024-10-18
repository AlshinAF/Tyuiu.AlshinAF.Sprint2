using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AlshinAF.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            string res;
            switch (m)
            {
                case 1:
                    res = "Январь";
                    break;
                case 2:
                    res = "Февраль";
                    break;
                case 3:
                    res = "Март";
                    break;
                case 4:
                    res = "Апрель";
                    break;
                case 5:
                    res = "Май";
                    break;
                case 6:
                    res = "Июнь";
                    break;
                case 7:
                    res = "Июль";
                    break;
                case 8:
                    res = "Август";
                    break;
                case 9:
                    res = "Сентябрь";
                    break;
                case 10:
                    res = "Октябрь";
                    break;
                case 11:
                    res = "Ноябрь";
                    break;
                case 12:
                    res = "Декабрь";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                    break;
            }
            switch (n)
            {
                case 1:
                    n++;
                    break;
                case 2:
                    n++;
                    break;
                case 3:
                    n++;
                    break;
                case 4:
                    n++;
                    break;
                case 5:
                    n++;
                    break;
                case 6:
                    n++;
                    break;
                case 7:
                    n++;
                    break;
                case 8:
                    n++;
                    break;
                case 9:
                    n++;
                    break;
                case 10:
                    n++;
                    break;
                case 11:
                    n++;
                    break;
                case 12:
                    n++;
                    break;
                case 13:
                    n++;
                    break;
                case 14:
                    n++;
                    break;
                case 15:
                    n++;
                    break;
                case 16:
                    n++;
                    break;
                case 17:
                    n++;
                    break;
                case 18:
                    n++;
                    break;
                case 19:
                    n++;
                    break;
                case 20:
                    n++;
                    break;
                case 21:
                    n++;
                    break;
                case 22:
                    n++;
                    break;
                case 23:
                    n++;
                    break;
                case 24:
                    n++;
                    break;
                case 25:
                    n++;
                    break;
                case 26:
                    n++;
                    break;
                case 27:
                    n++;
                    break;
                case 28:
                    if (m == 2)
                    {
                        m++;
                        n = 1;
                    }
                    else
                        n++;
                    break;
                case 29:
                    n++;
                    break;
                case 30:
                    if ((m == 4) || (m == 6) || (m == 9) || (m == 11))
                    {
                        m++;
                        n = 1;
                    }
                    else
                        n++;
                    break;
                case 31:
                    m++;
                    n = 1;
                    break;
                default:
                    throw new ArgumentException($"День должен быть от 1 до 31. Значение {n}");
                    break;
            }
            switch (m)
            {
                case 1:
                    res = "Январь " + n.ToString(); ;
                    break;
                case 2:
                    res = "Февраль " + n.ToString(); ;
                    break;
                case 3:
                    res = "Март " + n.ToString(); ;
                    break;
                case 4:
                    res = "Апрель " + n.ToString(); ;
                    break;
                case 5:
                    res = "Май " + n.ToString(); ;
                    break;
                case 6:
                    res = "Июнь " + n.ToString(); ;
                    break;
                case 7:
                    res = "Июль " + n.ToString(); ;
                    break;
                case 8:
                    res = "Август " + n.ToString(); ;
                    break;
                case 9:
                    res = "Сентябрь " + n.ToString(); ;
                    break;
                case 10:
                    res = "Октябрь " + n.ToString(); ;
                    break;
                case 11:
                    res = "Ноябрь " + n.ToString(); ;
                    break;
                case 12:
                    res = "Декабрь " + n.ToString();
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }
            return res;
        }
                    

            


    }
}

