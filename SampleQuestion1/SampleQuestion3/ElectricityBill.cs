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

   /* public ElectricityBill(string name, string accNo, int dayReadingCurrent, int dayReadingPrevious, int nightReadingCurrent, int nightReadingPrevious)
    {
        Name = name;
        AccountNo = accNo;
        DayReadingCurrent = dayReadingCurrent;
        DayReadingPrevious = dayReadingPrevious;
        NightReadingCurrent = nightReadingCurrent;
        NightReadingPrevious = nightReadingPrevious;
    }*/

    //methods
    public override string ToString()
    {
        return $"{Name} {AccountNo}";
    }



}

