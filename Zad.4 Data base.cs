// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int n = int.Parse(Console.ReadLine());
int centuries=n;
int years = n * 100;
double days = years * 365.2422;
long hours = 0;
long minutes = 0;
Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");