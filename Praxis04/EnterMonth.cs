/*-----------------------------
HTBLA-Leonding / Class: 3 ACIF
-------------------------------
Ingrid Salinger
-------------------------------
 Description:
  Enter a month
  
 
*/

using System;


string letter;
string letter2;
string letter3;


//E
Console.Write("Geben Sie den 1. Buchstaben eines Monats ein: ");
letter = Console.ReadLine();
 
 

switch (letter)
{
    case "J":
		Console.WriteLine("Geben Sie nun den 2. Buchstaben Ihres Monats ein (a oder u): ");
        letter2 = Console.ReadLine();
		if (letter2 == "a")
		{
			Console.WriteLine("Sie haben Jaenner ausgewaehlt.");
		}
		else if (letter2 == "u")
		{
			Console.WriteLine("Geben Sie nun den 3. Buchstaben Ihres Monats ein (n oder l): ");
			letter3 = Console.ReadLine();
			if (letter3 == "n")
			{
				Console.WriteLine("Sie haben Juni ausgewaehlt.");
			}
			else if (letter3 == "l")
			{
				Console.WriteLine("Sie haben Juli ausgewaehlt.");
			}
			else
			{
				Console.WriteLine("Falscher Buchstabe.");
			}
		}
		break;
		
	case "F":
		Console.WriteLine("Sie haben Februar ausgewaehlt.");
        break;
	
	case "M":
        Console.WriteLine("Geben Sie nun den 3. Buchstaben Ihres Monats ein (r oder i): ");
        letter3 = Console.ReadLine();
		if (letter3 == "r")
		{
			Console.WriteLine("Sie haben Maerz ausgewaehlt.");
		}
		else if (letter3 == "i")
		{
			Console.WriteLine("Sie haben Mai ausgewaehlt.");
		}
		else
		{
			Console.WriteLine("Falscher Buchstabe.");
		}
		break;
		
	case "S":
		Console.WriteLine("Sie haben September ausgewaehlt.");
        break;
		
    case "A":
        Console.WriteLine("Geben Sie nun den 2. Buchstaben Ihres Wochentags ein (p oder u): ");
        letter2 = Console.ReadLine();
		if (letter2 == "p")
		{
			Console.WriteLine("Sie haben April ausgewaehlt.");
		}
		else if (letter2 == "u")
		{
			Console.WriteLine("Sie haben August ausgewaehlt.");
		}
		else
		{
			Console.WriteLine("Falscher Buchstabe.");
		}
		break;
		
    case "O":
        Console.WriteLine("Sie haben Oktober ausgewaehlt.");
        break;
    
	case "N":
        Console.WriteLine("Sie haben November ausgewaehlt.");
        break;
	
	case "D":
        Console.WriteLine("Sie haben Dezember ausgewaehlt.");
        break;
	
    
	default:
        Console.WriteLine("Diesen Monat gibt es nicht!");
        break;
}

Console.ReadLine();