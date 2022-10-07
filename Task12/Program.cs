﻿// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

//Math.Sqrt() // Функция вычисления квадратного корня.

const int X = 0;
const int Y = 1;
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int [] InputPoint(int point)
{
    int [] answer = new int[2];
    answer [X] = Prompt($"Введите x{point} -> ");
    answer [Y] = Prompt($"Введите y{point} -> ");
    return answer;
}


double Power2(int arg)
{
    return Math.Pow(arg,2);
}
int [] p1 = InputPoint (1);
int [] p2 = InputPoint (2);

double lenght = Math.Sqrt (Power2(p1 [X] - p2 [X]) + Power2(p1 [Y] - p2 [Y]));//<-Math.Sqrt

System.Console.WriteLine($"{lenght:f2}");// f   - это кол-во знаков после запятой


