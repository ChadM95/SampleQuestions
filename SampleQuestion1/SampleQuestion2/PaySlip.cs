using System;
namespace SampleQuestion2
{
	public class PaySlip
	{
        //constants
        const decimal OVERTIME_RATE = 1.5m;
        const decimal TAX_RATE = 22.5m;
        const decimal SOCIAL_CLUB = 0.05M;
        const decimal PENSION = 0.08M;

        //properties
        public string Name { get; set; }
		public decimal RateOfPay { get; set; }
		public int Hours { get; set; }

		//ctors
        public PaySlip(string name, decimal rateOfPay, int hours)
		{
			Name = name;
			RateOfPay = rateOfPay;
			Hours = hours;
		}

        //methods calculate pay, deductions and disp

        public override string ToString()
        {
            return $"name: {Name} \nrate of pay: {RateOfPay:C} \nhours: {Hours}"
			+ $"\nNormal Hours: {GetNormalHours()} \nOvertime Hours: {GetOvertimeHours()}"
			+ $"\nNormal Hourly rate: {RateOfPay:C} \n";
        }

		public int GetNormalHours()
		{
			if (Hours > 35)
			{
				return 35;
			}
			else return Hours;
		}

		public int GetOvertimeHours()
		{
			if (Hours > 35)
			{
				return Hours - 35;
			}
			else return 0;
		}

		public decimal GetNormalPay()
		{
			return GetNormalHours() * RateOfPay;
		}

		public decimal GetOvertimePay()
		{
			return GetOvertimeHours() * (RateOfPay * OVERTIME_RATE);
		}

		public decimal GetGrossPay()
		{
			return GetNormalPay() + GetOvertimePay();
		}

		public decimal GetTax()
		{
			return GetGrossPay() * TAX_RATE;
		}

		public decimal Get
	}
}

