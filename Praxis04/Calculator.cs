/*-----------------------------
HTBLA-Leonding / Class: 3 ACIF
-------------------------------
Ingrid Salinger
-------------------------------
 Description:
  Calculator
  
*/

using System;

string input1;
string input2;
double number1;
double number2;
string op;

//E
Console.WriteLine("*******************************************");
Console.WriteLine("*  Calculator - Ihr Zahlenbegleiter       *");
Console.WriteLine("*                                         *");
Console.WriteLine("*******************************************");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("1.Zahl eingeben: ");
input1 = Console.ReadLine();
number1 = double.Parse(input1);
Console.WriteLine("2.Zahl eingeben: ");
input2 = Console.ReadLine();
number2 = double.Parse(input2);
Console.WriteLine("Operation eingeben [ + - * /] : ");
op = Console.ReadLine();


if (op == "*")
{
	Console.WriteLine($"Ergebnis von {number1} * {number2} = {number1 * number2}");
}

else if (op == "+")
{
	Console.WriteLine($"Ergebnis von {number1} + {number2} = {number1 + number2}");
}
else if (op == "-")
{
	Console.WriteLine($"Ergebnis von {number1} - {number2} = {number1 - number2}");
}
else if (op == "/")
{
	if (number2 == 0)
	{
		Console.WriteLine("Einfacher Rechner");
		Console.WriteLine("=================");
		Console.WriteLine("");
		Console.WriteLine($"Linker Operand [double]: {number1}");
		Console.WriteLine($"Operation [+ - * /]: {op}");
		Console.WriteLine($"Rechter Operand [double]: {number2}");
		Console.WriteLine("Division durch 0 ist nicht erlaubt!");
	}
	else
	{
		Console.WriteLine($"Ergebnis von {number1} / {number2} = {number1 / number2}");
	}
}

else
{
	Console.WriteLine("Falsche Rechenart");
}

Console.ReadLine();