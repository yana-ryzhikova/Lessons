// Напишите программу вычисления функции:
// n = f(a)
//
// Напишите программу, которая на вход принимает число N и выводит все целые числа от -n до n.
// -2 -1 0 1 2 

System.Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int count = -n;
while (count <= n)
{
    System.Console.WriteLine(count);
    count++;
}
