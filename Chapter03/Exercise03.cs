using System;
using System.ComponentModel;

public class Exercise03{

    public void FizzBuzz()
    {
        bool fizz, buzz;
        for (int i = 1; i <= 100; i++)
        {
            fizz = (i % 3 == 0);
            buzz = (i % 5 == 0);
            if (fizz && buzz) Console.Write("fizzbuzz ");
            else if (fizz) Console.Write("fizz ");
            else if (buzz) Console.Write("buzz ");
            else Console.Write(i + " ");
        }
        Console.WriteLine("");
        return;
    }

    public void FixedOverflowCodeExecution()
    {
        //Q: What will happen if this code executes?
        //A: It'll be an infinite loop. The max value of byte is 2^8-1 = 255 so i can never be greater than 500
        /*int max = 500;
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
        }
        return;*/

        int max = 500;
        if (max>byte.MaxValue) throw new OverflowException("Overflow!!!");

        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
        }
        return;

    }

    public void GuessNumber()
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.Write("Guess a number between 1 and 3 ");
        int guessedNumber = int.Parse(Console.ReadLine());
        if (guessedNumber==correctNumber) Console.WriteLine("Correct!");
        else if (guessedNumber<1||guessedNumber>3) Console.WriteLine("Out of range");
        else if (guessedNumber<correctNumber) Console.WriteLine("Too low");
        else if (guessedNumber>correctNumber) Console.WriteLine("Too high");
        else Console.WriteLine("Invalid number");
    }

    public void PrintPyramid(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n-i; j++) Console.Write(" ");
            for (int j = 0; j < 2*i+1; j++) Console.Write("*");           
            Console.Write("\n");
        }
    }

    public void Anniversary10K(DateTime birthDate)
    {
        TimeSpan ageInDays = DateTime.Now - birthDate;
        int days = ageInDays.Days;
        int daysToNextAnniversary = 10000 - (days % 10000);
        DateTime nextAnniversary = DateTime.Now.AddDays(daysToNextAnniversary);
        Console.WriteLine($"Birthdate {birthDate} will have next 10,000-day anniversary on {nextAnniversary}");
    }

    public void Greetings()
    {
        int now = DateTime.Now.Hour;
        if (now>5&&now<=12) Console.WriteLine("Good Morning");
        if (now>12&&now<=(5+12)) Console.WriteLine("Good Afternoon");
        if (now>(5+12)&&now<=(10+12)) Console.WriteLine("Good Evening");
        if (now>(10+12)||now<=5) Console.WriteLine("Good Night");
    }

    public void Counting()
    {
        for(int i = 1; i <= 4; i++)
        {
            for (int j = 0; j <= 24; j++)
            {
                if (j % i == 0)
                {
                    Console.Write(j);
                    if (j != 24) Console.Write(",");
                }
            }
            Console.Write("\n");
        }
    }

}

public class Program
{
   public static void Main()
    {
        Exercise03 exercise03 = new Exercise03();
        exercise03.FizzBuzz();
        //exercise03.FixedOverflowCodeExecution();
        //exercise03.GuessNumber();
        exercise03.PrintPyramid(5);
        DateTime birthDate = new DateTime(1995, 1, 1);
        exercise03.Anniversary10K(birthDate);
        exercise03.Greetings();
        exercise03.Counting();
    }
}

