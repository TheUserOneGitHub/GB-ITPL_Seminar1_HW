// Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.

Console.WriteLine ("Please enter a number");
double number = Convert.ToDouble(Console.ReadLine());
double number_test = 10;

//блок превращения любого отрицательного числа в положительное
if (number < 0)
{
    //Console.WriteLine("The number is a negative number");
    number = number * -1;
    //Console.WriteLine(number);
    //Console.WriteLine("Now the number is a positive");
} 

//блок проверки числа на разрядность (наличие второй цифры слева)
if (number / 10 < 1)
{
    //Console.WriteLine(number);
    Console.WriteLine(" The number has no second digit");
}

else
{
   // блок уменьшения разрядности целочисленной части до 2-значной (таким образом выделяем две первые цифры слева в целую часть, остальное перехеодит в дробную часть для последующего удаления)
while (number_test <= number)
{
    number_test = (number_test * 10);
}

number_test = number_test / 10;
number_test = number_test / 10;
//Console.WriteLine(number_test);
//Console.WriteLine(" - divider for the number");
number = number / number_test;
//Console.WriteLine(number);

// блок удаления дробной части из полученного числа
double number_fraction = number % 1;
//Console.WriteLine(number_fraction);
//Console.WriteLine(" - fractional part of the number");

number = number - number_fraction;
//Console.WriteLine(number);

// болк удаления десятков из нового числа и получение второй цифры слева от изначально введённого числа
while (number >= 10)
{
    number = number - 10;
}

Console.Write(number);
Console.Write(" is the second digit on the left in the number"); 
}