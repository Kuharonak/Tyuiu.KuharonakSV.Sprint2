using Tyuiu.KuharonakSV.Sprint2.Task0.V16.Lib;
namespace Tyuiu.KuharonakSV.Sprint2.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1025;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
