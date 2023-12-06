using System;
namespace SampleQuestion2
{
	public class PaySlip
	{
        //constants
        const decimal OVERTIME_RATE = 1.5m;
        const decimal TAX_RATE = 0.225m;
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
			string output = "";

			output += string.Format("\n{0,-22}: {1, 10}" ,  "Name" , Name);
			output += string.Format("\n{0,-22}: {1,10:C}", "Rate", RateOfPay);
			output += string.Format("\n{0,-22}: {1,10}", "hours", Hours);
			output += string.Format("\n{0,-22}: {1,10}", "Normal Hours", GetNormalHours());
			output += string.Format("\n{0,-22}: {1,10}", "Overtime Hours", GetOvertimeHours());
			output += string.Format("\n{0,-22}: {1,10:F2}", "Ordinary Pay" , GetNormalPay());
            output += string.Format("\n{0,-22}: {1,10:F2}", "Overtime Pay", GetOvertimePay());
            output += string.Format("\n{0,-22}: {1,10:F2}", "Gross Pay", GetGrossPay());
            output += string.Format("\n{0,-22}: {1,10:F2}", "Tax", GetTax());
            output += string.Format("\n{0,-22}: {1,10:F2}", "Pension", GetPension());
            output += string.Format("\n{0,-22}: {1,10:F2}", "Social club", GetSocial());
            output += string.Format("\n{0,-22}: {1,10:F2}", "Net Pay",GetNetPay());

            return output;
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

		public decimal GetPension()
		{
			return GetGrossPay() * PENSION;
		}

		public decimal GetSocial()
		{
			return GetGrossPay() * SOCIAL_CLUB;
		}

		public decimal GetNetPay()
		{
			return GetGrossPay() - GetTax() - GetPension() - GetSocial();
		}
	}
}

