using System;

// 1
Func<int> getNumber = () => 1234;
Func<int, int> getSquare = x => x * x;  
Func<int, int, int> getAdd = (a, b) => a + b;

Console.WriteLine(getNumber());
Console.WriteLine(getSquare(3));
Console.WriteLine(getAdd(3, 5));
Console.WriteLine();

// 2
Action greeting = () => Console.WriteLine("안녕하세요!");
Action<string> greetMsg = msg => Console.WriteLine(msg);
Action<string, int> greetLoop = (msg, num) =>
{
    for (int i = 0; i < num; i++) { Console.WriteLine(msg); }
};
greeting();
greetMsg("Hello, Lambda!");
greetLoop("반복!", 3);
Console.WriteLine();

// 3
Func<int, int> anonymous = delegate (int x) { return x * x; };
Console.WriteLine(anonymous(2));
Func<int, int> square = x => x * x;
Console.WriteLine(square(2));
