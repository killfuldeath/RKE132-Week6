﻿

//string[] fruit = { "apples", "bananas", "oranges" };

using System.Linq.Expressions;

string[] fruit = new string[3];


fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitarraylength = fruit.Length;

Console.WriteLine($"There are {fruitarraylength} in your array.");

for (int i = 0; i < fruitarraylength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach (string element in fruit)
{
    Console.WriteLine(element);
}