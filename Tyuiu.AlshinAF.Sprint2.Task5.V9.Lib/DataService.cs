using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AlshinAF.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            switch (m)
            {
                case 1:
                    if (n < 30)
                    {
                        n++;
                    }
                    else
                    {
                        m++;
                        n = 1;
                    }
                    break;
                case 2:
                    if ((n + 1) % 4 == 0 && (n + 1 != 29 || m % 4 != 0))
                    { // проверка високосного года
                        if (n == 28)
                        {
                            m++;
                            n = 1;
                        }
                        else if (n <= 27)
                        {
                            n++;
                        }
                    }
                    else
                    {
                        if (n == 28)
                        {
                            n = 1;
                        }
                        else
                        {
                            n++;
                        }
                    }
                    break;
                case 3:
                    if (n < 31)
                    {
                        n++;
                    }
                    else
                    {
                        m++;
                        n = 1;
                    }
                    break;
                case 4:
                    if (n < 30)
                    {
                        n++;
                    }
                    else
                    {
                        m++;
                        n = 1;
                    }
                    break;
                case 5:
                    if (n < 31)
                    {
                        n++;
                    }
                    else
                    {
                        m++;
                        n = 1;
                    }
                    break;
                case 6:
                    if (n < 30)
                    {
                        n++;
                    }
                    else
                    {
                        m++;
                        n = 1;
                    }
                    break;
                case 7:
                    if (n < 31)
                    {
                        n++;
                    }
                    else
                    {
                        m++;

                    }
             return "1";
            }


        }
    }
}
