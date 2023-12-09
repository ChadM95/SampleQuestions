using System;
namespace ConsoleApp1
{
	public class Program
	{
        static void Main(string[] args)
        {
            //setup variables
            string name, accNo;
            int dayReadingCurrent, dayReadingPrevious, nightReadingCurrent, nightReadingPrevious;

            //get user input 
            ElectricityBill.GetUserInput(out name, out accNo, out dayReadingCurrent, out dayReadingPrevious, out nightReadingCurrent, out nightReadingPrevious);

            //create object
            ElectricityBill eb1 = new ElectricityBill(name,accNo,dayReadingCurrent,dayReadingPrevious,nightReadingCurrent,nightReadingPrevious);

            //display object
            Console.WriteLine(eb1);

            //colour bars
            DisplayColourBars(eb1);

            //pause program
            Console.ReadLine();

        }
        static void DisplayColourBars(ElectricityBill eb)
        {
            int day = (int)(eb.GetDayPercent() * 100);
            int night = (int)(eb.GetNightPercent() * 100);


            Console.BackgroundColor = ConsoleColor.Green;
            for (int i = 0; i < day; i++)
            {
                Console.Write(" ");
            }

            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < night; i++)
            {
                Console.Write(" ");
            }
        }        
    }
}

