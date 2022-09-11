int[,] CreateRandom2dArray(int rows, int cols, int min, int max) {
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        Console.Write("{ ");
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write("[" + array[i, j] + "] ");
        }
        Console.WriteLine("}");
    }
}

// найти сумму элементов которые стоят на глвной диагонали

int SumDiagonal(int[,] array){
    int sum = 0;
    if(array.GetLength(0) == array.GetLength(1)){
        for(int i = 0; i < array.GetLength(0); i++){
            for(int j = 0; j < array.GetLength(1); j++){
                if(i == j) sum += array[i, j];
            }
        }
    }
    return sum;
}

// Задайте двумерный массив рзмер n  на m, каждый элемент в массиве находится по формуле: А =  m + n. 
// выведите полученный мссив на экран.

int[,] Create2dArray(int rows, int cols) {
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            array[i, j] = i + j;
        }
    }
    return array;
}


// Задайте двумерный массивб найдите элементы у которых оба индекса четные и замените их илементы на их квадраты.

int[,] SquareArrayIndex(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(0); j++){
            if(i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0) array[i, j] *= array[i, j];
        }
    } 
    return array;
} 

// Дан двумерный массив. Поменять местами: 
// а) элементы, расположенные в правом верхнем и левом нижнем углах.
// б) элементы, расположенные в правом нижнем и левом верхнем углах.

int[,] ChengeElArrayA(int[,] array) {
    int[,] temp = new int[1, 1];
    temp[0, 0] = array[0, 0];
    array[0, 0] = array[array.GetLength(0) - 1, array.GetLength(1) - 1];
    array[array.GetLength(0) - 1, array.GetLength(1) - 1] = temp[0, 0];
    return array;
}
int[,] ChengeElArrayB(int[,] array) {
    int[,] temp = new int[1, 1];
    temp[0, 0] = array[0, array.GetLength(1) - 1];
    array[0, array.GetLength(1) - 1] = array[array.GetLength(0) - 1, 0];
    array[array.GetLength(0) - 1, 0] = temp[0, 0];
    return array;
}



Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимльное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мксимльное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateRandom2dArray(rows, cols, min, max);
PrintArray(arr);
Console.WriteLine("------------------------------------------------------------");
int[,] ara = ChengeElArrayA(arr);
PrintArray(ara);
Console.WriteLine("------------------------------------------------------------");
int[,] arb = ChengeElArrayB(arr);
PrintArray(arb);

