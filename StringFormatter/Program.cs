using System;

Func<string, string> toUpper = msg => msg.ToUpper();
Func<string, string> mask = msg => msg.Substring(0, 2).PadRight(msg.Length - 2, '*');
Func<string, string> greet = name => $"안녕하세요, {name}님!";

ApplyAndPrint("hello world", toUpper);
ApplyAndPrint("SecretCode", mask);
ApplyAndPrint("민수", greet);

void ApplyAndPrint(string input, Func<string, string> formatter)
{
    Console.WriteLine(formatter(input));
}
