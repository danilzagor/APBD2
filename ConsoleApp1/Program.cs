﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, User!!");
int[] arr = {3,3,5};
Console.WriteLine("Function get average");
Console.WriteLine(GetAvg(arr));
static double GetAvg(int[] arr)
{
    int summ = 0;
    foreach (var num in arr)
    {
        summ += num;
    }

    return (double)summ / arr.Length;
}