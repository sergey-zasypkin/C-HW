// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Type any number and I will show a cube table from 1 till your number: ");

int i = Convert.ToInt32(Console.ReadLine());
int temp = 1;

while(temp < i || temp == i)
{
    Console.Write(Math.Pow(temp, 3) + " ");
    temp++;
}
