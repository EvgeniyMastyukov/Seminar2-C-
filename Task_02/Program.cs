// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру числа: 456->16; 918->98.
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int DivSecDigit (int num)
{
    int firstDigit = num/100;
    int thirdDigit = num%10;
    //Console.WriteLine(firstDigit,thirdDigit);
    //return firstDigit; 
    int newNum = firstDigit*10 + thirdDigit;
    return newNum;
}    
int aa = DivSecDigit(number);
Console.WriteLine(aa);