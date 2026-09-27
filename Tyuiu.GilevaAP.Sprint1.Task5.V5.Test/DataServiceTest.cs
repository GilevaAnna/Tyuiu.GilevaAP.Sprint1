using Tyuiu.GilevaAP.Sprint1.Task5.V5.Lib;
namespace Tyuiu.GilevaAP.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int res = ds.Calculate(x);
            int wait = 5;
            Assert.AreEqual(res, wait);
        }
    }
}
