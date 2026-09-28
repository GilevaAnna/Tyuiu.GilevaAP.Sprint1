using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GilevaAP.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Error: 0 string";
            }
            char c = value[0];
            int code = (int)c;
            return $"Symbol: {c} Code: {code}";
        }
        public bool IsDot(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            return value[0] == '.';
        }
    }
}
