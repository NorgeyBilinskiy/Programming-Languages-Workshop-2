// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 

Console.WriteLine("Добрый день!");

Console.WriteLine("Введите трёхзначное значное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num<100) Console.WriteLine($"Ошибка! Вы ввели не трёхзначное число!");
else if (num>999) Console.WriteLine($"Ошибка! Вы ввели не трёхзначное число!");
else {
    int a1 = num/10;
    int x2 = a1 % 10;
    Console.WriteLine($"Вторая цифра данного числа {x2}");
    };
