// Определить, присутствует ли в заданном массиве, некоторое число

bool FindNumberInArray(int[] mas, int number)
{
    int i;
    bool result = false;
    for (i = 0; i < mas.Length; i++)
    {
        if (mas[i] == number)
        {
            result = true;
        }
    }
    return result;
}
int NumberEntry()// Функция ввода числа
{
    int Number;
    while (!int.TryParse(Console.ReadLine(), out Number))//проверка что вводится число
        Console.Write("Неверный ввод! \nВведите число n: ");
    return Number;
}
Console.WriteLine("Введите число n, которое надо найти в массиве: ");
int n = NumberEntry();
int[] array = { 1, 2, 3, 4, 5, 2, 7, 8, 9 };
if (FindNumberInArray(array, n) == true)
{
    Console.WriteLine($"Число {n} входит в массив");
}
else
{
    Console.WriteLine($"Число {n} не входит в массив");
}