using System;
namespace SampleQuestion4_1_
{
	public class ElectricityBill
	{
		//properties
		public string Name { get; set; }
		public string AccNo { get; set; }
		public int DayCurrent { get; set; }
		public int DayPrevious { get; set; }
		public int NightCurrent { get; set; }
		public int NightPrevious { get; set; }

		//ctors
		public ElectricityBill(string name, string accNo, int dayCurrent, int dayPrevious, int nightCurrent, int nightPrevious)
		{
			Name = name;
			AccNo = accNo;
			DayCurrent = dayCurrent;
			DayPrevious = dayPrevious;
			NightCurrent = nightCurrent;
			NightPrevious = nightPrevious;
		}
	}
}

