// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, User!!");
int[] arr = {3,2,5,6,8,12,123,3,5};
Console.WriteLine("Function get average");
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