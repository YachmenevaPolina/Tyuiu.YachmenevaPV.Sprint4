using Tyuiu.YachmenevaPV.Sprint4.Task1.V1.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #4 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #4                                                               *");
    Console.WriteLine("* Тема: Одномерные массивы.                                               *");
    Console.WriteLine("* Задание #1                                                              *");
    Console.WriteLine("* Вариант #1                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Посчитать сумму четных элементов массива.                               *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    int len;
    Console.WriteLine("Введите количество элементов массива:  ");
    len = Convert.ToInt32(Console.ReadLine());

    int[] numsArray = new int[len];
    for (int i = 0; i <= len - 1; i++)
    {
        Console.WriteLine("Введите значение " + "элементов массива: ");
        numsArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine("Массив: ");
    for  (int i = 0; i <= len - 1; i++)
    {
        Console.WriteLine(numsArray[i] + "\t");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    int res = ds.Calculate(numsArray);

    Console.WriteLine(res);
    Console.ReadKey();
}