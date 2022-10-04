//1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8


System.Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 99 & numberA < 1000)
{
    int result = numberA % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Число не трехзначное");
}