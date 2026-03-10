using System;

int[] nums = { 10, 25, 7, 42, 18, 33 };

Func<int[], int> AddNums = arr =>
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
};
Func<int[], int> MaxNums = arr =>
{
    int max = int.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) { max = arr[i]; }
    }
    return max;
};
Func<int[], int> MinNums = arr =>
{
    int min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) { min = arr[i]; }
    }
    return min;
};
Func<int[], int> EvenNums = arr =>
{
    int evenCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) { evenCount++; }
    }
    return evenCount;
};

Console.WriteLine($"배열: {string.Join(",", nums)}");
Console.WriteLine($"합계: {ProcessArray(nums, AddNums)}");
Console.WriteLine($"최댓값: {ProcessArray(nums, MaxNums)}");
Console.WriteLine($"최솟값: {ProcessArray(nums, MinNums)}");
Console.WriteLine($"짝수 개수: {ProcessArray(nums, EvenNums)}");


int ProcessArray(int[] data, Func<int[], int> processor)
{
    return processor(data);
}
