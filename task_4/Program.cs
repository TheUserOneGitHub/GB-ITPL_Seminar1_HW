// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine ("Please enter a natural number");
int number = Convert.ToInt32(Console.ReadLine());
int number_even = 2;

if (number % 2 == 0)
{
    while (number_even < number + 1)
    {
        Console.WriteLine(number_even);
        number_even = (number_even + 2);
    }
}

else
{
    number = (number - 1);

    while (number_even < number + 1)
    {
        Console.WriteLine(number_even);
        number_even = (number_even + 2);  
    }
}