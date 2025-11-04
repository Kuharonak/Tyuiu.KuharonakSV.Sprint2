using Tyuiu.KuharonakSV.Sprint2.Task2.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2  |  Выполнил: Кухаронак С. В.  |  СМАРТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор if.                                                      *");
        Console.WriteLine("* Задание: #2                                                             *");
        Console.WriteLine("* Вариант: #17                                                            *");
        Console.WriteLine("* Выполнил: Кухаронак Сергей Витальевич | СМАРТБ-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и   *");
        Console.WriteLine("* вычисляет находится ли точка с координатами x,y в заштрихованной области *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Введите значение переменной x : ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Введите значение переменной y : ");
        int y = Convert.ToInt32(Console.ReadLine());
        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*  РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится вне заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        Console.ReadKey();
    }
}