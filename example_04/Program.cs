// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Метод для генерации значений элементов массива (с диапазоном от min до max)
void RandomArrayElement(double[] position, int min, int max)
{
    Random rand = new Random();
    int i = 0;
    while (i < position.Length)
    {
        position[i] = Convert.ToDouble(rand.Next(min, max) / 10.0);
        i++;
    }
}
// Метод для вывода на экран элементов массива
void PrintArray(double[] position)
{
    foreach (var element in position)
        Console.Write($"{element} ");
    Console.WriteLine();
}
// Вывод на экран разницы между макс и мин
void SubtractionMaxMin(double a, double b)
{

    Console.WriteLine($"разница между макс и мин элементами массива равна : {Math.Round((a - b), 2)}");
}
// Метод поиска мин и макс элементов в массиве
void CountMaxMinElementInArray(double[] mas)
{
    double max = mas[0];
    double minimum = mas[0];

    for (int i = 0; i < mas.Length; i++)
    {
        if (minimum > mas[i])
        {
            minimum = mas[i];
        }
        if (max < mas[i])
        {
            max = mas[i];
        }

    }
    SubtractionMaxMin(max, minimum);
}
Console.Write("Введите длинну массива:");
int LengthArray = int.Parse(Console.ReadLine());
double[] array = new double[LengthArray];

RandomArrayElement(array, -100, 200);
PrintArray(array);
CountMaxMinElementInArray(array);