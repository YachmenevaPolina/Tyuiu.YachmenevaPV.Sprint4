using Tyuiu.YachmenevaPV.Sprint4.Task6.V9.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #4 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #4                                                               *");
    Console.WriteLine("* Тема: Class Array.                                                      *");
    Console.WriteLine("* Задание #6                                                              *");
    Console.WriteLine("* Вариант #9                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Подсчитать количество элементов, длина которых меньше 7.                *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    var colours = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };

    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i <= colours.Length - 1; i++) {  Console.WriteLine(colours[i]); }

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");
    
    Console.WriteLine("Количество элементов, длина которых < 7: ");
    int res = ds.Calculate(colours);
    Console.WriteLine(res);
    Console.ReadKey();
}