/*-----------------------------
HTBLA-Leonding / Class: 3 ACIF
-------------------------------
Ingrid Salinger
-------------------------------
 Description:
  GrownUpCalculator
  
*/

using System;

string input;
int age = 0;
int grownUp = 0;

Console.Write("Bitte geben Sie Ihr Alter ein: ");
input = Console.ReadLine();
age = int.Parse(input);

if ((age >= 18) && (age <= 20))
{
	Console.WriteLine("Grown Up");
}
else
{
	if (age <=18)
	{
		if (age <=15)
		{
		Console.WriteLine($"Es dauert noch sehr lange bis 18 Jahre!");	
		}
		else
		{
		grownUp = 18 - age;
		Console.WriteLine($"Es fehlen noch {grownUp} Jahre bis zur Volljaehrigkeit");
		}
	}
	else
	{
		if (age == 25)
		{
			Console.WriteLine($"Alles Gute zum runden Geburtstag!");
		}
		else
		{
			if ((age >= 65) && (age <= 120))
			{
				if ( age == 75)
				{
				Console.WriteLine($"Alles Gute zum runden Geburtstag!");
				}
				else
				{
					Console.WriteLine("Hallo Senior!");
				}
			}
			else
			{
				if (age == 50)
				{
					Console.WriteLine($"Alles Gute zum runden Geburtstag!");
				}
				else if (age > 120)
				{
					Console.WriteLine("Hallo Zombi!");
				}
				else
				{
					Console.WriteLine("Guten Tag!");
				}
		}	}
	}
}