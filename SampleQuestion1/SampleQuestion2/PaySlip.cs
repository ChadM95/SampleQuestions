using System;
namespace SampleQuestion2
{
	public class PaySlip
	{
		//properties
		public string Name { get; set; }
		public int RateOfPay { get; set; }
		public int Hours { get; set; }


		public PaySlip(string name, int rateOfPay, int hours)
		{
			Name = name;
			RateOfPay = rateOfPay;
			Hours = hours;
		}

	}
}

