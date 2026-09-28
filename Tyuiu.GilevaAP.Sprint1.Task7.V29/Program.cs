using Tyuiu.GilevaAP.Sprint1.Task7.V29.Lib;

namespace Tyuiu.GilevaAP.Sprint1.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, y;
            Console.WriteLine("* Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
