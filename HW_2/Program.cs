Console.Clear();
int[,] GetArray(int m, int n) {
    int[,] array = new int[m,n];
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                array[i,j] = new Random().Next(1,100);
            }
        }    
        return array;
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
                Console.Write($" {array[i,j]}");
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

int sum = 0;
int isum = 0;
int min = 10000;
int rowmin = 0;
for (int i = 0; i < rows; i++ ) {
    for (int j = 0; j < columns; j++) {
        sum = array[i, j] + sum;    
                
    }
    //Console.WriteLine(sum);
    //Console.WriteLine();
    if (sum <= min) {
        min = sum;
        rowmin = i + 1;
        
    }
        sum = isum;
}

Console.WriteLine(rowmin + " строка с наименьшей суммой элементов");
Console.WriteLine();
