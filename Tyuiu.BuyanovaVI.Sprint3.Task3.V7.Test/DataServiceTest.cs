using Tyuiu.BuyanovaVI.Sprint3.Task3.V7.Lib;

namespace Tyuiu.BuyanovaVI.Sprint3.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string res = ds.ReplaceCharOnNum("gft hggt ntg", 'g', '4');

            Assert.AreEqual("4ft h44t nt4", res);
        }
    }
}