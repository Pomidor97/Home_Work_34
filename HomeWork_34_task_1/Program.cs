using System;
using HomeWork_34_task_1;

int[] numbers = { 5, 3, 8, 1, 2 };
ArrayHelper<int> intHelper = new ArrayHelper<int>();
intHelper.Sort(numbers);
Console.WriteLine("Отсортированный массив: " + string.Join(", ", numbers));

intHelper.Reverse(numbers);
Console.WriteLine("Развернутый массив: " + string.Join(", ", numbers));

string[] words = { "apple", "banana", "cherry" };
ArrayHelper<string> stringHelper = new ArrayHelper<string>();
stringHelper.Sort(words);
Console.WriteLine("Отсортированный массив: " + string.Join(", ", words));

stringHelper.Reverse(words);
Console.WriteLine("Развернутый массив: " + string.Join(", ", words));