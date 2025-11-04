using Tyuiu.YachmenevaPV.Sprint4.Task0.V1.Lib;
namespace Tyuiu.YachmenevaPV.Sprint4.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            int res = ds.GetSumEvenArrEl(numsArray);

            int wait = 20;
            Assert.AreEqual(wait, res);
        }
    }
}
