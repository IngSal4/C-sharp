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
string input2;
double distance;
double speed;
double time;
double min;
double sec;
int hour;
int intmin;


//E
Console.Write("Entfernung in km: ");
input1 = Console.ReadLine();
distance = double.Parse(input1);
Console.Write("Geschwindigkeit in km/h: ");
input2 = Console.ReadLine();
speed = double.Parse(input2);

 
//V
time = distance / speed;
hour = (int)time;
min = time - hour;
min = min * 60;
intmin = (int)min;
sec = min - intmin;
sec = sec * 60;


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