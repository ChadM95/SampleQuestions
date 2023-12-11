using System;
using System.Security.Principal;

namespace ConsoleApp1;

public class ElectricityBill
{
    //constants
    decimal DAY_UNIT = 0.42m, NIGHT_UNIT = 0.21m, VAT = 0.135m;

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
        output += string.Format("Day Units Used : {0} @ 42c per unit = {1:C}\n" , GetDayUnits(),GetDayUnitCost());
        output += string.Format("Night Units Used : {0} @ 21c per unit = {1:C}\n", GetNightUnits(),GetNightUnitCost());
        output += string.Format("{0,-22}{1,10:C}\n", "Subtotal :", GetSubtotal());
        output += string.Format("{0,-22}{1,10:C}\n", "VAT :", GetVAT());
        output += string.Format("{0,-22}{1,10:C}\n", "Total :", GetTotal());
        output += string.Format("{0,-22}{1,10:F2}\n", "Day Percentage :", GetDayPercent().ToString("P"));
        output += string.Format("{0,-22}{1,10:F2}\n", "Night Percentage :", GetNightPercent().ToString("P"));
        return output;
    }

    //work out day and night units by subtracting previous values from current ones
    //calculate percentage use day / night

    public int GetDayUnits()
    {
        return DayReadingCurrent - DayReadingPrevious;
    }

    public int GetNightUnits()
    {
        return NightReadingCurrent - NightReadingPrevious;
    }

    public decimal GetDayUnitCost()
    {
        return GetDayUnits() * DAY_UNIT;
    }

    public decimal GetNightUnitCost()
    {
        return GetNightUnits() * NIGHT_UNIT;
    }

    public decimal GetSubtotal()
    {
        return GetDayUnitCost() + GetNightUnitCost();
    }

    public decimal GetVAT()
    {
        return GetSubtotal() * VAT;
    }

    public decimal GetTotal()
    {
        return GetSubtotal() + GetVAT();
    }

    public double GetDayPercent()
    {
        int dayUse = GetDayUnits(), nightUse = GetNightUnits();
        int total = dayUse + nightUse;
        double dayPercent = dayUse / (double)total;
        return dayPercent;
    }

    public double GetNightPercent()
    {
        int dayUse = GetDayUnits(), nightUse = GetNightUnits();
        int total = dayUse + nightUse;
        double nightPercent = nightUse / (double)total;
        return nightPercent;
    }

}

