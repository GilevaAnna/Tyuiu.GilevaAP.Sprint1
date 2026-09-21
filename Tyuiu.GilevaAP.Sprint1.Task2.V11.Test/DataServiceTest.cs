using Tyuiu.GilevaAP.Sprint1.Task2.V11.Lib;
namespace Tyuiu.GilevaAP.Sprint1.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            int value = 3;
            int valueTwo = 45;
            var res = ds.ConvertHoursMinutesToSeconds(value, valueTwo);
            Assert.AreEqual(13500, res);
        }
    }
}
