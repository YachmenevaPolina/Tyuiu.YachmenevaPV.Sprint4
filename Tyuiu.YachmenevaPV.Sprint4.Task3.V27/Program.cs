using Tyuiu.YachmenevaPV.Sprint4.Task3.V27.Lib;
{
    DataService ds = new DataService();

    int[,] array = { { 4, 3, 5, 5, 3 }, { 6, 7, 4, 4, 3 }, { 3, 3, 7, 3, 6 }, { 3, 4, 3, 7, 7 }, { 3, 5, 6, 3, 6 } };
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;

    Console.Title = "Спринт #4 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #4                                                               *");
    Console.WriteLine("* Тема: Двумерные массивы.                                                *");
    Console.WriteLine("* Задание #3                                                              *");
    Console.WriteLine("* Вариант #27                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Посчитать количество четных элементов массива.                          *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Массив: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} \t");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");
    int res = ds.Calculate(array);

    Console.WriteLine("Количество четных элементов массива = " + res);
    Console.ReadKey();
}