// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Vvedite stroki");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Vvedite stolbci");
int columns = int.Parse(Console.ReadLine());


int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < rows; ++i)
{
    for (int j = 0; j < columns; ++j)
    {
        for (int k = j + 1; k < columns; ++k)
        {
            if (array[i, j] < array[i, k])
            {

                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;

            }

        }

    }

}

PrintArray(array);
Console.WriteLine();
