// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.WriteLine("Данный код покажет количество четных чисел в массиве");
int size = Imput("Введите количество элементов в массиве: ");
int[] Arr = GetRandomArray(size);
Console.WriteLine(String.Join(",", Arr));
Console.WriteLine($"Количество четных чисел в данном массиве - {EvSum(Arr)}");

int EvSum(int[] array)
{
    int result = 0;
    foreach (int el in array)
    {
        result += el%2 != 0 ? 0 : 1;
    }
    return result;
}

int Imput(string smth)
{
    Console.WriteLine(smth);
    int res = int.Parse(Console.ReadLine());
    return res;
}

int[] GetRandomArray(int size)
{
    int[] res = new int [size];
    for (int i=0; i<size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}




