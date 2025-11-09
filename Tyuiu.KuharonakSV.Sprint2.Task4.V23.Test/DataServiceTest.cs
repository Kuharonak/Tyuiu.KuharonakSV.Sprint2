using Tyuiu.KuharonakSV.Sprint2.Task4.V23.Lib;
namespace Tyuiu.KuharonakSV.Sprint2.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds  = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 4;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }
    }
}
