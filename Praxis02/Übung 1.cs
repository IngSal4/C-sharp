/*-----------------------------
HTBLA-Leonding / Class: 3 ACIF
-------------------------------
 Description:
  Read and write name

*/

using System;

string firstname;
string lastname;
string name;

Console.Write("Please enter firstname: ");
firstname = Console.ReadLine();

Console.Write("Please enter lastname: ");
lastname = Console.ReadLine();

Console.Write("Your name is: '");
Console.Write(firstname);
Console.Write(" ");
Console.Write(lastname);
Console.WriteLine("'");

Console.ReadLine();
/*
-----------------------------------------------
*/


Console.Write("Please enter firstname: ");
firstname = Console.Readline();

Console.Write("Please enter lastname: ");
lastname = Console.Readline();

name = firstname;
name = name + " ";
name = name + lastname;


Console.WriteLine("Your name is: ' " + name + "'");


Console.Readline();
 