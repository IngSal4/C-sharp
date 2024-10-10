using System;


string input; //Deklaration einer Variable (Datentyp, Variablennamen)
int hour;
int day;

// Eingabe

Console.Write("Please enter hour: ");
input = Console.ReadLine(); //Assignement
hour = int.Parse(input); //wandelt die Zeichenkett in der Klammer() in ein integer um.
//oder
//hour = Convert.ToInt32(input); man verwendet aber eher die obere Variante


//oder hour = int.Parse(Console.ReadLine());


//Verarbeitung

day = hour / 24;    //9 durch 2 ist 4 und dann mal 2 ist 8 -> ganze Zahl(bei Integer, der Rest ist egal)
hour = hour % 24;   // Modulo Operator: speichert den Rest 47/24 bekommt man 23 heraus, bei 23/24 kommt 23 Rest raus, 5/24 kommt 5 Rest



//Ausgabe

Console.WriteLine($"{day}-{hour}"); //$ ist für eine Schablone, dann kann ich verschiedene Werte einfügen


Console.ReadLine();