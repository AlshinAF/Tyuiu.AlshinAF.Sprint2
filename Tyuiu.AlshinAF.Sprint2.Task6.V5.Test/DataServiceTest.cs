using Tyuiu.AlshinAF.Sprint2.Task6.V5.Lib;
namespace Tyuiu.AlshinAF.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 11;
            string wait = "Валет";
            string res = ds.FindCardValue(x);
            Assert.AreEqual(wait, res);
        }
    }
}