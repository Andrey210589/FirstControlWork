// Написать программу,
// которая из имеющегося массива строк
// формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] CreateStringArray(int size) // Создаем массив строк, размером size. Строки вводятся с клавиатуры.
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Input string No: " + (i + 1));
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array) //Вывод массива
{
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i] + " ");
    }
    Console.Write(" }");
    Console.WriteLine();
}