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

            //Loop 3 times
            for (int i = 0; i < 3; i++)
            {
                //get user input 
                GetUserInput(out name, out accNo, out dayReadingCurrent, out dayReadingPrevious, out nightReadingCurrent, out nightReadingPrevious);

                //create object
                ElectricityBill eb1 = new ElectricityBill(name, accNo, dayReadingCurrent, dayReadingPrevious, nightReadingCurrent, nightReadingPrevious);

                //display object
                Console.WriteLine(eb1);

                //colour bars
                DisplayColourBars(eb1);

                //pause program
                Console.ReadLine();

            }

        }

        public static void GetUserInput(out string name, out string accNo, out int dayReadingCurrent, out int dayReadingPrevious, out int nightReadingCurrent, out int nightReadingPrevious)
        {
            Console.Write("Enter Name >> ");
            name = Console.ReadLine();
            Console.Write("Enter Account Number >> ");
            accNo = Console.ReadLine();
            Console.Write("Enter Current Day Reading >> ");
            dayReadingCurrent = int.Parse(Console.ReadLine());
            Console.Write("Enter Previous Day Reading >> ");
            dayReadingPrevious = int.Parse(Console.ReadLine());
            Console.Write("Enter Current Night Reading >> ");
            nightReadingCurrent = int.Parse(Console.ReadLine());
            Console.Write("Enter Previous Night Reading >> ");
            nightReadingPrevious = int.Parse(Console.ReadLine());
        }

        public static void DisplayColourBars(ElectricityBill eb)
        {
            int day = (int)(eb.GetDayPercent() * 100);
            int night = (int)(eb.GetNightPercent() * 100);

            Console.ResetColor();

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
            Console.ResetColor();
        }        
    }
}

