﻿// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки

// 456 -> 5
// 782 -> 8
// 918 -> 1


int Prompt(string message)
{
System.Console.Write($"{message} >");
int answer = Convert.ToInt32(Console.ReadLine());
return answer;
}

bool ValidateNumber(int number)
{
if (number >= 100 && number < 1000)
{
return true;
}

System.Console.WriteLine("Число не трехзначное");
return false;
}

int number = Prompt("Введите число");
if (ValidateNumber(number))
{
int result = number % 100 / 10;
System.Console.WriteLine($"Вторая цифра введенного числа {result}");
}