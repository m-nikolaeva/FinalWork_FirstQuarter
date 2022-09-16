// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


Console.Write("Укажите количество элементов: "); //определяем длину массива
int a1 = Convert.ToInt32(Console.ReadLine());

string[] CreateArrayStr(int a) //метод заполнения массива с клавиатуры;
{
    string[] array = new string[a];
    for (int i = 0; i < a; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент:");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] FindElements(string[] array) // метод поиска элементов длина которых меньше, либо равна 3 символам
{
    string[] array1 = new string[array.Length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[index] = array[i];
            index++;
        }
    }
    return array1;
}

void PrintArray(string[] array) //метод для печати массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}


string[] arr = CreateArrayStr(a1);
Console.WriteLine();
PrintArray(arr);
Console.Write(" -> ");
string[] arr1 = FindElements(arr);
PrintArray(arr1);
