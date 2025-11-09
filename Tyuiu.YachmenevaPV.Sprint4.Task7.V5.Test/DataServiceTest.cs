using Tyuiu.YachmenevaPV.Sprint4.Task7.V5.Lib;
namespace Tyuiu.YachmenevaPV.Sprint4.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 3;
            int[,] matrix = new int[rows, columns];
            string str = "246813579";
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
