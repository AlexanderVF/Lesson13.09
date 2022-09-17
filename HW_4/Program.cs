//
Console.Clear();
int count = 0;
int[,,] GetArray(int rows, int columns, int size) {
    int[,,] array = new int[rows, columns, size];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) {
            for (int k = 0; k < size; k++) {
                array[i,j,k] = new Random().Next(11, 100);
                
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

void PrintArray(int[,,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})   ");
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

/* for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {

                Console.Write($"{array[i,j,k]} ({i},{j},{k})   ");
 */