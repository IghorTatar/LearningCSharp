using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] arr = new int[20];
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-100, 101);
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
        int sum = 0, comp = 1;
        int max = -101, max2 = -101, min = 101, min2 = 101;
        int ind_max = 0, ind_max2 = 0, ind_min = 0, ind_min2 = 0;
        for (int i = 0; i < arr.Length; i += 1)
        {
            sum += arr[i];
            comp *= arr[i];
            if (arr[i] > max && arr[i] > max2)
            {
                max = arr[i];
                ind_max = i;
            }
            else if (arr[i] < max && arr[i] > max2)
            {
                max2 = arr[i];
                ind_max2 = i;
            }
            if (arr[i] < min && arr[i] < min2)
            {
                min = arr[i];
                ind_min = i;
            }
            else if (arr[i] > min && arr[i] < min2)
            {
                min2 = arr[i];
                ind_min2 = i;
            }
        }
        Console.WriteLine($"Минимальное число - {min}, его индекс - {ind_min}\nМаксимальное число - {max}, его индекс - {ind_max}\nСумма элементов массива - {sum}, произведение - {comp}\nСреднее арифметическое элементов массива - {sum / arr.Length}\nВторое минимальное число - {min2}, его индекс - {ind_min2}\nВторое максимальное число - {max2}, его индекс - {ind_max2}");
    }
}