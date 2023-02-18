/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3
символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []*/

string[] Array = {"hello", "2", "world", ":-)"};

PrintArray(Array);
string[] array = CreateArray(Array);
PrintArray(array);


string[] CreateArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            count++;
    }

    string[] arr1 = new string[count];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr1[index] = arr[i];
            index++;
        }
    }

    return arr1;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ",");
        else
            Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}
