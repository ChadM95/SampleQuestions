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
			return string.Format($"{Name} {AccNo}");
        }




    }
}

