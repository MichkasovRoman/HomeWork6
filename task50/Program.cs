// Задача 50. Напишите программу, 
//которая на вход принимает число 
//и ищет его в двумерном массиве. 
//Программа должна возвращать значение позиции 
//(номер строки и столбца) этого элемента 
//или же указание, что такого элемента нет.

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

void SearchForElement(double[,] array)
{
    Console.Write("Введите искомый элемент массива: ");
    double desiredElement = double.Parse(Console.ReadLine()!);
    double index1 = 0;
    double index2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == desiredElement)
                    {
                        desiredElement = array[i, j];
                        index1 = i;
                        index2 = j;
                    } 
                }
        }  
    Console.Write($"Элемент {desiredElement} находится в {index1}-й строке и в {index2}-м столбце."); 
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

Console.WriteLine(" ");

double[,] workingArray = GetArray(m, n, lower, upper);
PrintArray(workingArray);
Console.WriteLine(" ");
SearchForElement(workingArray);
