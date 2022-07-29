/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 1 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
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
int m = GetNumber("Print m: ");
int n = GetNumber("Print n: ");
int k = GetNumber("Print k: ");
int[,,] array = new int[m,n,k];
Random yuy = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int l = 0; l < array.GetLength(2); l++)
        {
            array[i,j,l] = yuy.Next(10,99);
            Console.Write($"{array[i,j,l]}({i},{j},{l}) ");
        }
    }
    Console.WriteLine();
}

