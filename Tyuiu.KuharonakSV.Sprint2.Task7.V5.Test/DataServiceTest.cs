using Tyuiu.KuharonakSV.Sprint2.Task7.V5.Lib;
namespace Tyuiu.KuharonakSV.Sprint2.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            

            DataService ds = new DataService();
            double x = -0.4;
            double y = 0.4;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
