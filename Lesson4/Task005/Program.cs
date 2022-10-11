/* Напишите программу, которая из массива случайных чисел. 
Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
Постарайтесь сделать одним циклом 
[1, 3, 5, 6, 6, 4] -> 5 */


int[] arr = { 5, 1, 1, 3, 2 };

int max = arr[0];
int max2 = arr[0];


for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i])
    {
        max2 = max;
        max = arr[i];
    }
    // else if (max2 == max)//(max2 < arr[i] && arr[i] != max)
    //     for (i = 0; i < arr.Length; i++)
    //     {
    //         if (max2 < arr[i])
    //         {
    //             max2 = arr[i];
    //         }
    //     }
}
System.Console.WriteLine(max);
System.Console.WriteLine(max2);
