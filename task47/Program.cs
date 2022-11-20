// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

double[,] GetArray(int row, int column, double minValue, double maxValue)
{
    double[,] result = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    Console.WriteLine("Двумерный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Задайте количество строк m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте количество столбцов n = ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите нижнюю границу диапазона элементов массива: ");
double lower = double.Parse(Console.ReadLine()!);
Console.Write("Введите верхнюю границу диапазона элементов массива: ");
double upper = double.Parse(Console.ReadLine()!);

double[,] workingArray = GetArray(m, n, lower, upper);
PrintArray(workingArray);