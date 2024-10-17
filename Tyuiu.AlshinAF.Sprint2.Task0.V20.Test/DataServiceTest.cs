using Tyuiu.AlshinAF.Sprint2.Task0.V20.Lib;
namespace Tyuiu.AlshinAF.Sprint2.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 16;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] {true, true, true, true, true, true};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}