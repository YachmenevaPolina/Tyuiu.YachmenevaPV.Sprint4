using Tyuiu.YachmenevaPV.Sprint4.Task2.V19.Lib;
{
    DataService ds = new DataService();
    Random rnd = new Random();
    Console.Title = "Спринт #4 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #4                                                               *");
    Console.WriteLine("* Тема: Одномерные массивы.                                               *");
    Console.WriteLine("* Задание #2                                                              *");
    Console.WriteLine("* Вариант #19                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Посчитать сумму нечетных элементов массива.                             *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Введите количество элементов массива: ");
    int len = Convert.ToInt32(Console.ReadLine());

    int[] numsArray = new int[len];

    for (int i = 0; i <= len - 1; i++) { numsArray[i] = rnd.Next(4, 9); }

    Console.WriteLine("Массив: ");
    for (int i = 0;i <= len - 1; i++) {Console.Write(numsArray[i] + "\t"); }

    Console.WriteLine();
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    int res = ds.Calculate(numsArray);

    Console.WriteLine("Сумма нечетных элементов = " + res);

    Console.ReadKey();
}