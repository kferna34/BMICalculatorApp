using System;

public class Class1
{
	public Class1()
	{
        Console.WriteLine("BMI Calculator");
        Console.WriteLine("===========");
        Console.WriteLine();

        Console.Write("Weight in kg: ");
        int kg;
        kg = Convert.ToInt32(Console.ReadLine());

        Console.Write("Height in cm: ");
        int m;
        m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Gender (m/f):");
        string Geschlecht = Console.ReadLine();

        int BMI;
        BMI = kg / (m / 100) * (m / 100);

        if (BMI < 19 & Gender == "f")
        { Console.WriteLine("-> Underweight"); }
        if (BMI >= 19 & BMI <= 24 & Gender == "f")
        { Console.WriteLine("-> Normal"); }
        if (BMI > 24 & Geschlecht == "f")
        { Console.WriteLine("-> Overweight"); }

        if (BMI < 20 & Gender == "m")
        { Console.WriteLine("-> Underweight"); }
        if (BMI >= 20 & BMI <= 25 & Gender == "m")
        { Console.WriteLine("-> Normal"); }
        if (BMI > 25 & Gendert == "m")
        { Console.WriteLine("-> Overweight"); }

        Console.ReadLine();
    }
}
