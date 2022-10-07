// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateCoords (int xCord, int yCord)
{
    if (xCord ==0 || yCord == 0)
    {
        System.Console.WriteLine("Точка находится как минимум на одной из осей");
        return false;
    }
    return true;
}

int x = Prompt("Введите x > ");
int y = Prompt("Введите y > ");

if (x > 0 && y > 0)
{
    System.Console.WriteLine("1 четверть");
}
if (x > 0 && y < 0)
{
    System.Console.WriteLine("4 четверть");
}
if (x < 0 && y > 0)
{
    System.Console.WriteLine("2 четверть");
}
if (x < 0 && y < 0)
{
    System.Console.WriteLine("3 четверть");
}

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}

int x = Prompt("Введите X >");
int y = Prompt("Введите Y >");

if (!ValidateCoords(x, y))
{
    return;
}

System.Console.WriteLine($"{GetQuarter(x, y)} четверть");
