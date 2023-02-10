/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
Массив размером 2 x 2 x 2 */

Console.Clear();
Console.WriteLine("Введите размеры массива");
Console.Write("Введите первый элемент: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй элемент: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третий элемент: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"");
int[,,] matrix3D = new int [a, b, c];
GrrrMatrix(matrix3D);
BrrrMatrix(matrix3D);

void BrrrMatrix(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            Console.Write($"a({i}) b({j}) ");
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"c({k})={matrix3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void GrrrMatrix(int[,,] matrix3D)
{
    int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
    int bukvacifra;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        bukvacifra = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    bukvacifra = temp[i];
                }
                bukvacifra = temp[i];
            }
        }
    }
    int count = 0;
    for (int d = 0; d < matrix3D.GetLength(0); d++)
    {
        for (int e = 0; e < matrix3D.GetLength(1); e++)
        {
            for (int f = 0; f < matrix3D.GetLength(2); f++)
            {
                matrix3D[d, e, f] = temp[count];
                count++;
            }
        }
    }
}


// это просто жесть, искал ошибку больше двух часов =_=