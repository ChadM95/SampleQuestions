using System;
using System.Security.Principal;

namespace ConsoleApp1;

public class ElectricityBill
{
  //properties
    public string Name { get; set; }
    public string AccountNo { get; set; }
    public int DayReadingCurrent { get; set; }
    public int DayReadingPrevious { get; set; }
    public int NightReadingCurrent { get; set; }
    public int NightReadingPrevious { get; set; }

  //ctors

    public ElectricityBill(string name, string accNo, int dayReadingCurrent, int dayReadingPrevious, int nightReadingCurrent, int nightReadingPrevious)
    {
        Name = name;
        AccountNo = accNo;
        DayReadingCurrent = dayReadingCurrent;
        DayReadingPrevious = dayReadingPrevious;
        NightReadingCurrent = nightReadingCurrent;
        NightReadingPrevious = nightReadingPrevious;
    }

  //methods
    public override string ToString()
    {
        string output = "";
        string formatter = "{0,-22}{1,10}\n";
        output += string.Format("--------------------------------------------\n");
        output += string.Format(formatter,"Name :", Name);
        output += string.Format(formatter,"Account Number :", AccountNo);
        output += string.Format(formatter,"Current Day Reading :", DayReadingCurrent);
        output += string.Format(formatter,"Previous Day Reading :", DayReadingPrevious);
        output += string.Format(formatter,"Current Night Reading :", NightReadingCurrent);
        output += string.Format(formatter,"Previous Night Reading :", NightReadingPrevious);
        return output;
    }

    public static void GetUserInput(out string name, out string accNo, out int dayReadingCurrent, out int dayReadingPrevious, out int nightReadingCurrent, out int nightReadingPrevious)
    {
        Console.Write("Enter Name >> ");
        name = Console.ReadLine();
        Console.Write("Enter Account Number >> ");
        accNo = Console.ReadLine();
        Console.Write("Enter Current Day Reading >> ");
        dayReadingCurrent = int.Parse(Console.ReadLine());
        Console.Write("Enter Previous Day Reading >> ");
        dayReadingPrevious = int.Parse(Console.ReadLine());
        Console.Write("Enter Current Night Reading >> ");
        nightReadingCurrent = int.Parse(Console.ReadLine());
        Console.Write("Enter Previous Night Reading >> ");
        nightReadingPrevious = int.Parse(Console.ReadLine());
    }

}

