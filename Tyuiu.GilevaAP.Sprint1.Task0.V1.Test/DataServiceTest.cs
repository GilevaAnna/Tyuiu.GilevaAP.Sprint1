using Tyuiu.GilevaAP.Sprint1.Task0.V1.Lib;
namespace Tyuiu.GilevaAP.Sprint1.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-6, res);
        }
    }
}
