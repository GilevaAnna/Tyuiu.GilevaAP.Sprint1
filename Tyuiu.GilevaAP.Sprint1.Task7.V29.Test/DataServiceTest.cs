using Tyuiu.GilevaAP.Sprint1.Task7.V29.Lib;
namespace Tyuiu.GilevaAP.Sprint1.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 3;
            double wait = 2.985;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
