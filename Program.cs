﻿/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо 
равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */
System.Console.WriteLine("Введите количество элементов массива");
int n = Int32.Parse(System.Console.ReadLine());

// void CreatingArray (int n)
// {
string [] array = new string [n];
for (int i = 0; i < n; i++)
{
    array [i] = System.Console.ReadLine();
}
// }

// void PrintArray (string [] array)
// {
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
// }

// string arr[] = CreatingArray (n);
// PrintArray (arr);
