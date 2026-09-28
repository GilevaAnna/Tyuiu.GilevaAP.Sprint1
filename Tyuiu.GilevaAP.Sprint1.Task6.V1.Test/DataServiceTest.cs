using Tyuiu.GilevaAP.Sprint1.Task6.V1.Lib;
namespace Tyuiu.GilevaAP.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            string res = ds.SymbolCode("1");
            Assert.AreEqual("Символ: 1 Код: 49", res);
        }
        public void ExampleA()
        {
            DataService ds = new DataService();
            string res = ds.SymbolCode("A");
            Assert.AreEqual("Символ: A Код: 65", res);
        }
        public void Example0()
        {
            DataService ds = new DataService();
            string res = ds.SymbolCode("");
            Assert.AreEqual("Error: 0 string", res);
        }
        public void ExampleABC()
        {
            DataService ds = new DataService();
            string res = ds.SymbolCode("ABC");
            Assert.AreEqual("Символ: A Код: 65", res);
        }
        public void ExampleDot()
        {
            DataService ds = new DataService();
            bool res = ds.IsDot("A");
            Assert.IsFalse(res);
        }
    }
}
