using Tyuiu.YachmenevaPV.Sprint4.Task0.V1.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #4 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #4                                                               *");
    Console.WriteLine("* Тема: Одномерные массивы.                                               *");
    Console.WriteLine("* Задание #0                                                              *");
    Console.WriteLine("* Вариант #1                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Посчитать сумму четных элементов массива.                               *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("{6 ,4 ,3 ,2 ,1 ,0 ,9 ,8 ,7 ,5}");
    int[] Array = new int[] { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");
    int res = ds.GetSumEvenArrEl(Array);
    Console.WriteLine(res);
    Console.ReadKey();
}