using Tyuiu.AlshinAF.Sprint2.Task7.V12.Lib;
namespace Tyuiu.AlshinAF.Sprint2.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.1;
            double y = 0;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false ;
            Assert.AreEqual(wait, res);
        }
    }
}