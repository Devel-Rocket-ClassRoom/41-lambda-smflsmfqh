using System;
using System.Collections.Generic;

// 1
Predicate<int> threes = x => x % 3 == 0;
Predicate<int> squares = x =>
{
    int sqrt = (int)Math.Sqrt(x);
    return x == sqrt * sqrt;
};
Console.WriteLine("3의 배수: ");
Console.WriteLine(string.Join(" ", FindNumbers(threes)));
Console.WriteLine("제곱수: ");
Console.WriteLine(string.Join(" ", FindNumbers(squares)));
Console.WriteLine();


static List<int> FindNumbers(Predicate<int> predicate)
{
    List<int> results = new List<int>();    
    for (int i = 1; i <= 100; i++)
    {
        if (predicate(i)) {  results.Add(i); }
    }
    return results;
}

// 2
Predicate<int> isEven = x => x % 2 ==0;
Predicate<int> isOdd = x => x % 2 != 0;

Console.WriteLine(isEven(4));
Console.WriteLine(isOdd(4));
Console.WriteLine();

// 3
int factor = 2;
Func<int, int> multiplier = n => n * factor;
Console.WriteLine(multiplier(3));
factor = 10;
Console.WriteLine(multiplier(3));
Console.WriteLine();

// 4
int count = 0;
Action increment = () => count++;
increment();
increment();
increment();

Console.WriteLine(count);
Console.WriteLine();

// 5
var counter = CreateCounter();

Console.WriteLine(counter());
Console.WriteLine(counter());
Console.WriteLine(counter());

static Func<int> CreateCounter()
{
    int counter = 0;    
    return () => counter++;
}
