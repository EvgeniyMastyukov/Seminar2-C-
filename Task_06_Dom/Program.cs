// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
// цифру этого числа. 456 -> 5 782 -> 8 918 -> 1
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
// int secondDigit = num/10%10;
// Console.WriteLine("Вторая цифра =  " + secondDigit);
int GetSecondDigit(int number)
{
    int secDigit = number/10%10;
    return secDigit;
}
int digit_2 = GetSecondDigit(num);
Console.WriteLine("Вторая цифра = " + digit_2);