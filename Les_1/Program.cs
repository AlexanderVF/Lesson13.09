//  черновик --- Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
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
                //array[i,j,k] = new Random().Next(11, 100);
                array[i, j, k] = s;
                s = s + 1;

                /* int number = array[i-count,j - count,k - count];
                
                if (array[i,j,k] == number){
                    Console.WriteLine($"{array[i,j,k]} ({i},{j},{k}) {number} {count} "); */
            }
        }
    }



    return array;
}

/* if (array[i,j,k] == array[i,j,k]){
            Console.WriteLine($"{array[i,j,k]} ({i},{j},{k})   ");
                } */

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
Console.WriteLine();

int[,,] array2 = new int[rows, columns, size];
/* int r = 0;
int t = 0;
int w = 0; */
Random random = new Random();

for (int r = 0; r < rows - 1; r++)
{
    for (int t = 0; t < columns - 1; t++)
    {
        for (int w = 0; w < size - 1; w++)
        {
        
array2[r, t, w] = random.Next(array[0, 0, 0], array[rows, columns, size]);
            array2[r, t, w] = array[rows, columns, size];
            int temp = array2[r, t, w];
            array2[r, t, w] = array[rows, columns, size];
            array[rows, columns, size] = temp; 
           Console.WriteLine(array2[r, t, w]);

        }

    }

}

/* for (int i = array.Length - 1; i >= 11; i--)
{
    for (int j = array.Length - 1; j >= 11; j--)
    {
        for (int k = array.Length - 1; k >= 11; k--)
        {

            array2[r, t, w] = random.Next(array[i, j, k]);
            array2[r, t, w] = random.Next(11, 30);

            int temp = array2[r, t, w];
            array2[r, t, w] = array[i, j, k];
            array[i, j, k] = temp;
            w++;
            Console.WriteLine(array2[r, t, w]);
            Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
        }
    }
} */
/* for (int k = 0; k > array.GetLength(2); k++)
{
    for (int i = 0; i > array.GetLength(0); i++)
    {
        for (int j = 0; j > array.GetLength(1); j++)
        {

            int p = random.Next(i + 1);
            // обменять значения data[j] и data[i]
            var temp = array[i, j, k];
            array[i, j, k] = array[i, j, p];
            array[i, j, p] = temp;
            Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
        }
         Console.WriteLine();
    }
} */

// PrintArray(array);
// Console.WriteLine();


/* for (int i = data.Length - 1; i >= 1; i--)
{
   int j = random.Next(i + 1);
   // обменять значения data[j] и data[i]
   var temp = data[j];
   data[j] = data[i];
   data[i] = temp;
} */


