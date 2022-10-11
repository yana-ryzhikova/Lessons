/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */


int InputNumber(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Count(int number)
{
    int resalt = 0;
    while (number > 0)
    {
        number = number / 10;
        resalt++;
    }
    return resalt;
}

int N = (InputNumber("Введите число: "));
int Num = Count(N);
System.Console.WriteLine(Num);
