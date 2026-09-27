using Tyuiu.GilevaAP.Sprint1.Task4.V11.Lib;
namespace Tyuiu.GilevaAP.Sprint1.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
           DataService ds = new DataService();
            double x = 98.000;
            double y = 3.000;
            double wait = 0.078;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
