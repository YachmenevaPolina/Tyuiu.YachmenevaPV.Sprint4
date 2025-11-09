using Tyuiu.YachmenevaPV.Sprint4.Task5.V21.Lib;
{
    DataService ds = new DataService();
    Random rnd = new Random();
    Console.Title = "Спринт #4 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #4                                                               *");
    Console.WriteLine("* Тема: Двумерные массивы.                                                *");
    Console.WriteLine("* Задание #5                                                              *");
    Console.WriteLine("* Вариант #21                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Заменить положительные элементы большие  массива на 1.                  *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Введите количество строк в массиве: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов в массиве: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, columns];

    Console.WriteLine("***************************************************************************");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(-8, 2);
        }
    }
    Console.WriteLine("\nМассив: ");
    for (int i = 0; i < rows;  ++i)
    {
        for (int j = 0; j < columns;  ++j)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine("\r");
    }
    Console.WriteLine();
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    int [,] res = ds.Calculate(matrix);

    int rowss = res.GetUpperBound(0) + 1;
    int columnss = res.Length / rowss;
    for (int i = 0; i < rowss; i++)
    {
        for (int j = 0; j < columnss; j++)
        {
            Console.Write($"{res[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.ReadKey();
}