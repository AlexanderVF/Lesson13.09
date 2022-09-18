//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// первый вариант
/* Console.Clear();
int s = 11;
int[,,] GetArray(int rows, int columns, int size)
{
    int[,,] array = new int[rows, columns, size];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < size; k++)
            {
                array[i, j, k] = s;
                s = s + 2;
            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine(" Введите строки");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите ширину");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите высоту");
int size = int.Parse(Console.ReadLine());

int[,,] array = GetArray(rows, columns, size);
PrintArray(array);
Console.WriteLine(); */

// Второй способ

int[,,] GetArray(int m, int n, int k)
{
    int[,,] array = new int[m, n, k];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                array[i, j, l] = new Random().Next(10, 100);
                int point = NewPoint(i,j,l,array);
                while (point == 1) 
                {
                array[i, j, l] = new Random().Next(10, 100);
                point = NewPoint(i,j,l,array);
                }
            }
        }

    }
    return array;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                Console.Write("  " + arr[i, j, l] + "(" + i + ", " + j + ", " + l + ")"); 
            }
            Console.WriteLine();
        }
    }
}

int NewPoint(int tochka1, int tochka2, int tochka3, int[,,] array)
{
    int point = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (i == tochka1 && j == tochka2 && h == tochka3)
                {
                    continue;
                }
                if (array[tochka1, tochka2, tochka3] == array[i, j, h])
                {
                    point = 1;
                    return point;
                }
            }

        }
    }
return point;
}
    Console.Write("Введите число строк массива: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите число высоты массива: ");
    int k = int.Parse(Console.ReadLine());

      
    int[,,] array = GetArray(m, n, k);
    PrintArray(array);
    Console.WriteLine();