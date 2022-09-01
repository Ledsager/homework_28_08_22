// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Метод для генерации значений элементов массива (с диапазоном от min до max)
void RandomArrayElement(int[] position, int min, int max)
{
    Random rand = new Random();
    int i = 0;
    while (i < position.Length)
    {
        position[i] = rand.Next(min, max);
        i++;
    }
}
// Метод для вывода на экран элементов массива
void PrintArray(int[] position)
{
    foreach (int element in position)
        Console.Write($"{element} ");
    Console.WriteLine();
}
// Вывод на экран разницы между макс и мин
void SubtractionMaxMin(int a, int b)
{
    Console.WriteLine($"разница между макс и мин элементами массива равна : {a - b}");
}
// Метод поиска мин и макс элементов в массиве
void CountMaxMinElementInArray(int[] mas)
{
    int max = mas[0];
    int minimum = mas[0];

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
int[] array = new int[LengthArray];

RandomArrayElement(array, 0, 20);
PrintArray(array);
CountMaxMinElementInArray(array);