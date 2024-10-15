/*-----------------------------
HTBLA-Leonding / Class: 3 ACIF
-------------------------------
Ingrid Salinger
-------------------------------
 Description:
  Besuch der Tante
*/



using System;

string input1;
string input2 = "";
string input3;
string input4 = "";
double distance;
double speed = 0;
double time = 0;
double min;
double sec;
double timeUser = 0;
int hour;
int intmin;


//E
Console.Write("Entfernung in km: ");
input1 = Console.ReadLine();
distance = double.Parse(input1);

Console.Write("Geben Sie an, ob Sie die Fahrtdauer (mit dem Symbol f) oder die Geschwindigkeit (mit dem Symbol v) eingeben wollen: ");
input3 = Console.ReadLine();

if (input3 == "v")
{
	Console.Write("Geschwindigkeit in km/h: ");
	input2 = Console.ReadLine();
	speed = double.Parse(input2);
}
else 
{
	Console.Write("Fahrtdauer in Stunden und mit Komma angeben: ");
	input4 = Console.ReadLine();
	timeUser = double.Parse(input4);
}


//V
if (input3 == "v")
{
	time   = distance / speed;
	hour   = (int)time;
	min    = time - hour;
	min    = min * 60;
	intmin = (int)min;
	sec    = min - intmin;
	sec    = sec * 60;
	
}
else
{
	speed = distance / timeUser;
	hour   = (int)timeUser;
	min    = timeUser - hour;
	min    = min * 60;
	intmin = (int)min;
	sec    = min - intmin;
	sec    = sec * 60;
	
	time = timeUser;
}

hour = hour + 10;


//A

if (hour < 12)
    {
        Console.WriteLine($"Fuer die Strecke von {distance:f} km benoetigen Sie {time:f4} Stunden. Sie kommen um {hour:00}:{intmin:00}:{sec:00} an. Das Mittagessen geht sich noch aus.");

    }
else
    {
        Console.WriteLine($"Fuer die Strecke von {distance:f} km benoetigen Sie {time:f4} Stunden. Sie kommen um {hour:00}:{intmin:00}:{sec:00} an. Es gibt Kaffee und Kuchen."); 
		
		if (hour >19)
	{
		Console.WriteLine("ACHTUNG - es ist schon dunkel!");
	}
    }




Console.ReadLine();