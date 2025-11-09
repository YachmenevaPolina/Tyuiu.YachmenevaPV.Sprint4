using Tyuiu.YachmenevaPV.Sprint4.Task5.V21.Lib;
namespace Tyuiu.YachmenevaPV.Sprint4.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas = { { -8, 0, 2, -4, 1 }, { -6, -2, 0, 1, 2}, { -7, -3, -4, 0, 1}, { 0, 2, -3, -1, 0}, { -6, -4, -3, -5, -1}  };
            int[,] res = ds.Calculate(mas);
            int[,] wait = { { -8, 0, 1, -4, 1 }, { -6, -2, 0, 1, 1 }, { -7, -3, -4, 0, 1 }, { 0, 1, -3, -1, 0 }, { -6, -4, -3, -5, -1 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
