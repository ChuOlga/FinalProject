//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.


string[] CreateArray(int size)
{
    string[] array = new string[size]; 
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Input array: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] GetShortStrings(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
        count++;
        }
    }
    
    string[] resultArray = new string[count];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
     
    }
    return resultArray;
}
Console.WriteLine("Input the size of array: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateArray(n);
Console.WriteLine("Input array: ");
ShowArray(myArray);

Console.WriteLine("Selected new array: ");
string [] newArray = GetShortStrings(myArray);
ShowArray(newArray);

