using System;
class Program
{
 static void SelectRase()
    {
        string[] namesRase = {"People", "Elfs", "Orks", "Goblins", "Dwarf"};
        for (int i = 0; i <namesRase.Length-1; i++)
    {
        Console.Write(i+1 + " - " + namesRase[i] + ", ");
    }
        Console.WriteLine(namesRase.Length + " - " + namesRase[namesRase.Length-1] + ".");
        Console.WriteLine("What is your race?");
        int numberRace = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your race is " + namesRase[numberRace-1]);
    }

    static void SelectSex()
    {
        string[] namesSex = {"Man", "Woman"};
        for (int i = 0; i <namesSex.Length-1; i++)
    {
        Console.Write(i+1 + " - " + namesSex[i] + ", ");
    }
        Console.WriteLine(namesSex.Length + " - " + namesSex[namesSex.Length-1] + ".");
        Console.WriteLine("What is your sex?");
        int numberSex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You are a " + namesSex[numberSex-1]);
    }
    static void Main(string[] args)
    {
        SelectRase();
        SelectSex();
    }
}