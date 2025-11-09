using Tyuiu.KuharonakSV.Sprint2.Task5.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Кухаронак С. В | СМАРТБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* спринт #2                                                               *");
        Console.WriteLine("* Тема : Оператор Swith                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Кухаронак Сергей Витальевич | СМАРТБ-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу которая вычисляет месяц                              *");
        Console.WriteLine("* Тернарного оператора                                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите номер месяца: ");
        int numMouth = Convert.ToInt32(Console.ReadLine());

        string res;

        if ((numMouth < 0) || (numMouth > 12))
        {
            res = "Введение неверное значение!";
        }
        else
        {
            int startYear = Convert.ToInt32(Console.ReadLine());
            res = "Это месяц: " + ds.FindMonthName(startYear, numMouth);




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
}