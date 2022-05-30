// Напишите программу, которая будет принимать на вход 2 числа и выводить является ли первое число кратным второму. 
//Если первое число некратно второму, то программа выводит остаток от деления 34,5 -> не кратно, остаток 4. 16, 4 -> кратно. 
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1%num2 == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток {num1%num2}");
