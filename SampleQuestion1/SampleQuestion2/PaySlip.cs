using System;
namespace SampleQuestion2
{
	public class PaySlip
	{
		//properties
		public string Name { get; set; }
		public decimal RateOfPay { get; set; }
		public int Hours { get; set; }


		public PaySlip(string name, decimal rateOfPay, int hours)
		{
			Name = name;
			RateOfPay = rateOfPay;
			Hours = hours;
		}

        //methods calculate pay, deductions and disp

        public override string ToString()
        {
            return $"name: {Name} rate of pay: {RateOfPay} hours: {Hours}";
        }




    }
}

