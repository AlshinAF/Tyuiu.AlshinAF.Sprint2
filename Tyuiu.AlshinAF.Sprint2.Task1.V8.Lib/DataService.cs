using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AlshinAF.Sprint2.Task1.V8.Lib
{
    public class DataService : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a + 1 == b)|(c + 1 < a);
            res[1] = (c + 1 != a)&(a>d);
            res[2] = (a>c)||(b!=d);
            res[3] = (c>=d)&&(a>d);
            res[4] = ((d>=b) == !(a!=c));
            res[5] = (a - 1 == c) ^ (b <= d);
            return res;
        }
    }
}
