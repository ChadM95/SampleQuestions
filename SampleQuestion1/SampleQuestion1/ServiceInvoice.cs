using System;
namespace SampleQuestion1
{
	public class ServiceInvoice
	{
		//constants
		const int LABOUR_COST = 45;
		const double PARTS_VAT = 0.135;
		const double LABOUR_VAT = 0.215;
		const double DISCOUNT = 0.05;

		//properties
		public string Name { get; set; }
		public string Registration { get; set; }
		public int MilesOnClock { get; set; }
		public int HoursLabour { get; set; }
		public int PartsCost { get; set; }



		//ctor
		public ServiceInvoice(string name, string registration, int miles, int hours, int parts)
		{
			Name = name;
			Registration = registration;
			MilesOnClock = miles;
			HoursLabour = hours;
			PartsCost = parts;
		}


		//methods



	}
}

