// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибол цифру числа
// пример: 78 -> 8, 12->2
// int num = new Random(). Next(10,100);
// Console.WriteLine(num);
//  int firstDigit = num/10;
//  int secondDigit = num%10;
//  //if (firstDigit > secondDigit) Console.WriteLine($"max цифра = {firstDigit}");
//  //else Console.WriteLine($"Max digit = {secondDigit}");
//  Console.WriteLine(firstDigit > secondDigit? $"Max = {firstDigit}" : $"Max = {secondDigit}");
int num = new Random().Next(10, 100);
Console.WriteLine(num);

int GetMaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxNumber = GetMaxDigit(num);
Console.WriteLine(maxNumber);
