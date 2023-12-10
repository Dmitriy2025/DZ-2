// // Напишите программу, которая на вход принимает натуральное число N,
// // а на выходе показывает его цифры через запятую.

Console.Clear();
int a = new Random().Next(1, int.MaxValue);
Console.WriteLine($"Наше случайное число: {a}");

int[] ConvertToArray(int number)
    {
        string numberString = number.ToString();
        int[] array = new int[numberString.Length];

        for (int i = 0; i < numberString.Length; i++)
        {
            array[i] = int.Parse(numberString[i].ToString());
        }

        return array;
    }

void PrintArray(int[] print)
 {
    int Len = print.Length;
    int i = 0;
    while (i < Len)
    {
     Console.Write(print[i]);
        if (i < Len - 1)
            Console.Write(", ");

     i++;
     }
        Console.WriteLine();
 }

int[] row = ConvertToArray(a);
PrintArray(row);
