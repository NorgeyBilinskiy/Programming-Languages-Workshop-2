// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Добрый день!");

Console.WriteLine("Введите число соответсвующее дню недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num<1) Console.WriteLine($"Вы ввели неправильное число: введите цифру от 1 до 7");
else if (num>7) Console.WriteLine($"Вы ввели неправильное число: введите цифру от 1 до 7");
else if (num<6) Console.WriteLine($"Иди на пары");
else Console.WriteLine($"Отдыхай");
