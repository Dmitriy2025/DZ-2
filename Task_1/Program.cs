// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
if (a % 7 == 0 && a % 23 == 0) {
    Console.WriteLine("Введенное число КРАТНО одновременно и 7 и 23");
}
else {
    Console.WriteLine("Введенное число НЕ КРАТНО одновременно 7 и 23");
}

