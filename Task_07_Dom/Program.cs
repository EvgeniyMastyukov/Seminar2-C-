﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 78 -> третьей цифры нет 32679 -> 6
Console.WriteLine("Введите любое число: ");
string num = Console.ReadLine();
int size = num.Length;


//Console.WriteLine(size);
if (size >= 3) 
{
    char thirdDigit = num[2];
    Console.WriteLine(thirdDigit);
}
else Console.WriteLine("третьей цифры нет");


// Андрей, оставить только третью цифру числа по моим соображениям можно было решив прибегая к массиву, чтобы 
//программе указать на индекс третьей цифры. Но в условии задачи нет про ввод массива, там ввести число. Я подумал, 
//что строка и есть 
//некий массив м посмотрел в инете про свойства строки string. Есть команда char которая вытаскивает нам символ строки
// по его индексу. В лекции нет и на семинаре не проходили аналогичных задач. Если работать через массив, то тоже надо 
// думать, как его размер каждый раз должен меняться при вводе разных чисел от 1 до много 1223454455.