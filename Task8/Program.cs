﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да


int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите число");
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"{number} не кратно 7 и 23");
}