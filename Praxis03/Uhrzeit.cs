/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3 ACIF
 *--------------------------------------------------------------
 *              Ingrid Salinger
 *--------------------------------------------------------------
 * Description:
 * seconds with format d:hh:mm:ss
 *--------------------------------------------------------------
*/



using System;


string input; 
int totalSeconds;
int minutes;
int hours;
int seconds;
int totalMinutes;
int totalHours;
int days;

//Eingabe

Console.Write("Please enter seconds: ");
input = Console.ReadLine(); 
totalSeconds = int.Parse(input);

//Verarbeitung

seconds      = totalSeconds % 60;
totalMinutes = totalSeconds / 60;
 
minutes      = totalMinutes % 60;
totalHours   = totalMinutes / 60; 

hours        = totalHours % 24;
days         = totalHours /24;
   

//Ausgabe

Console.WriteLine($"Converted to format d:hh:mm:ss {days} Tag(e) {hours:00}:{minutes:00}:{seconds:00}"); 


Console.ReadLine();
