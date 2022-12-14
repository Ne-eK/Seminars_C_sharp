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

// разворот массива, меняет столбцы на строки

int[,] Revers2dArray(int[,] array){
    int temp = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 1 + i; j < array.GetLength(1); j++){
            temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
    return array;
}

// находит минимальный элемент и меняет значения на ноль в строке и столбце которые в которых находится этот элемент

int[,] DellColsRows(int[,] array){
    int iMin = 0; 
    int jMin = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 1; j < array.GetLength(1); j++){
            if(array[i,j] < array[iMin, jMin]){
                iMin = i;
                jMin = j;
            }
        }
    }
    for(int i = 0; i < array.GetLength(0); i++){
        array[i, jMin] = 0;
    }
    for(int j = 0; j < array.GetLength(1); j++){
        array[iMin, j] = 0;
    }
    return array;
}

// замена первой строки на последнюю

int[,] Revers2dRows(int[,] array){
    int temp = 0;
    int i = array.GetLength(0) - 1;
    for(int j = 0; j < array.GetLength(1); j++){
        temp = array[0,j];
        array[0,j] = array[i,j];
        array[i,j] = temp;
    }
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
// int[,] arr2 = Revers2dArray(arr);
// PrintArray(arr2); 

// int[,] arr3 = DellColsRows(arr);
// PrintArray(arr3);

// int[,] arr4 = Revers2dRows(arr);
// PrintArray(arr4);


