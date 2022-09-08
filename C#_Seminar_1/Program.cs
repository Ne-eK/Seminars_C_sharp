// Задача 1
Console.Write("Введите число: "); // Зпрос данных
int num = Convert.ToInt32(Console.ReadLine()); // Ввод данных
Console.WriteLine("Квадрат числа: " + num + " = " + num * num); // Вычисления + вывод

// Задача 2
Console.Write("Введите первое число: "); // Запрос первого числа
int numA = Convert.ToInt32(Console.ReadLine()); // Ввод первого числа
Console.Write("Введите первое число: "); // Запрос второго числа
int numB = Convert.ToInt32(Console.ReadLine()); // Ввод второго числа
if (numA == numB * numB) {                                                  // 
    Console.WriteLine("Число - " + numA + " является квдратом - " + numB);  // Вычислени и вывод
}                                                                           //
else{
    Console.WriteLine("Число - " + numA + " не является квдратом - " + numB);
}

// Задача 3
Console.Write("Введите число от 1 до 7: "); // Запрос числа 
int numC = Convert.ToInt32(Console.ReadLine()); // Ввод данных
if (numC == 1) Console.WriteLine("Понедельник");
if (numC == 2) Console.WriteLine("Вторник");
if (numC == 3) Console.WriteLine("Среда");
if (numC == 4) Console.WriteLine("Четверг");
if (numC == 5) Console.WriteLine("Пятница");
if (numC == 6) Console.WriteLine("Суббота");
if (numC == 7) Console.WriteLine("Воскресенье");

// Задача 4
Console.Write("Введите число: "); // Запрос числа 
int N = Convert.ToInt32(Console.ReadLine()); // Ввод данных
int current = N * (-1); //
while (current <= N) {
    Console.Write(current + " ");
    current++;
}

