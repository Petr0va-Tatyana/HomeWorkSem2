// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Clear();
Console.WriteLine("Введите трехзначное число: ");

int Number = int.Parse(Console.ReadLine()!);
int a = Number / 10;
int b = a % 10;

Console.WriteLine("Вторая цифра числа: " + b);