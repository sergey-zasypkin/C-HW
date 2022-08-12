// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Type any 5 digit number: ");
string init = Convert.ToString(Console.ReadLine());

if(init.Length == 5)
{
    if(init[0] == init[4] && init[1] == init[3])
    {
        Console.WriteLine(init + " is a palindrome");
    }
    else
    {
        Console.WriteLine(init + " is not a palindrome");
    }
}
else
{
    Console.WriteLine("Error. Please type a five-digit number");
}

// код получился не совсем универсальным. Работает только с пятью знаками.