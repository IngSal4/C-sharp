/*-----------------------------
HTBLA-Leonding / Class: 3 ACIF
-------------------------------
Ingrid Salinger
-------------------------------
 Description:
  Day of Year mit if/else
  
  
 */

using System;

int day;
int month;
string input1;
string input2;

//E
Console.Write("Please enter month [1...12]: ");
input1 = Console.ReadLine();
month = int.Parse(input1);
Console.Write("Please enter day [1...31]: ");
input2 = Console.ReadLine();
day = int.Parse(input2);


//V, A

if (month == 1) 
{
	if (day <= 31)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {0 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1  <= {day}  <= {31}");
	}
}

else if (month == 2)
{
	if (day <= 28)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {31 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 28");
	}
}

else if (month == 3)
{
	if (day <= 31)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {59 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
	}
}

else if (month == 4)
{
	if (day <= 30)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {90 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
	}
}

else if (month == 4)
{
	if (day <= 30)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {90 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
	}
}

else if (month == 5)
{
	if (day <= 31)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {120 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
	}
}

else if (month == 6)
{
	if (day <= 30)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {151 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
	}
}

else if (month == 7)
{
	if (day <= 31)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {181 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
	}
}

else if (month == 8)
{
	if (day <= 31)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {212 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
	}
}

else if (month == 9)
{
	if (day <= 30)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {243 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
	}
}

else if (month == 10)
{
	if (day <= 31)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {273 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
	}
}

else if (month == 11)
{
	if (day <= 30)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {304 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
	}
}

else if (month == 12)
{
	if (day <= 31)
	{
		Console.WriteLine($"Day of the year {month}:{day} = {334 + day}"); 
	}
	else 
	{
		Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
	}
}

else 
{
	Console.WriteLine("Ungueltige Eingabe! Geben Sie bei \"month\" ein Zahl zwischen 1 und 12 ein.");
}

Console.ReadLine();