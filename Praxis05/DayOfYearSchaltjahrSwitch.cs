/*-----------------------------
HTBLA-Leonding / Class: 3 ACIF
-------------------------------
Ingrid Salinger
-------------------------------
 Description:
  Day of year mit Schaltjahr und switch
  
*/

using System;

int day;
int month;
string input1;
string input2;
string input3;


Console.Write("Please enter month [1...12]: ");
input1 = Console.ReadLine();
month = int.Parse(input1);

if ((month < 1) || (month >12))
{
	Console.WriteLine("Ungueltige Eingabe! Geben Sie bei \"month\" ein Zahl zwischen 1 und 12 ein.");
	return;
}


Console.Write("Please enter day [1...31]: ");
input2 = Console.ReadLine();
day = int.Parse(input2);

Console.Write("Berechnung fuer ein Schaltjahr [j/n]: ");
input3 = Console.ReadLine();






if (input3 == "n")
{
	switch (month)
	{
		case 1:
		
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {0 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1  <= {day}  <= {31}");
			}
			break;

		case 2:
		
			if (day <= 28)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {31 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 28");
			}
			break;

		case 3:
		
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {59 + day}"); 
			}
			else 
			{
			Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;

		case 4:
		
			if (day <= 30)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {90 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
			}
			break;

		case 5:
		
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {120 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;

		case 6:
		
			if (day <= 30)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {151 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
			}
			break;

		case 7:
		
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {181 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;

		case 8:
		
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {212 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;

		case 9:
		
			if (day <= 30)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {243 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
			}
			break;

		case 10:
			
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {273 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;

		case 11:
		
			if (day <= 30)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {304 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
			}
			break;

		case 12:
			
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {334 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;
	
		
	}
}

else
{
	switch (month)
	{
		case 1:
		
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {0 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1  <= {day}  <= {31}");
			}
			break;

		case 2:
		
			if (day <= 29)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {31 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 29");
			}
			break;

		case 3:
		
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {60 + day}"); 
			}
			else 
			{
			Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;

		case 4:
		
			if (day <= 30)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {91 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
			}
			break;

		case 5:
		
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {121 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;

		case 6:
		
			if (day <= 30)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {152 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
			}
			break;

		case 7:
		
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {182 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;

		case 8:
		
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {213 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;

		case 9:
		
			if (day <= 30)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {244 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
			}
			break;

		case 10:
			
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {274 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;

		case 11:
		
			if (day <= 30)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {305 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 30");
			}
			break;

		case 12:
			
			if (day <= 31)
			{
				Console.WriteLine($"Day of the year {month}:{day} = {335 + day}"); 
			}
			else 
			{
				Console.WriteLine($"Ungueltiger Tag: Im Monat {month} gilt: 1 <= {day} <= 31");
			}
			break;
	
		
	}
}

Console.ReadLine();