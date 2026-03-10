using System;
using System.Collections.Generic;

// 1
Action[] actions = new Action[3];

for (int i = 0; i < actions.Length; i++)
{
    actions[i] = () => Console.Write(i);
}

foreach(Action action in actions)
{
    action(); 
}
Console.WriteLine();
Console.WriteLine();


// 2
Action[] actions1 = new Action[3];

for (int i = 0; i < actions1.Length; i++)
{
    int loopVar = i;
    actions1[i] = () => Console.Write(loopVar);
}

foreach (Action action in actions1)
{
    action();
}
Console.WriteLine();
Console.WriteLine();


// 3
string[] names = { "김철수", "이영희", "박민수", "최지연" };
Array.Sort(names, (a, b) => a.Length.CompareTo(b.Length));
Console.WriteLine("이름 길이순 정렬:");
Console.WriteLine(string.Join("\n", names));
Console.WriteLine();
Array.Sort(names, (a, b) => b.CompareTo(a));
Console.WriteLine("역순 정렬:");
Console.WriteLine(string.Join("\n", names));

