/*-----------------------------
HTBLA-Leonding / Class: 3 ACIF
-------------------------------
Ingrid Salinger
-------------------------------
 Description:
  Enter a day of the week
  
 
*/

using System;


string letter;
string letter2;


//E
Console.Write("Geben Sie den 1. Buchstaben eines Wochentags ein: M fuer Montag, D fuer Dienstag, M fuer Mittwoch, D fuer Donnerstag, F fuer Freitag, S fuer Samstag und S fuer Sonntag: ");
letter = Console.ReadLine();
 
 

switch (letter)
{
    case "M":
        Console.WriteLine("Geben Sie nun den 2. Buchstaben Ihres Wochentags ein (o oder i): ");
        letter2 = Console.ReadLine();
		if (letter2 == "o")
		{
			Console.WriteLine("Sie haben Montag ausgewaehlt.");
		}
		else if (letter2 == "i")
		{
			Console.WriteLine("Sie haben Mittwoch ausgewaehlt.");
		}
		else
		{
			Console.WriteLine("Falscher Buchstabe.");
		}
		break;
		
    case "D":
        Console.WriteLine("Geben Sie nun den 2. Buchstaben Ihres Wochentags ein (i oder o): ");
        letter2 = Console.ReadLine();
		if (letter2 == "i")
		{
			Console.WriteLine("Sie haben Dienstag ausgewaehlt.");
		}
		else if (letter2 == "o")
		{
			Console.WriteLine("Sie haben Donnerstag ausgewaehlt.");
		}
		else
		{
			Console.WriteLine("Falscher Buchstabe.");
		}
		break;
		
    case "F":
        Console.WriteLine("Sie haben Freitag ausgewaehlt.");
        break;
    
	case "S":
        Console.WriteLine("Geben Sie nun den 2. Buchstaben Ihres Wochentags ein (a oder o): ");
        letter2 = Console.ReadLine();
		if (letter2 == "a")
		{
			Console.WriteLine("Sie haben Samstag ausgewaehlt.");
		}
		else if (letter2 == "o")
		{
			Console.WriteLine("Sie haben Sonntag ausgewaehlt.");
		}
		else
		{
			Console.WriteLine("Falscher Buchstabe.");
		}
		break;
    
	default:
        Console.WriteLine("Diesen Wochentag gibt es nicht!");
        break;
}

Console.ReadLine();