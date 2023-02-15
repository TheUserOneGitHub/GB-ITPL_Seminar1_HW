// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Please enter first number");
double num_1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Please enter second number");
double num_2 = Convert.ToDouble(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine ("The first number is greater than the second number");
}

if (num_1 < num_2)
{
    Console.WriteLine ("The second number is greater than the first number");
}

if (num_1 == num_2)
{
    Console.WriteLine ("The first number is equal to the second number");
}