using Tyuiu.YachmenevaPV.Sprint4.Task4.V24.Lib;
namespace Tyuiu.YachmenevaPV.Sprint4.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas = { { 7, 9, 7, 6, 7 }, { 9, 9, 8, 6, 7 }, { 8, 6, 5, 6, 7 }, { 9, 9, 7, 8, 7 }, { 5, 9, 9, 8, 9 } };
            int [,] res = ds.Calculate(mas);
            int[,] wait = { { 7, 9, 7, 1, 7 }, { 9, 9, 1, 1, 7 }, { 1, 1, 5, 1, 7 }, { 9, 9, 7, 1, 7 }, { 5, 9, 9, 1, 9 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
