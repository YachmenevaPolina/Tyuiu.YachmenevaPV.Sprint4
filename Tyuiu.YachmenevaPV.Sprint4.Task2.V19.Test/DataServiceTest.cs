using Tyuiu.YachmenevaPV.Sprint4.Task2.V19.Lib;
namespace Tyuiu.YachmenevaPV.Sprint4.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 5, 6, 7, 7, 8, 9, 6, 5, 4, 8, 7, 6, 5 };
            int res = ds.Calculate(numsArray);
            int wait = 45;

            Assert.AreEqual(wait, res);
        }
    }
}
