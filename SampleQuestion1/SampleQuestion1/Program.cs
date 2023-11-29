namespace SampleQuestion1;

class Program
{
    static void Main(string[] args)
    {
        //setup variables
        string name, registration;
        int miles, hours, partsCost, labourCost;


        //input
        Console.Write("Enter name> ");
        name = Console.ReadLine();

        Console.Write("Enter car registration> ");
        registration = Console.ReadLine();

        Console.Write("Enter miles on clock> ");
        miles = int.Parse(Console.ReadLine());

        Console.Write("Enter hours labour> ");
        hours = int.Parse(Console.ReadLine());

        Console.Write("Enter cost of parts> ");
        partsCost = int.Parse(Console.ReadLine());

        //create object
        ServiceInvoice s1 = new ServiceInvoice(name,registration,miles,hours,partsCost);

        //calculations / methods

        labourCost = s1.CalculateLabourCost(hours);





        Console.ReadLine();
    }
}

