/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

int GetNumber(string message)
{
    int result = 0;
    string error = "Введите корректное число, пожалуйста!";

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else 
        {
            Console.Clear();
            Console.WriteLine(error);
        }
    }

    return result;
}


int[,] GetMatrix(int m, int n) 
{
    int[,] matrix = new int[m, n];
    Random yuy = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        matrix[i, j] = yuy.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void DoOne(int[,] matrix, int[,] matrix2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]*matrix2[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Print m: ");
int n = GetNumber("Print n: ");
int[,] matrix = GetMatrix(m, n);
int[,] matrix2 = GetMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
DoOne(matrix, matrix2);

