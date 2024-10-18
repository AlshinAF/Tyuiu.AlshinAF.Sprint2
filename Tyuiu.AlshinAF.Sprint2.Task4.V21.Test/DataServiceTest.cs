using Tyuiu.AlshinAF.Sprint2.Task4.V21.Lib;
namespace Tyuiu.AlshinAF.Sprint2.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double wait = 256;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 0.643;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}