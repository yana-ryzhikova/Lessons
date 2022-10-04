// напишите программу, которая на вход принимает число
//и выдает его квадрат (т.е. умножает на само себя).
// например:  4->16? -7->49


int Prompt(string message)
{
    Console.WriteLine(message);
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32 (inputString);
    return value;
}

int value = Prompt("Введите число: ");
int square = value*value;
Console.WriteLine($"Квадрат числа {value} = {square}");


