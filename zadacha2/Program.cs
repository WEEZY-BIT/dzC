// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int num3 = int.Parse(Console.ReadLine());

int max = Math.Max(Math.Max(num1, num2), num3);

Console.WriteLine("Максимальное число: " + max);

Console.ReadLine();