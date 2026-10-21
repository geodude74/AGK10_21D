using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = new int[N];

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        int even = 0;
        int odd = 0;
        int max = arr[0];

        foreach (int num in arr)
        {
            if (num % 2 == 0)
                even++;
            else
                odd++;

            if (num > max)
                max = num;
        }

        Console.WriteLine($"{even} {odd} {max}");
    }
}
