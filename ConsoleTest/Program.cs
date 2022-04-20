// See https://aka.ms/new-console-template for more information

using System;
using ConsoleTest;

// For this case: 11 is total drinking plan. 3 is number of condition to get the gift, 1 is the gift
var res = AbstractSolution.CalculateTheQuantity(11, 3, 1);
res.Switch(Console.WriteLine, e => Console.WriteLine($"Error is : {e}"));