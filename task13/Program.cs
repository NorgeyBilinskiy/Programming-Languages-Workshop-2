// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Добрый день!");

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num<100) Console.WriteLine($"Третьей цифры нет!");
else
// тут я пытался решить задачу не только для трёхзначного числа, но ничего не заработало((
// { 
 //   int[] array = new int[1 + (int)Math.Log10(num)];
    //array.Length - размер массива
 //   for (int i = array.Length - 1; i >= 0; i--)
 //   {
 //   int array;
  //  num = Math.DivRem(num, 10, out array);
 //   array[i] = array;
 //   }
  //  Console.WriteLine($"{array}");
 //   int x3 = array [3];
   // Console.WriteLine($"Третья цифра данного числа {x3}");
//}
{
 int x3 = num % 10;
 Console.WriteLine($"Третья цифра данного числа {x3}");
 };