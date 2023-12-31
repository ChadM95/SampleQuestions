﻿namespace SampleQuestion4_1_;

class Program
{
    static void Main(string[] args)
    {
        //setup variables
        string name, accNo;
        int dayCurrent, dayPrevious, nightCurrent, nightPrevious;

        //get user input
        GetUserInput(out name, out accNo, out dayCurrent, out dayPrevious, out nightCurrent, out nightPrevious);

        //create object
        ElectricityBill eb1 = new ElectricityBill(name,accNo,dayCurrent,dayPrevious,nightCurrent,nightPrevious);

        //display
        Console.WriteLine(eb1);

        //pause program
        Console.ReadLine();
    }

    public static void GetUserInput(out string name, out string accNo, out int dayCurrent, out int dayPrevious, out int nightCurrent, out int nightPrevious)
    {
        Console.Write("enter name > ");
        name = Console.ReadLine();
        Console.Write("enter Account Number > ");
        accNo = Console.ReadLine();
        Console.Write("enter current day reading > ");
        dayCurrent = int.Parse(Console.ReadLine());
        Console.Write("enter previous day reading > ");
        dayPrevious = int.Parse(Console.ReadLine());
        Console.Write("enter current night reading > ");
        nightCurrent = int.Parse(Console.ReadLine());
        Console.Write("enter previous night reading > ");
        nightPrevious = int.Parse(Console.ReadLine());
    }

}

