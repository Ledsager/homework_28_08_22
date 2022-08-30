// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// Метод для генерации значений элементов массива (с диапазоном от min до max)
void RandomArrayElement(int[] position, int min, int max)
{
    Random rand = new Random();
    int i = 0;
    while(i<position.Length)
    {
        position[i] = rand.Next(min,max);
        i++;
    }
}
// Метод для вывода на экран элементов массива
void PrintArray(int[] position)
{
    foreach(int element in position)
        Console.Write($"{element} ");
    Console.WriteLine();
}
// Метод подсчета элементов массива входящих в заданный диапазон
int CountElementInRange(int[] mas)
{
    int i = 0;
    foreach(int element in mas)// Можно сделать через цикл for
        if((element <= 99) && (element >= 10))
        {
            i++;
        };
    return i;
}
Console.Write("Введите длинну массива:");
int LengthArray = int.Parse(Console.ReadLine());
int[] array = new int[LengthArray];

RandomArrayElement(array, -200, 200);
PrintArray(array);
Console.WriteLine($"количество элементов массива в диапазоне [10,99] = {CountElementInRange(array)}");