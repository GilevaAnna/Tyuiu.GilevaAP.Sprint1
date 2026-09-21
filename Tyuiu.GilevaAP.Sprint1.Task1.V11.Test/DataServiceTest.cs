using Tyuiu.GilevaAP.Sprint1.Task1.V11.Lib;
namespace Tyuiu.GilevaAP.Sprint1.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            double x = 6.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5, res);
        }
    }
}
