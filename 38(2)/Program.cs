// Задача 3 из семинара: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {MinMaxDifferent(baseArray)}");


int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int MinMaxDifferent (int[] array)
{
    int result = 0;
    int min = 100000000;
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min) min = array [i];
        if (array[i]>max) max = array [i];
        result = max - min;
    }
        return result;
}