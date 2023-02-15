// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine ("Please enter first number");
double num_1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Please enter second number");
double num_2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Please enter third number");
double num_3 = Convert.ToDouble(Console.ReadLine());

double num_max = num_1;
double num_next = num_2;

if (num_1 > num_next)
{
    num_max = num_1;
    num_next = num_3;

    if (num_1 > num_next)
    {
       Console.WriteLine ("The first number is the maximum number"); 
    }

    else
    {
        Console.WriteLine ("The third number is the maximum number"); 
    }
}

else 
{
    num_max = num_2;
    num_next = num_3;

    if (num_2 > num_next)
    {
       Console.WriteLine ("The second number is the maximum number"); 
    }

    else
    {
        Console.WriteLine ("The third number is the maximum number"); 
    }

}