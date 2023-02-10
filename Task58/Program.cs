// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

Console.Clear();
Console.Write("Введите колличество строк первого массива: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов первого массива: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество строк второго массива: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов второго массива: ");
int m2 = Convert.ToInt32(Console.ReadLine());
if (m1 != n2)
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    return;
}
int[,] MatrixFirst = FillArray (n1, m1, 0, 10);
int[,] MatrixSecond = FillArray (n2, m2, 0, 10);
Console.WriteLine("Первая матрица");
ScreenArray(MatrixFirst);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
ScreenArray(MatrixSecond);
Console.WriteLine();
Console.WriteLine("Произведение матриц");
ScreenArray(MatrixFinal(MatrixFirst, MatrixSecond));

int[,] MatrixFinal(int[,] MatrixFirst, int[,] MatrixSecond)
{
    int[,] MatrixFinal = new int[MatrixFirst.GetLength(0), MatrixSecond.GetLength(1)];
    for (int i = 0; i < MatrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixSecond.GetLength(1); j++)
        {
            for (int k = 0; k < MatrixFirst.GetLength(1); k++)
            {
                MatrixFinal[i, j] = MatrixFinal [i, j] + (MatrixFirst[i, k] * MatrixSecond[k, j]);
            }
        }
    }
    return MatrixFinal;
}
int[,] FillArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        result[i, j] = new Random().Next(min, max + 1);
      }
      
    }
    return result;
}

void ScreenArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}