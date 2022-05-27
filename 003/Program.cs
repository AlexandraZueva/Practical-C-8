// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray(int[,] matr, int[,] matr1)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(1, 10);
        }
    }
    for (int m = 0; m < matr1.GetLength(0); m++)
    {
        for (int n = 0; n < matr1.GetLength(1); n++)
        {
            matr1[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr, int[,] matr1)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int m = 0; m < matr1.GetLength(0); m++)
    {
        for (int n = 0; n < matr1.GetLength(1); n++)
        {
            Console.Write($"{matr1[m, n]} ");
        }
        Console.WriteLine();
    }
}

void Composition(int[,] matr, int[,] matr1, int[,] newMatr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            newMatr[m, n] = matr[m, n] * matr1[m, n];
        }
    }
}

void PrintNewArray(int[,] newMatr)
{
    for (int m = 0; m < newMatr.GetLength(0); m++)
    {
        for (int n = 0; n < newMatr.GetLength(1); n++)
        {
            Console.Write($"{newMatr[m, n]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[2, 2];
int[,] matrix1 = new int[2, 2];
int[,] newMatrix = new int[2, 2];
FillArray(matrix, matrix1);
PrintArray(matrix, matrix1);
Console.WriteLine();
Composition(matrix, matrix1, newMatrix);
PrintNewArray(newMatrix);