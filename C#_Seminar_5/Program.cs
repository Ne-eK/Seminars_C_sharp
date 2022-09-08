/*
int[] CreateRandomArray (int size, int min, int max) {
    int [] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray (int[] array) {
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"[{array[i]}] ");
    }
    Console.Write("}");
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateRandomArray(size, min, max));
*/
/*
// Задайте массив из 12 элементов, заполните элементами от [-9 до 9].
// Найти сумму отрицательных и положительных элементов мссива.

int[] CreateRandomArray (int size, int min, int max) {
    int [] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray (int[] array) {
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"[{array[i]}] ");
    }
    Console.Write("}");
}

int SumPosElement(int[] array) {
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] > 0) sum += array[i];
    }
    return sum;
}

int SumNegElement(int[] array) {
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] < 0) sum += array[i];
    }
    return sum;
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);

PrintArray(array);

int posSum = SumPosElement(array);
int negSum = SumNegElement(array);
Console.WriteLine();
Console.WriteLine($"Sum of positive numbers is {posSum} and sum of negative numbers is {negSum}");
*/


/*
// Напишите программу по замене элементов в массиве. 
// Замените положительные элементы на соответсвующие им отрицательные и наоборот.

int[] CreateRandomArray (int size, int min, int max) {
    int [] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray (int[] array) {
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"[{array[i]}] ");
    }
    Console.Write("}");
    Console.WriteLine();
}

void ObmenArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] *= -1; 
    }
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] randomArray = CreateRandomArray(size, min, max);

PrintArray(randomArray);

ObmenArray(randomArray);

PrintArray(randomArray);
*/
/*
// Написать прогрмму поиск числа в массиве. При наличии вывести сообщение

int[] CreateRandomArray (int size, int min, int max) {
    int [] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray (int[] array) {
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"[{array[i]}] ");
    }
    Console.Write("}");
    Console.WriteLine();
}

void Search (int[] array, int x) {
    int flag = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == x) flag = 1;
    }
    if (flag == 1) Console.WriteLine($"Число {x} найденно в массиве");
    else Console.WriteLine($"Число {x} не найденно в массиве");
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] randomArray = CreateRandomArray(size, min, max);

Console.Write("Введите искомое число: ");
int search = Convert.ToInt32(Console.ReadLine());
PrintArray(randomArray);
Search(randomArray, search);
*/
/*
// Нйдите произведение пар чисел в одномерном мссиве. Прой считется первое и последнее число, второе и предпосленее и т.д.
// Результт вывести в новый массив

int[] CreateRandomArray (int size, int min, int max) {
    int [] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray (int[] array) {
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"[{array[i]}] ");
    }
    Console.Write("}");
    Console.WriteLine();
}

int[] ProdPar (int[] array) {
    int[] sumPar = new int[array.Length / 2];
    for (int i = 0; i < sumPar.Length; i++) {
        sumPar[i] = array[i] * array[array.Length - i - 1];
    }
    return sumPar;
}

Console.Write("Введите размер массива с четным количеством элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size % 2 == 0) {
    Console.Write("Введите минимльное знечение для элемент мссива: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите мксимальное знечение для элемент мссива: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] randomArray = CreateRandomArray(size, min, max);
    PrintArray(randomArray);
    int[] prodPar = ProdPar(randomArray);
    PrintArray(prodPar);
}
else Console.Write("Введнный рзмер массива не соответсвует условию");
*/

