﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, User!!");
int[] arr = {1,2,3,4,5};
Console.WriteLine(GetAvg(arr));

static double GetAvg(int[] arr)
{
    int sum = 0;
    foreach (var num in arr)
    {
        sum += num;
    }

    return (double)sum / arr.Length;
}