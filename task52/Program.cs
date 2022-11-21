// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Двумерный массив: ");
    Console.WriteLine(String.Empty);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void ArithmeticalMeanOfColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
    var average = Math.Round((double) sum/array.GetLength(0), 3); 
    Console.WriteLine(String.Empty);
    Console.Write($"Среднее арифметическое элементов {j}-го столбца: {average}");
    }
}

Console.Clear();

Console.Write("Задайте количество строк m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте количество столбцов n = ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите нижнюю границу диапазона элементов массива: ");
int lower = int.Parse(Console.ReadLine()!);
Console.Write("Введите верхнюю границу диапазона элементов массива: ");
int upper = int.Parse(Console.ReadLine()!);

Console.WriteLine(String.Empty);

int[,] workingArray = GetArray(m, n, lower, upper);
PrintArray(workingArray);

ArithmeticalMeanOfColumn(workingArray);
