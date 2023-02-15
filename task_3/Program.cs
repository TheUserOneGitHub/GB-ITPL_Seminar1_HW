// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine ("Please enter a number");
double number = Convert.ToDouble(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine ("The number is even");
}

else
{
    Console.WriteLine("The number is odd");
}