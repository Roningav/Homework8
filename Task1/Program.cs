/*

Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
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

void FindMin(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int max = matrix[0, j];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if(max<matrix[i,j])
            {
                matrix[i,j] = max;
                Console.Write($"{max} ");
            }
            else
            {
                Console.Write($"{matrix[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}
int m = GetNumber("Print m: ");
int n = GetNumber("Print n: ");
int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
FindMin(matrix);