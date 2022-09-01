// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д

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
    foreach (var element in position)
        Console.Write($"{element} ");
    Console.WriteLine();
}
// Метод  перемножения элементов массива
//Решил попробовать из функции вернуть массив перемноженных элементов (записав его в новый массив) 
int[] MultiplicationElementMas(int[] mas, int LengthArray)
{
    //определяю длина массива четная или нет т.к. если нечет. средний элемент переписывается в новый массив не изменяясь
    int lengthmulti;
    if (LengthArray % 2 == 0)
    {
        lengthmulti = LengthArray / 2;
    }
    else
    {
        lengthmulti = LengthArray / 2 + 1;
    }
    int[] multiplikation = new int[lengthmulti];


    for (int i = 0; i < lengthmulti; i++)
    {
        if (i != (LengthArray - 1 - i))
        {
            multiplikation[i] = mas[i] * mas[LengthArray - 1 - i];//перемножаю первый и последний и т.д.
        }
        else
        {
             multiplikation[i] = mas[i];//если длина массива нечетная то средний элемент массива переписываем в новый массив не изменяя
        }
    };
    return multiplikation;
}
Console.Write("Введите длинну массива:");
int LengthArray = int.Parse(Console.ReadLine());
int[] array = new int[LengthArray];

RandomArrayElement(array, -10, 10);
PrintArray(array);
Console.WriteLine("Произведение первого и последнего элемента массива, второго и предпоследнего и т.д. :");
PrintArray(MultiplicationElementMas(array, LengthArray));

