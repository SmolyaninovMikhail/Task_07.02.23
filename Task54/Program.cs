// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

Console.Clear();
Console.Write("Введите колличество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [n, m];
FillMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Первоначальный массив");
PrintMatrix(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            if (matrix[i, k] < matrix [i, k + 1]) // можно поменять знак "<" на ">" и будет сортировка по увеличеню элементов
            {
                int temp = 0;
                temp = matrix [i, k];
                matrix[i, k] = matrix [i, k + 1];
                matrix [i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Упорядоченный массив");
PrintMatrix(matrix);

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}