/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */


int InputNumber (string message)
{
    System.Console.Write(message); //ВВод приглашения
    string str = Console.ReadLine(); //Читаем строку с консоли
    return Int16.Parse(str);         //Преобразуем строку в число     
}

//Сумма чисел от 1 до number
int SumNumbers(int number)
{
    int sum = 0;                   //тут накапливаем сумму
    for(int i = 1; i <= number; i++)  //цикл от 1 до number
    {
        sum += i;                //sum = sum + i суммируем

    }
    return sum;   //возврат суммы из метода
}

// проверка на правильность ввода
bool ValidateNumber(int number)
{
    if (number < 1) // При числе меньше чем 1 не работаем
    {
        System.Console.WriteLine("Число меньше единицы, сумма не считается");
        return false;
    }
    return true;
}
int n = InputNumber("Введите число > ");
if (ValidateNumber(n))
{
    int result = SumNumbers(n);
    System.Console.WriteLine($"Сумма чисел от 1 до {n} равна {result}");
}
