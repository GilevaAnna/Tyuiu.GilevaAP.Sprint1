using Microsoft.CodeCoverage.Core.Reports.Cobertura;
using Tyuiu.GilevaAP.Sprint1.Task0.V1.Lib;
namespace Tyuiu.GilevaAP.Sprint1.Task0.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-6, res);
        }
    }
}
