// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mikä meininki? ");
var meininki = Console.ReadLine();
if (meininki == "hyvä" || meininki == "Hyvä")
    Console.WriteLine("Nice!");
else Console.WriteLine("Womp Womp!");