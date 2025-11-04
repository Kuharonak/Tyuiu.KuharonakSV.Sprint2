using Tyuiu.KuharonakSV.Sprint2.Task1.V26.Lib;
namespace Tyuiu.KuharonakSV.Sprint2.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetlogicOperations()
        {
            DataService ds = new DataService();
            int a = 654;
            int b = 671;
            int c = 874;
            int d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d); 
            bool[] wait = new bool[6] { true, true, true, false, true, false }; 
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
