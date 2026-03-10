using System;

// 1
{
    PrintMessage hello = () => Console.WriteLine("안녕하세요.");
    hello();
    Console.WriteLine();
}

// 2
{
    Transformer square = x => x * x;
    Console.WriteLine(square(3));
    Console.WriteLine(square(4));
    Console.WriteLine();
}
// 3
{
    IsLonger isLonger = (msg, x) => msg.Length > x;
    Console.WriteLine(isLonger("안녕하세요.", 5));
    Console.WriteLine(isLonger("반갑습니다.", 10));
    Console.WriteLine();
}

// 4
{
    Greeting greeting = () =>
    {
        Console.WriteLine("안녕하세요.");
        Console.WriteLine("반갑습니다.");
    };
    greeting();
    Console.WriteLine();
}

// 5
{
    Calculator calc = (a, b) =>
    {
        int result = a + b;
        Console.WriteLine($"{a} + {b} = {result}");
        return result;
    };

    int sum = calc(3, 5);
    Console.WriteLine($"합계: {sum}");
}

// 5
delegate int Calculator(int x, int b);

// 4
delegate void Greeting();


// 3
delegate bool IsLonger(string msg, int x);

// 1
delegate void PrintMessage();

// 2
delegate int Transformer(int x);
