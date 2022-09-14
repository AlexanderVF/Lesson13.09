Console.Clear();
int[,] GetArray(int m, int n) {
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
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

//int[,] arrayNew = new int[rows,columns];

for (int i = 0; i < rows; ++i)
{
    for (int j = 0; j < columns -1; ++j)
    {
        if (array[i, j] < array[i, j + 1])
        {

            int temp = array[i,j];
            array[i,j] = array[i,j+1];
            array[i,j+1] = temp;
            
            //Console.WriteLine();
            //Console.Write($"{array[i,j]} ");
        }
           
        
        //Console.Write($"{array[i,j]} ");
    }
    
}

//int[,] arrayNew = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
