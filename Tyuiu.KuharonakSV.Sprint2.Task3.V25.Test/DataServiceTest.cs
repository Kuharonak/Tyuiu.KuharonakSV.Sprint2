using Tyuiu.KuharonakSV.Sprint2.Task3.V25.Lib;
namespace Tyuiu.KuharonakSV.Sprint2.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 9.751;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.333;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 1;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -30;
            double res = ds.Calculate(x);
            double wait = -3;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}
