/*
int CatNumber () {
    int a = new Random().Next(100, 1000);
    Console.WriteLine("Number is - " + a);
    int dec = a / 100;
    int ed = a % 10;
    int result = dec * 10 + ed;
    return result;
}

int number = CatNumber();
Console.WriteLine("Cut number is - " + number);
*/

/*
void CatNumber() {
     int a = new Random().Next(100, 1000);
    Console.WriteLine("Number is - " + a);
    int dec = a / 100;
    int ed = a % 10;
    int result = dec * 10 + ed;
    Console.WriteLine("Cut number is - " + result);
}

CatNumber();
*/

/*
int Factorial (int a) {
    int current = 1;
    int fact = 1;
    if (a > 0) {
        while(current <= a){
            fact = fact * current;
            current++;
        }
        return fact;
    }
    else if (a == 0){
        return fact;
    }
    else {
        Console.WriteLine("Факториал отрицательного числа не возможен!");
        return 0;
    }
}

int result = Factorial(-1) * Factorial(0);
Console.WriteLine("Factorial is - " + result);
*/

/*
int Max () {
    int a = new Random().Next(10, 100);
    Console.WriteLine("Число для сравнения - " + a);
    int b = a / 10;
    int c = a % 10;
    if (b > c) {
        return b;
    }
    else {
        return c;
    }
}


Console.WriteLine("Наибольшее число из двух - " + Max());
*/

/*
void Crat (int a) {
    if (a % 7 == 0 && a % 23 == 0) {
        Console.WriteLine("Введенное число кратно 7 и 23");
    }
    else {
        Console.WriteLine("Введенное число не кратно 7 и 23");
    }
}
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Crat(N);
*/

/*
void Square (int a, int b) {
    if (a == b * b || b == a * a){
        Console.WriteLine("Одно из чисел является квадртом второго");
    }
    else{
        Console.WriteLine("Ни одно из чисел не является квадртом второго");
    }
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Square(num1, num2);
*/

/*
void Square2 (int a, int b) {
    if (a == b * b) {
        Console.WriteLine("Число " + a + " является квадратом " + b);
    }
    else if (b == a * a) {
        Console.WriteLine("Число " + b + " является квадратом " + a);
    }
    else {
        Console.WriteLine("Ни одно из чисел не является квадртом второго");
    }
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Square2(num1, num2);
*/

/*
void Crat2 (int a, int b) {
    if (a == 0 || b == 0){
        Console.WriteLine("Делить на ноль нельзя");
    }
    else{
        if (b % a == 0) {
            Console.WriteLine("Число " + b + " кратно числу " + a);
        }
        else {
            Console.WriteLine("Число " + b + " не кратно числу " + a + " остаток от деления = " + b % a);
        }
    }
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Crat2(num1, num2);
*/

