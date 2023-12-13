using System;
using System.Runtime.ConstrainedExecution;

namespace SampleQuestion4_1_
{
    public class ElectricityBill
	{
		//constants
		const decimal DAY_UNIT = 0.42m;
		const decimal NIGHT_UNIT = 0.21m ;
        const decimal VAT = 0.135m ;

        //properties
        public string Name { get; set; }
		public string AccNo { get; set; }
		public int DayCurrent { get; set; }
		public int DayPrevious { get; set; }
		public int NightCurrent { get; set; }
		public int NightPrevious { get; set; }

		//ctors
		public ElectricityBill()
		{
		}

		public ElectricityBill(string name, string accNo, int dayCurrent, int dayPrevious, int nightCurrent, int nightPrevious)
		{
			Name = name;
			AccNo = accNo;
			DayCurrent = dayCurrent;
			DayPrevious = dayPrevious;
			NightCurrent = nightCurrent;
			NightPrevious = nightPrevious;
		}

        //methods

        public override string ToString()
        {
			string output = "";
			string formatter = "{0,-25}{1,10}\n";

			output += string.Format(formatter, "Name", Name);
            output += string.Format(formatter, "Account Number", AccNo);
            output += string.Format(formatter, "Current Day Units", DayCurrent);
            output += string.Format(formatter, "Previous Day Units", DayPrevious);
            output += string.Format(formatter, "Current Night Units", NightCurrent);
            output += string.Format(formatter, "Previous Day Units", NightPrevious);
            output += string.Format("Day units: {0} @ {1} per unit = {2}",GetDayUnits(), DAY_UNIT,GetDayCost());
            output += string.Format("Night units: {0} @ {1} per unit = {2}", GetNightUnits(), NIGHT_UNIT, GetNightCost());
            output += string.Format(formatter, "Subtotal", );
            return output;
        }

		public int GetDayUnits()
		{
			return DayCurrent - DayPrevious;
		}

        public int GetNightUnits()
        {
            return NightCurrent - NightPrevious;
        }

		public decimal GetDayCost()
		{
			return GetDayUnits() * DAY_UNIT;
		}

		public decimal GetNightCost()
		{
			return GetNightUnits() * NIGHT_UNIT;
		}

		public decimal GetSubtotal()
		{
			return GetDayCost() + GetNightCost();
		}
	}
}

