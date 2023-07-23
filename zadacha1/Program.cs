
//  2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
 

Console.WriteLine("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"{num1} больше, чем {num2}");
    Console.WriteLine($"{num2} меньше, чем {num1}");
}
    else if (num1 < num2)
{
    Console.WriteLine($"{num1} меньше, чем {num2}");
    Console.WriteLine($"{num2} больше, чем {num1}");
}
    else
{
    Console.WriteLine("Числа равны");
}
