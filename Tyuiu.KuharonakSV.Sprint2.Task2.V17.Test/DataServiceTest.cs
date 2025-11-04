using Tyuiu.KuharonakSV.Sprint2.Task2.V17.Lib;
namespace Tyuiu.KuharonakSV.Sprint2.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 5;
            int y =4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);


        }
    }
}
