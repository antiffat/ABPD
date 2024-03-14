﻿public class Program
{
    public static void Main()
    {
        int[] numbers = { 3, 5, 8, 4, 1, 0, 1, 0 };
        double average = CalculateAverage(numbers);
        int max = FindMax(numbers);
        Console.WriteLine($"The calculated average is: {average}");
        Console.WriteLine($"The maximum value from the given array is: {max}");
    }

    public static double CalculateAverage(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Array must be not null or empty", nameof(nums));
        }

        double sum = 0;
        foreach (int number in nums)
        {
            sum += number;
        }

        return sum / nums.Length;
    }

    public static int FindMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array must be not null or empty", nameof(numbers));
        }

        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }
}
