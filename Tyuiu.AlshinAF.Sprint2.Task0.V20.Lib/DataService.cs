﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AlshinAF.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x - 800 == y;
            res[1] = x - 800 != y;
            res[2] = x - 801 < y;
            res[3] = x - 802 > y;
            res[4] = x - 803 <= y;
            res[5] = x - 804 >= y;
            return res; 
        }
    }
}
