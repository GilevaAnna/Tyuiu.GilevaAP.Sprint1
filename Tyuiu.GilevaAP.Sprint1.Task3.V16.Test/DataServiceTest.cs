using Tyuiu.GilevaAP.Sprint1.Task3.V16.Lib;
namespace Tyuiu.GilevaAP.Sprint1.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            double x1 = 2;
            double x2 = 3;
            double wait = -5.00;
            var res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(wait, res);
        }
    }
}
