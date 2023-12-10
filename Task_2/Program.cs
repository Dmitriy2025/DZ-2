// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.
Console.Clear();
Console.Write("Введите координаты точки по оси x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки по оси y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write($"(x = {x}, ");
Console.WriteLine($"y = {y})");
if (x == 0 && y ==0) Console.WriteLine ("Координаты не должны равняться нулю!");
else {
    if (x > 0 && y > 0) Console.WriteLine ("Точка находится в I четверти");
    else if (x < 0 && y > 0) Console.WriteLine ("Точка находится во II четверти");
    else if (x < 0 && y < 0) Console.WriteLine ("Точка находится в III четверти");
    else Console.WriteLine ("Точка находится в VI четверти");
}
