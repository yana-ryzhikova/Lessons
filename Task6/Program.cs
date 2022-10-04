int value = new Random().Next(10, 100);
System.Console.WriteLine((value));
int result1 =  value % 10;
int result2 = value / 10;
if (result1 < result2)
{
    System.Console.WriteLine($"Первоe число {result2} больше второго числа {result1}");
}
else
{
    System.Console.WriteLine($"Второе число {result1} больше первого числа {result2}");
}