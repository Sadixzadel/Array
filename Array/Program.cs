using Homework3;
using System;

int size = 11;

var array = new MyArray(size);
Console.WriteLine(array);

array.Sort(size);
Console.WriteLine(array);

array.Reverse(size);
Console.WriteLine(array);