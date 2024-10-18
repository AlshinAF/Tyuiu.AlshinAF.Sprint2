using Tyuiu.AlshinAF.Sprint2.Task5.V9.Lib;
namespace Tyuiu.AlshinAF.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("январь", ds.FindDateOfNextDay(1));
        }
    }
}