// Задача 50. Напишите программу, 
//которая на вход принимает число 
//и ищет его в двумерном массиве. 
//Программа должна возвращать значение позиции 
//(номер строки и столбца) этого элемента 
//или же указание, что такого элемента нет.

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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

void SearchForElement(int[,] array)
{
    Console.Write("Введите искомый элемент массива: ");
    int desiredElement = int.Parse(Console.ReadLine()!);
    int index1 = -1;
    int index2 = -1;
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
    if (index1 == -1 && index2 == -1)
    {
        Console.WriteLine("Введенного вами элемента нет в массиве.");
        Console.WriteLine("Перезапустите программу и введите число заново.");
    }
    else
    {
        Console.Write($"Элемент {desiredElement} находится в {index1}-й строке и в {index2}-м столбце."); 
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
Console.WriteLine(String.Empty);
SearchForElement(workingArray);

