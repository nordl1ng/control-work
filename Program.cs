/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо 
равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */

System.Console.WriteLine("Введите количество элементов массива");
int n = Int32.Parse(System.Console.ReadLine());

string[] CreatingArray(int n)
{
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine($"Введите элемент массива {i + 1}");
        array[i] = System.Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write(String.Join(", ", array));
}
string[] arr = CreatingArray(n);
System.Console.WriteLine("Созданный масив:");
PrintArray(arr);
System.Console.WriteLine();
string [] FormingArray(string[] arr, int m)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= m)
        {
            count++;
        }
    }
    string[] arraysort = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= m)
        {
            arraysort[j] = arr[i];
            j++;
        }
    }
return arraysort;
}
System.Console.WriteLine("Введите максимальную длину элементов массива, которые необходимо вывести");
int m = Int32.Parse(System.Console.ReadLine());
string[] arr2 = FormingArray(arr,m);
System.Console.WriteLine($"Новый массив:");
PrintArray(arr2);