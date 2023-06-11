// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int Imput(string smth)
{
    Console.WriteLine(smth);
    int A = int.Parse(Console.ReadLine());
    return A;
}

int[] GetRandomArray(int size, int min, int max)
{
    int[] res = new int [size];
    for (int i=0; i<size; i++)
    {
        res[i] = new Random().Next(min, max +1);
    }
    return res;
}

 int EvIndexSum(int[] array)
 {
    int result = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        result += array[i];
    }
    return result;
 }

Console.Clear();
 int lenght = Imput("Введите количество элементов массива: ");
 int min = Imput("Введите минимальное значение элемента массива: ");
 int max = Imput("Введите максимальное значение элемента массива: ");
 int[] z = GetRandomArray(lenght, min, max);
 Console.WriteLine(String.Join(",", z));
int result = EvIndexSum(z);
 Console.WriteLine(String.Join(",", result));