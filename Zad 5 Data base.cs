// See https://aka.ms/new-console-template for more information
using System.Security;

Console.WriteLine("Hello, World!");

int input = int.Parse(Console.ReadLine());
bool special = false;
int sumOfD = 0;
int j = input;
for (int i = 1; i <= j; i++)
{
    int k = i;
    while (k > 0)
    {
        sumOfD = sumOfD + (k % 10);
        k = k / 10;
    }

    if(sumOfD ==5|| sumOfD == 7 || sumOfD == 11) { special = true; }
    Console.WriteLine($"{i} -> {special} ");
    special = false;
    sumOfD = 0;
}
