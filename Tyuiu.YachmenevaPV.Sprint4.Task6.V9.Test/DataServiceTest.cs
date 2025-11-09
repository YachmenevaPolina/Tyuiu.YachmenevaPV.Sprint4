using Tyuiu.YachmenevaPV.Sprint4.Task6.V9.Lib;
namespace Tyuiu.YachmenevaPV.Sprint4.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var colours = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };
            int res = ds.Calculate(colours);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
