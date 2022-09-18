// Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:
/* 01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

//
Console.Clear();


void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
                Console.Write($"{array[i,j]}    ");
            }
            Console.WriteLine();
        
    }
}


int rows = 4;
int columns = 4;

int[,] array = new int[rows, columns];

Console.WriteLine(" Введите начальное двузначное число");
int k = int.Parse(Console.ReadLine());
Console.WriteLine();

while (k < 10 || k > 99) {
    Console.WriteLine(" Введите двузначное число");
    k = int.Parse(Console.ReadLine());
}

for (int j = 0; j < array.GetLength(1); j++){
    array[0, j] = k;
    k++;
}
for (int i = 0; i < array.GetLength(0); i++){
    array[i, array.GetLength(0) -1] = k;
    k++;
}
for (int j = array.GetLength(1) -2; j >= 0; j--){
    array[array.GetLength(1)-1, j] = k;
    k++;
}
for (int i = array.GetLength(0) -1; i > 0; i--){
    array[i, array.GetLength(0) -4] = k;
    k++;
}
for (int j = array.GetLength(1) -3; j < array.GetLength(1) -1; j++){
    array[array.GetLength(1)-3, j] = k;
    k++;
}
for (int i = array.GetLength(0) -2; i <= array.GetLength(0) - 2; i++){
    array[i, array.GetLength(0) -2] = k;
    k++;
}
for (int j = array.GetLength(1) -3; j > 0; j--){
    array[array.GetLength(1)-2, j] = k;
    k++;
}
Console.WriteLine();
Console.WriteLine("Это спиральная матрица 4х4");
PrintArray(array);
Console.WriteLine();
