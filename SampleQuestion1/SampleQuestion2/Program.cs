namespace SampleQuestion2;

class Program
{
    static void Main(string[] args)
    {

        //setup
        Console.OutputEncoding = System.Text.Encoding.UTF8; 
        string name;
        decimal payRate;
        int hours;

        //get user input
        GetUserInput(out name, out payRate, out hours);

        //create object
        PaySlip p1 = new PaySlip(name,payRate,hours);

        //display object
        Console.WriteLine(p1);

        Console.ReadLine(); // pause
    }

    private static void GetUserInput(out string name, out decimal payRate, out int hours)
    {
        Console.Write("enter name> ");
        name = Console.ReadLine();

        Console.Write("enter rate> ");
        payRate = decimal.Parse(Console.ReadLine());

        Console.Write("enter hours > ");
        hours = int.Parse(Console.ReadLine());
    }


}

