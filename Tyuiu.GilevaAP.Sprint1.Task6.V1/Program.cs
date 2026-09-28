using Tyuiu.GilevaAP.Sprint1.Task6.V1.Lib;
namespace Tyuiu.GilevaAP.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Vedite symbol & nazmite <Enter>.");
            Console.WriteLine("dlya zavershenia vvedite tochku.");
            while (true)
            {
                Console.Write("->");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("please, symbol");
                    continue;
                }
                if (ds.IsDot(input))
                {
                    break;
                }
                string code = ds.SymbolCode(input);
                char c = input[0];
                Console.WriteLine($"Символ: {c} Код: {code}");
            }
        }
    }
}
