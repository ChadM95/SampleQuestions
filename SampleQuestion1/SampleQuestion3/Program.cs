using System;
namespace ConsoleApp1
{
	public class Program
	{
        static void Main(string[] args)
        {
            //setup
            string name, accNo;
            int dayReadingCurrent, dayReadingPrevious, nightReadingCurrent, nightReadingPrevious;

            ElectricityBill.GetUserInput(out name, out accNo, out dayReadingCurrent, out dayReadingPrevious, out nightReadingCurrent, out nightReadingPrevious);


            ElectricityBill eb1 = new ElectricityBill(name,accNo,dayReadingCurrent,dayReadingPrevious,nightReadingCurrent,nightReadingPrevious);

            Console.WriteLine(eb1);

            Console.ReadLine();
        }

    }
}

