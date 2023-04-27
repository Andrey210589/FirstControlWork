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
string[] CreateNewArrayFromThreeCharString(string[] array)// Создание массива состоящего из строк с 3 и меньше символами
{
    string s = string.Empty;
    int count = 0;
    string[] resultArray = new string[count];
    string[] tempArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        s = array[i];
        if (s.Length <= 3)
        {
            // Console.WriteLine("count"+ count+"= "+ s);
            tempArray[count] = s;
            count++;
            resultArray = new string[count];
        }
    }
    for (int j = 0; j < count; j++)
    {
        resultArray[j] = tempArray[j];
    }
    return resultArray;
}
Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] newArray = CreateStringArray(size);
ShowArray(newArray);
string[] result = CreateNewArrayFromThreeCharString(newArray);
Console.WriteLine("Result array is: ");
ShowArray(result);