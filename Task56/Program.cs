// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

Console.Clear();
Console.Write("Введите колличество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [n, m];
FillMatrix(matrix);
ScreenMatrix(matrix);
int minSumLine = 0;
int sumLine = SumLineElements(matrix, 0);

for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

int SumLineElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine = sumLine + matrix[i,j];
  }
  return sumLine;
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void ScreenMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}