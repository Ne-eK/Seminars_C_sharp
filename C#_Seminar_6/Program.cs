/*
// преобразовние десятичного числ в двоичное

string ChangeDigitSys(int num) {
    string result = string.Empty;
    while (num > 0) {
       result = num % 2 + result;
       num /= 2; 
    }
    return result;
}

Console.WriteLine("Введите десятичное число для перевод в двоичное");
int num = Convert.ToInt32(Console.ReadLine());
string res = ChangeDigitSys(num);
Console.WriteLine(res);
*/

/*
void Tryanle(int a, int b, int c) {
    if (a < b + c && b < a + c && c < a + b) Console.WriteLine("Треугольник существует");
    else Console.WriteLine("Треугольник не существует");
}

Console.WriteLine("Введите первую сторону треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());
Tryanle(a, b, c);
*/

/*
int[] Fibonachy(int num) {
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++){
        array[i] = array[i - 1] + array[i - 2];
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

Console.WriteLine("Введите количество чисел фибонччи: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] res = Fibonachy(a);

PrintArray(res);
*/