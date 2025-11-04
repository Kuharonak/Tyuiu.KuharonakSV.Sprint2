using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KuharonakSV.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | (c == d);
            res[1] = (a <= b) & (d < c);
            res[2] = (c >= a) || (d > c);
            res[3] = (d > a) && (c == b);
            res[4] = !(!res[0]);
            res[5] = (a + 23 > b) ^ (d + 20 > c);
            return res;
            

        }
    }
}
