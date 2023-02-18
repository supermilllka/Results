/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3
символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []*/

string[] Array = {"hello", "2", "world", ":-)"};





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
