﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AlshinAF.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y == 2 - x) || (((x >= 0) && (x <= 2) && (y <= 1) && (y >= 0)) || ((x <= (-2)) && (y >= 4))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;    
            
        }
    }
}
