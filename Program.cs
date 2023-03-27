// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillUpArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)   
    {
        Console.WriteLine($"Введите эдемент {i+1}");
        arr[i] = Convert.ToDouble(Console.ReadLine()); 
    }
}

double FindMaxValue(double[] arr)
{
    double MaxValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]>MaxValue) {MaxValue=arr[i];}
    }
    return MaxValue;
}
double FindMinValue(double[] arr)
{
    double MinValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]<MinValue) {MinValue=arr[i];}
    }
    return MinValue;
}

double[] array = new double[5];

FillUpArray(array);
Console.WriteLine($"Массив: {String.Join("; ", array)}");
Console.WriteLine($"разница между максимальным и минимальным значением массива: {FindMaxValue(array)-FindMinValue(array)}");