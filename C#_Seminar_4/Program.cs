/*
// Нписать прогрмму, которая принимет на вход число А и выдает сумму чисел от 1 до А

void Numers(int num){
    int result = 0;
    for(int i = 1; i <= num; i++){
        result += i;
    }
    Console.WriteLine($"Сумма чисел от 1 до {num} равна {result}");
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Numers(number);

*/
/*
// Напишите программу, которя на вход принимает число N и выдает произведение чисел от 1 до N

void Fact(int num){
    int result = 1;
    for(int i = 1; i <= num; i++){
        result *= i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {num} равно {result}");
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Fact(number);
*/
/*
// Напишите программу, которая принимет на вход число и выдает количество цифр в числе

// void Kolich (string num){
//     int result = 0;
//     for(int i = 0; i < num.Length; i++){
//         result++;
//     }
//     Console.WriteLine($"Количество цифр в числе {num} равно {result}");
// }
// Console.Write("Введите число: ");
// string number = Console.ReadLine();
// Kolich(number);

// Второй вариант
void Kolich (int num){
    int result = 0;
    for (int i = num; i != 0; i /= 10){
            result++;
        }
    Console.WriteLine($"Количество цифр в числе {num} равно {result}");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0) Console.WriteLine($"Количество цифр в числе {number} равно 1");
else Kolich(number);
*/
/*
// Нпишите программу, которая находит в последовательности от 1 до N  все нечетные числа

void Nech(int num) {
    for (int i = 1; i <= num; i++){
        if ( i % 2 != 0) Console.Write($"{i} ");
    }
}
Console.Write("Введите число больше 0: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0) Console.WriteLine("Введенное число не соответствует условию");
else Nech(number);
*/
///////////////////////////////////////////////////////////////////////////////////////
/*
// Напишите программу, которая выводит массив из 8 элементов, запоненный нулями и единицами в случайном порядке
int[] RandonArray (int size) {
    int[] result = new int[size];
    for (int i = 0; i <= size - 1; i++){
        result[i] = new Random().Next(0, 2);
    }
    return result;
}

void PrintArray (int[] arr) {
    Console.Write("{ ");
    for (int i = 0; i < arr.Length; i++){
        Console.Write("[" + arr[i] + "]");
    }
    Console.Write(" }");
}

Console.Write("Введите размер мессива: ");
int size = Convert.ToInt32(Console.ReadLine());
PrintArray(RandonArray(size));
*/
//////////////////////////////////////////////////////////////////////////////////////////////

