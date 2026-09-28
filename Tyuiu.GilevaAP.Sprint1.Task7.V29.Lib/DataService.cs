using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GilevaAP.Sprint1.Task7.V29.Lib
{
    public class DataService : ISprint1Task7V29
    {
        public double Calculate(double x, double y)
        {
            var x3 = Math.Pow(x, 3);
            var x5 = Math.Pow(x, 5);
            var res = (x-(Math.Cos(x3) / (x * y - 3))+(Math.Sin(x5)/(x*y+5)));
            return Math.Round(res, 3);
        }
    }
}
