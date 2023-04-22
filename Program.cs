/*
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
//Print(number);
Console.WriteLine();
stopWatch.Stop();
long tmp = stopWatch.ElapsedMilliseconds;

stopWatch.Start();
PrintCycle(number);
Console.WriteLine();
stopWatch.Stop();
Console.WriteLine(tmp);
Console.WriteLine(stopWatch.ElapsedMilliseconds);
 

ЗАДАЧА 63: 
Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от 1 до N 

Print(5, 1);
void Print(int number, int i)
{
    if (i <= number)
    {
        Console.Write($"{i}, ");
        Print(number, i + 1);
    }

}

Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" 
M = 4; N = 8 -> "4, 6, 7, 8"
*/
/*
int M = DataInput();
int N = DataInput();
int DataInput()
{
    Console.WriteLine("Введите число"); 
    int a = int.Parse(Console.ReadLine());
    return a; 
}

Print(N, M);
void Print(int number, int i)
{
    if (i <= number)
    {
        Console.Write($"{i}, ");
        Print(number, i + 1);
    }
}

*/
/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12 45 -> 9

int number = DataInput();
int DataInput()
{
    Console.WriteLine("Введите число");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int sum = SumNumber(number);

Console.WriteLine($"{number} -> {sum}");

int SumNumber(int number)
{
    if (number > 0)
    {
        int sum = number % 10;
        number = number / 10;
        return SumNumber(number) + sum;
    }
    
    return 0;
    
}
*/

/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит 
число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8


int a = DataInput();
int b = DataInput();
int sum = DegreeNumber(a,b);
Console.WriteLine($"{a}, {b} -> {sum}");

int DegreeNumber(int a, int b)
{
    if(b > 0)
    {
        b = b - 1; 
        return DegreeNumber(a,b) * a; 
    }
    return 1;
}

int DataInput()
{
    Console.WriteLine("Введите число"); 
    int a = int.Parse(Console.ReadLine());
    return a; 
}
КОНЕЦ СЕМИНАРА
_____________________________________________________ 
ДОМАШНЕЕ ЗАДАНИЕ 

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

РЕШЕНИЕ:

Console.WriteLine("Введите число и я выведу все натуральные числа от 1 до этого числа:");
int number = int.Parse(Console.ReadLine());

void CountOfNumbers (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    CountOfNumbers (number - 1);
}

CountOfNumbers(number);
____________________________________________ 

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

РЕШЕНИЕ: 


Console.WriteLine("Я могу посчитать сумму натуральных элементов в промежутке от M до N");
Console.WriteLine("Введите первое число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число N:");
int numberN = int.Parse(Console.ReadLine());

void NaturNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов равна {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NaturNumberSum(numberM, numberN, sum);
}

NaturNumberSum(numberM, numberN, 0);

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

РЕШЕНИЕ: 
*/ 
Console.WriteLine("Я могу высчитать функцию Аккермана двух чисел.");
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int FinctionAkkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return FinctionAkkerman(m - 1, 1);
else return FinctionAkkerman(m - 1, FinctionAkkerman(m, n - 1));
}

Console.Write($"Функция Аккермана равно {FinctionAkkerman(m, n)} ");


