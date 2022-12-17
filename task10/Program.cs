// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 

Console.WriteLine("Добрый день!");

Console.WriteLine("Введите 3-ёх значное число");
int num = Convert.ToInt32(Console.ReadLine());

int a1 = num/10;
int x2 = a1 % 10;

Console.WriteLine($"Вторая цифра данного числа {x2}");
