/*-----------------------------
HTBLA-Leonding / Class: 3 ACIF
-------------------------------
Ingrid Salinger
-------------------------------
 Description:
  Read and write name and residence

*/
using System;

string name;
string residence;

Console.Write("Please enter your name: ");
name = Console.ReadLine();

Console.Write("Please enter your residence: ");
residence = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("************************");
Console.WriteLine("*   " + name);
Console.WriteLine("************************");
Console.WriteLine("*   " + residence);
Console.WriteLine("************************");


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("************************");
Console.WriteLine($"*   {name,-18} *");
Console.WriteLine("************************");
Console.WriteLine($"*   {residence,-18} *");
Console.WriteLine("************************");

Console.ReadLine();


