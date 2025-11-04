using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KuharonakSV.Sprint2.Task2.V17.Lib
{
    public class DataService : ISprint2Task2V17
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (y == 3 && ((3 <= x && x <= 5) || (9 <= x && x <= 12)) ||
                y == 4 && ((3 <= x && x <= 5) || (9 <= x && x <= 13)) ||
                y == 5 && (3 <= x && x <= 12)  ||
                y == 6 && (3 <= x && x <= 10)  ||
                y == 7 && (3 <= x && x <= 10)  ||
                y == 8 && ((6 <= x && x <= 7) || (x == 10)) ||
                y == 9 && ((6 <= x && x <= 7) || (x == 10)) ||
                y == 10 && ((6 <= x && x <= 7) || (10 <= x && x <= 12)) ||
                y == 11 && ((3 <= x && x <= 7) || (10 <= x && x <= 12)) ||
                y == 12 && ((x == 7) || (x == 10)))
                
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
