using Tyuiu.YachmenevaPV.Sprint4.Task7.V5.Lib;
{
    DataService ds = new DataService();

    int rows = 3;
    int colomns = 3;
    int[,] matrix = new int [rows, colomns];

    string str = "246813579";

    Console.Title = "Спринт #4 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #4                                                               *");
    Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
    Console.WriteLine("* Задание #7                                                              *");
    Console.WriteLine("* Вариант #5                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество четных чисел. *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    int index = 0;

    Console.WriteLine("\nМассив: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            Console.Write($"{str[index]} \t");
            index++;
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    int res = ds.Calculate(rows, colomns, str);

    Console.WriteLine("Количество чётных элементов = " + res);
    Console.ReadKey();
}