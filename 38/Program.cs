// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int Imput(string smth)
{
    Console.WriteLine(smth);
    int A = int.Parse(Console.ReadLine());
    return A;
}

double[] GetRandomArray(int size)
{
    double[] res = new double [size];
    for (int i=0; i<size; i++)
    {
        res[i] = Convert.ToDouble(new Random().Next(0, 100))/10;
    }
    return res;
}

double MinMaxDifferent (double[] array)
{
    double result = 0;
    double min = 100;
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min) min = array [i];
        if (array[i]>max) max = array [i];
        result = max - min;
    }
        return result;
}

Console.Clear();
 int lenght = Imput("Введите количество элементов массива: ");
 double[] z = GetRandomArray(lenght);
 Console.WriteLine(String.Join(";  ", z));
 Console.WriteLine($"Разница между максимальным и минимальным числом массива - {MinMaxDifferent(z)}");
