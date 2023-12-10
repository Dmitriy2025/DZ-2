// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числ

int Max( int arg1, int arg2, int arg3) 
{
    int MaxNumber = arg1;
    if ( arg2 > MaxNumber ) MaxNumber = arg2;
    if ( arg3 > MaxNumber ) MaxNumber = arg3;
    return MaxNumber;

}

Console.Clear();
int a = new Random().Next(10, 100); // от 10 до 99
Console.WriteLine($"Случайное число: {a}");

int n1 = a / 100;
int n2 = a / 10 % 10;
int n3 = a % 10;

int result = Max ( n1, n2, n3 );
Console.WriteLine($"Наибольшая цифра этого числа: {result}");
